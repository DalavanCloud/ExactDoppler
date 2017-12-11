﻿Imports System.Drawing
Imports Bwl.Imaging
Imports ExactAudio

''' <summary>
''' "Водопад" в формате RGB + связанный с изображением аудиопоток
''' </summary>
Public Class DopplerWaterfall
    Private Const _defaultWidth = 892

    Private _waterfallRowBlocks As New Queue(Of RGBMatrix)
    Private _waterfallPcmBlocks As New Queue(Of Single())
    Private _maxBlockCount As Integer = 88 '~1 минута
    Private _scrolledBlocksCount As Long = 0
    Private _autoScroll As Boolean
    Private _width As Integer

    Private _syncRoot As New Object()

    Public Property MaxBlockCount As Integer
        Get
            SyncLock _syncRoot
                Return _maxBlockCount
            End SyncLock
        End Get
        Set(value As Integer)
            _maxBlockCount = value
        End Set
    End Property

    Public ReadOnly Property BlockCount As Integer
        Get
            SyncLock _syncRoot
                Return _waterfallRowBlocks.Count
            End SyncLock
        End Get
    End Property

    Public Property ScrolledBlockCount As Long
        Get
            SyncLock _syncRoot
                Return _scrolledBlocksCount
            End SyncLock
        End Get
        Set(value As Long)
            SyncLock _syncRoot
                _scrolledBlocksCount = value
            End SyncLock
        End Set
    End Property

    Public Sub New(autoScroll As Boolean)
        Me.New(autoScroll, -1)
    End Sub

    Public Sub New(autoScroll As Boolean, width As Integer)
        _autoScroll = autoScroll
        _width = width
    End Sub

    Public Sub Clear()
        SyncLock _syncRoot
            _waterfallRowBlocks.Clear()
            _waterfallPcmBlocks.Clear()
            _scrolledBlocksCount = 0
        End SyncLock
    End Sub

    Public Function Add(waterfallRowBlock As RGBMatrix, Optional waterfallPcmBlock As Single() = Nothing) As Boolean
        SyncLock _syncRoot
            If _width = -1 Then
                _width = _defaultWidth
            End If
            If waterfallRowBlock IsNot Nothing Then
                If waterfallRowBlock.Width > _width Then 'Если поступающий на вход блок слишком большой - ошибка!
                    Throw New Exception("DopplerWaterfall: waterfallRowBlock.Width > _width")
                Else
                    Dim widthAddition = _width - waterfallRowBlock.Width 'Рассчитываем "добавку" к ширине...
                    If widthAddition = 0 Then
                        _waterfallRowBlocks.Enqueue(waterfallRowBlock)
                    Else
                        Dim waterfallRowBlockAligned = ImageUtils.ExtendWidth(waterfallRowBlock, widthAddition) '...и обеспечиваем её
                        _waterfallRowBlocks.Enqueue(waterfallRowBlockAligned)
                    End If
                    _waterfallPcmBlocks.Enqueue(waterfallPcmBlock)
                End If
            End If

            'Количество блоков на удаление (автоподдержание размера)
            Dim blocksToRemove = _waterfallRowBlocks.Count - MaxBlockCount

            If _autoScroll Then
                'Удаление блоков, выходящих за допустимые границы
                If blocksToRemove > 0 Then
                    For i = 1 To blocksToRemove
                        _waterfallRowBlocks.Dequeue()
                        _waterfallPcmBlocks.Dequeue()
                        _scrolledBlocksCount += 1
                    Next
                End If
                Return True 'Автоподдержание размера, всё нормально
            Else
                Return blocksToRemove < 0 'Резервы на добавление есть (следующая итерация не вызовет переполнение)?
            End If
        End SyncLock
    End Function

    Public Function ToRGBMatrix(Optional scale As Single = 1.0) As RGBMatrix
        SyncLock _syncRoot
            If Not _waterfallRowBlocks.Any() Then
                Return Nothing
            End If
            Dim rowsCounter = _waterfallRowBlocks.Sum(Function(item) item.Height)
            Dim waterfall = New RGBMatrix(_waterfallRowBlocks.Peek.Width, rowsCounter)

            Dim globalRowOffset As Integer = 0
            For Each rowBlock In _waterfallRowBlocks
                Parallel.For(0, 3, Sub(channel As Integer)
                                       For y = 0 To rowBlock.Height - 1
                                           For x = 0 To rowBlock.Width - 1
                                               Dim scaled = CInt(rowBlock.MatrixPixel(channel, x, y) * scale)
                                               If scaled > Byte.MaxValue Then
                                                   scaled = Byte.MaxValue
                                               End If
                                               waterfall.MatrixPixel(channel, x, globalRowOffset + y) = scaled
                                           Next
                                       Next
                                   End Sub)
                globalRowOffset += rowBlock.Height
            Next

            Return waterfall
        End SyncLock
    End Function

    Public Function ToBitmap(Optional scale As Single = 1.0) As Bitmap
        SyncLock _syncRoot
            Dim waterfall = ToRGBMatrix()
            If waterfall IsNot Nothing Then
                Return waterfall.ToBitmap(scale)
            Else
                Return Nothing
            End If
        End SyncLock
    End Function

    Public Function ToPcm(Optional scale As Single = 1.0) As Single()
        Dim pcm As New Queue(Of Single)
        Dim minScaledPcm As Single = Single.MaxValue
        Dim maxScaledPcm As Single = 0
        SyncLock _syncRoot
            For Each pcmBlock In _waterfallPcmBlocks
                If pcmBlock IsNot Nothing Then
                    For Each pcmSample In pcmBlock
                        Dim scaled = pcmSample * scale
                        If scaled < minScaledPcm Then
                            minScaledPcm = scaled
                        End If
                        If scaled > maxScaledPcm Then
                            maxScaledPcm = scaled
                        End If
                        pcm.Enqueue(scaled)
                    Next
                End If
            Next
        End SyncLock
        Dim result = New Single() {}
        If pcm.Any() Then
            Dim pcmArr = pcm.ToArray()
            Dim normalizer As New Normalizer()
            pcm.Clear()
            normalizer.Init(minScaledPcm, maxScaledPcm, -1.0, 1.0)
            For Each pcmSample In pcmArr
                pcm.Enqueue(normalizer.Normalize(pcmSample))
            Next
            result = pcm.ToArray()
        End If
        Return result
    End Function

    Public Sub Write(filaName As String)
        SyncLock _syncRoot
            Dim bmp = ToBitmap()
            If bmp IsNot Nothing Then
                bmp.Save(filaName)
            End If
        End SyncLock
    End Sub
End Class
