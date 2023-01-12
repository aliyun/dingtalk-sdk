<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateRangeRequest extends Model
{
    /**
     * @description 背景色
     * 1000
     * @var string[][]
     */
    public $backgroundColors;

    /**
     * @description 超链接
     * 1000
     * @var undefined[][]
     */
    public $hyperlinks;

    /**
     * @description 数字格式
     *
     * @var string
     */
    public $numberFormat;

    /**
     * @description 值
     * 1000
     * @var string[][]
     */
    public $values;

    /**
     * @description 操作人id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'backgroundColors' => 'backgroundColors',
        'hyperlinks'       => 'hyperlinks',
        'numberFormat'     => 'numberFormat',
        'values'           => 'values',
        'operatorId'       => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundColors) {
            $res['backgroundColors'] = $this->backgroundColors;
        }
        if (null !== $this->hyperlinks) {
            $res['hyperlinks'] = $this->hyperlinks;
        }
        if (null !== $this->numberFormat) {
            $res['numberFormat'] = $this->numberFormat;
        }
        if (null !== $this->values) {
            $res['values'] = $this->values;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
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
        if (isset($map['backgroundColors'])) {
            if (!empty($map['backgroundColors'])) {
                $model->backgroundColors = $map['backgroundColors'];
            }
        }
        if (isset($map['hyperlinks'])) {
            if (!empty($map['hyperlinks'])) {
                $model->hyperlinks = $map['hyperlinks'];
            }
        }
        if (isset($map['numberFormat'])) {
            $model->numberFormat = $map['numberFormat'];
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = $map['values'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
