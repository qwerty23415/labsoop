using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop;

public class Drawning
{
    public Entity? Entity  { get; private set; }

    private int? _pictureWidth;

    private int? _pictureHeight;

    private int? _startPosX;

    private int? _startPosY;

    private readonly int _drawningCarWidth = 110;

    private readonly int _drawningCarHeight = 60;

    public void Init(int speed, double weight, Color bodyColor, Color additionalColor, bool body, bool tent)
    {
        Entity = new Entity();
        Entity.Init(speed, weight, bodyColor, additionalColor, body, tent);
        _pictureWidth = null;
        _pictureHeight = null;
        _startPosX = null;
        _startPosY = null;
    }
    public bool SetPictureSize(int width, int height)
    {
        if (width < _drawningCarWidth || height < _drawningCarHeight)
        {
            return false;
        }
        _pictureWidth = width;
        _pictureHeight = height;
        return true;
    }
    public void SetPosition(int x, int y)
    { 
        if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
        {
            return; 
        }

        if (x < 0)
        {
            _startPosX = 0;
        }
        else if (x > _pictureWidth.Value - _drawningCarWidth)
        {
            _startPosX = _pictureWidth.Value - _drawningCarWidth;
        }
        else
        {
            _startPosX = x;
        }

        if (y < 0)
        {
            _startPosY = 0;
        }
        else if (y > _pictureHeight.Value - _drawningCarHeight)
        {
            _startPosY = _pictureHeight.Value - _drawningCarHeight;
        }
        else
        {
            _startPosY = y;
        }

    }
    public bool MoveTransport(DirectionType direction)
    {
        if (Entity == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return false;
        }

        switch (direction)
        { 
            case DirectionType.Left:
                if (_startPosX.Value - Entity.Step > 0)
                { 
                    _startPosX -= (int)Entity.Step;
                }
                return true;
            case DirectionType.Up:
                if (_startPosY.Value - Entity.Step > 0)
                {
                    _startPosY -= (int)Entity.Step;
                }
                return true;
            case DirectionType.Right:
                if (_startPosX.Value + Entity.Step < 0)  
                {
                    _startPosX += (int)Entity.Step;
                }
                return true;
            case DirectionType.Down:
                if (_startPosY.Value + Entity.Step < 0) 
                {
                    _startPosY += (int)Entity.Step;
                }
                return true;
            default:
                return false;

        }
    }

    public void DrawTransport(Graphics g)
    {
        if (Entity != null || _startPosX.HasValue || _startPosY.HasValue)
        {
            return;
        }
    }
}
