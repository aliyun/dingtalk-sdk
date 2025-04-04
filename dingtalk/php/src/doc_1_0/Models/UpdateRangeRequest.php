<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateRangeRequest extends Model
{
    /**
     * @var string[][]
     */
    public $backgroundColors;

    /**
     * @var mixed[][]
     */
    public $complexValues;

    /**
     * @var string[][]
     */
    public $fontColors;

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
    public $horizontalAlignments;

    /**
     * @var undefined[][]
     */
    public $hyperlinks;

    /**
     * @example number_format
     *
     * @var string
     */
    public $numberFormat;

    /**
     * @var string[][]
     */
    public $values;

    /**
     * @var string[][]
     */
    public $verticalAlignments;

    /**
     * @example word_wrap
     *
     * @var string
     */
    public $wordWrap;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'backgroundColors' => 'backgroundColors',
        'complexValues' => 'complexValues',
        'fontColors' => 'fontColors',
        'fontSizes' => 'fontSizes',
        'fontWeights' => 'fontWeights',
        'horizontalAlignments' => 'horizontalAlignments',
        'hyperlinks' => 'hyperlinks',
        'numberFormat' => 'numberFormat',
        'values' => 'values',
        'verticalAlignments' => 'verticalAlignments',
        'wordWrap' => 'wordWrap',
        'operatorId' => 'operatorId',
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
        if (null !== $this->fontColors) {
            $res['fontColors'] = $this->fontColors;
        }
        if (null !== $this->fontSizes) {
            $res['fontSizes'] = $this->fontSizes;
        }
        if (null !== $this->fontWeights) {
            $res['fontWeights'] = $this->fontWeights;
        }
        if (null !== $this->horizontalAlignments) {
            $res['horizontalAlignments'] = $this->horizontalAlignments;
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
        if (null !== $this->verticalAlignments) {
            $res['verticalAlignments'] = $this->verticalAlignments;
        }
        if (null !== $this->wordWrap) {
            $res['wordWrap'] = $this->wordWrap;
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
        if (isset($map['complexValues'])) {
            if (!empty($map['complexValues'])) {
                $model->complexValues = $map['complexValues'];
            }
        }
        if (isset($map['fontColors'])) {
            if (!empty($map['fontColors'])) {
                $model->fontColors = $map['fontColors'];
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
        if (isset($map['numberFormat'])) {
            $model->numberFormat = $map['numberFormat'];
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
        if (isset($map['wordWrap'])) {
            $model->wordWrap = $map['wordWrap'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
