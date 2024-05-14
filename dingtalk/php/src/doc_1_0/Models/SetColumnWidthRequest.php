<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetColumnWidthRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $column;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $width;

    /**
     * @description This parameter is required.
     *
     * @example ppgAQuHfOoNVpJiStDwWCEgiEiE
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'column'     => 'column',
        'width'      => 'width',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->column) {
            $res['column'] = $this->column;
        }
        if (null !== $this->width) {
            $res['width'] = $this->width;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetColumnWidthRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['column'])) {
            $model->column = $map['column'];
        }
        if (isset($map['width'])) {
            $model->width = $map['width'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
