Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtaInfo As Integer)

    'some codes is hidded... xd
    ' left click:
mouse_event(&H8, 0, 0, 0, 0) 'left click down
mouse_event(&H10, 0, 0, 0, 0) ' left click up
    'right click:
mouse_event(&H2, 0, 0, 0, 0) ' right click down
mouse_event(&H4, 0, 0, 0, 0) ' right click up
