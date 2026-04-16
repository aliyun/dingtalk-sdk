<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateFloatImageRequest;

use AlibabaCloud\Tea\Model;

class coordinate extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var float
     */
    public $height;

    /**
     * @description This parameter is required.
     *
     * @var float
     */
    public $offsetX;

    /**
     * @description This parameter is required.
     *
     * @var float
     */
    public $offsetY;

    /**
     * @description This parameter is required.
     *
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
