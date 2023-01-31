<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRangeResponseBody extends Model
{
    /**
     * @description 背景颜色
     *
     * @var undefined[][]
     */
    public $backgroundColors;

    /**
     * @description 展示值
     *
     * @var string[][]
     */
    public $displayValues;

    /**
     * @description 公式
     *
     * @var string[][]
     */
    public $formulas;

    /**
     * @description 值
     *
     * @var mixed[][]
     */
    public $values;
    protected $_name = [
        'backgroundColors' => 'backgroundColors',
        'displayValues'    => 'displayValues',
        'formulas'         => 'formulas',
        'values'           => 'values',
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
        if (null !== $this->displayValues) {
            $res['displayValues'] = $this->displayValues;
        }
        if (null !== $this->formulas) {
            $res['formulas'] = $this->formulas;
        }
        if (null !== $this->values) {
            $res['values'] = $this->values;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRangeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['backgroundColors'])) {
            if (!empty($map['backgroundColors'])) {
                $model->backgroundColors = $map['backgroundColors'];
            }
        }
        if (isset($map['displayValues'])) {
            if (!empty($map['displayValues'])) {
                $model->displayValues = $map['displayValues'];
            }
        }
        if (isset($map['formulas'])) {
            if (!empty($map['formulas'])) {
                $model->formulas = $map['formulas'];
            }
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = $map['values'];
            }
        }

        return $model;
    }
}
