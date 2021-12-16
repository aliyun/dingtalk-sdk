<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateRangeRequest extends Model
{
    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 值
     *
     * @var string[][]
     */
    public $values;

    /**
     * @description 背景色
     *
     * @var string[][]
     */
    public $backgroundColors;
    protected $_name = [
        'operatorId'       => 'operatorId',
        'values'           => 'values',
        'backgroundColors' => 'backgroundColors',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->values) {
            $res['values'] = $this->values;
        }
        if (null !== $this->backgroundColors) {
            $res['backgroundColors'] = $this->backgroundColors;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateRangeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = $map['values'];
            }
        }
        if (isset($map['backgroundColors'])) {
            if (!empty($map['backgroundColors'])) {
                $model->backgroundColors = $map['backgroundColors'];
            }
        }

        return $model;
    }
}
