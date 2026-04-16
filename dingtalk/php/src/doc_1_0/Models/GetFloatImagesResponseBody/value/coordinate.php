<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetFloatImagesResponseBody\value;

use AlibabaCloud\Tea\Model;

class coordinate extends Model
{
    /**
     * @var float
     */
    public $height;

    /**
     * @var float
     */
    public $offsetX;

    /**
     * @var float
     */
    public $offsetY;

    /**
     * @var float
     */
    public $width;
    protected $_name = [
        'height' => 'height',
        'offsetX' => 'offsetX',
        'offsetY' => 'offsetY',
        'width' => 'width',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->height) {
            $res['height'] = $this->height;
        }
        if (null !== $this->offsetX) {
            $res['offsetX'] = $this->offsetX;
        }
        if (null !== $this->offsetY) {
            $res['offsetY'] = $this->offsetY;
        }
        if (null !== $this->width) {
            $res['width'] = $this->width;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return coordinate
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['height'])) {
            $model->height = $map['height'];
        }
        if (isset($map['offsetX'])) {
            $model->offsetX = $map['offsetX'];
        }
        if (isset($map['offsetY'])) {
            $model->offsetY = $map['offsetY'];
        }
        if (isset($map['width'])) {
            $model->width = $map['width'];
        }

        return $model;
    }
}
