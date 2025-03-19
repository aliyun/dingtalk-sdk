<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetBorderRequest\type;
use AlibabaCloud\Tea\Model;

class SetBorderRequest extends Model
{
    /**
     * @var string
     */
    public $color;

    /**
     * @var string
     */
    public $style;

    /**
     * @var type
     */
    public $type;

    /**
     * @description This parameter is required.
     *
     * @example ppgAQuHfOoNVpJiStDwWCEgiEiE
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'color' => 'color',
        'style' => 'style',
        'type' => 'type',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->color) {
            $res['color'] = $this->color;
        }
        if (null !== $this->style) {
            $res['style'] = $this->style;
        }
        if (null !== $this->type) {
            $res['type'] = null !== $this->type ? $this->type->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetBorderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['color'])) {
            $model->color = $map['color'];
        }
        if (isset($map['style'])) {
            $model->style = $map['style'];
        }
        if (isset($map['type'])) {
            $model->type = type::fromMap($map['type']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
