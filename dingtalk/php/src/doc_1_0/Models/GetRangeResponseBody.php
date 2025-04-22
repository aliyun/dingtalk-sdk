<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRangeResponseBody extends Model
{
    /**
     * @var undefined[][]
     */
    public $backgroundColors;

    /**
     * @var mixed[][]
     */
    public $complexValues;

    /**
     * @var string[][]
     */
    public $displayValues;

    /**
     * @var int[][]
     */
    public $fontSizes;

    /**
     * @var string[][]
     */
    public $fontWeights;

    /**
     * @var string[][]
     */
    public $formulas;

    /**
     * @var string[][]
     */
    public $horizontalAlignments;

    /**
     * @var undefined[][]
     */
    public $hyperlinks;

    /**
     * @var mixed[][]
     */
    public $values;

    /**
     * @var string[][]
     */
    public $verticalAlignments;
    protected $_name = [
        'backgroundColors' => 'backgroundColors',
        'complexValues' => 'complexValues',
        'displayValues' => 'displayValues',
        'fontSizes' => 'fontSizes',
        'fontWeights' => 'fontWeights',
        'formulas' => 'formulas',
        'horizontalAlignments' => 'horizontalAlignments',
        'hyperlinks' => 'hyperlinks',
        'values' => 'values',
        'verticalAlignments' => 'verticalAlignments',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundColors) {
            $res['backgroundColors'] = $this->backgroundColors;
        }
        if (null !== $this->complexValues) {
            $res['complexValues'] = $this->complexValues;
        }
        if (null !== $this->displayValues) {
            $res['displayValues'] = $this->displayValues;
        }
        if (null !== $this->fontSizes) {
            $res['fontSizes'] = $this->fontSizes;
        }
        if (null !== $this->fontWeights) {
            $res['fontWeights'] = $this->fontWeights;
        }
        if (null !== $this->formulas) {
            $res['formulas'] = $this->formulas;
        }
        if (null !== $this->horizontalAlignments) {
            $res['horizontalAlignments'] = $this->horizontalAlignments;
        }
        if (null !== $this->hyperlinks) {
            $res['hyperlinks'] = $this->hyperlinks;
        }
        if (null !== $this->values) {
            $res['values'] = $this->values;
        }
        if (null !== $this->verticalAlignments) {
            $res['verticalAlignments'] = $this->verticalAlignments;
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
        if (isset($map['complexValues'])) {
            if (!empty($map['complexValues'])) {
                $model->complexValues = $map['complexValues'];
            }
        }
        if (isset($map['displayValues'])) {
            if (!empty($map['displayValues'])) {
                $model->displayValues = $map['displayValues'];
            }
        }
        if (isset($map['fontSizes'])) {
            if (!empty($map['fontSizes'])) {
                $model->fontSizes = $map['fontSizes'];
            }
        }
        if (isset($map['fontWeights'])) {
            if (!empty($map['fontWeights'])) {
                $model->fontWeights = $map['fontWeights'];
            }
        }
        if (isset($map['formulas'])) {
            if (!empty($map['formulas'])) {
                $model->formulas = $map['formulas'];
            }
        }
        if (isset($map['horizontalAlignments'])) {
            if (!empty($map['horizontalAlignments'])) {
                $model->horizontalAlignments = $map['horizontalAlignments'];
            }
        }
        if (isset($map['hyperlinks'])) {
            if (!empty($map['hyperlinks'])) {
                $model->hyperlinks = $map['hyperlinks'];
            }
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = $map['values'];
            }
        }
        if (isset($map['verticalAlignments'])) {
            if (!empty($map['verticalAlignments'])) {
                $model->verticalAlignments = $map['verticalAlignments'];
            }
        }

        return $model;
    }
}
