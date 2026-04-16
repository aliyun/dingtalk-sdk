<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CriteriaValue\conditions;
use AlibabaCloud\Tea\Model;

class CriteriaValue extends Model
{
    /**
     * @var string
     */
    public $filterType;

    /**
     * @var string[]
     */
    public $visibleValues;

    /**
     * @var conditions[]
     */
    public $conditions;

    /**
     * @var string
     */
    public $conditionOperator;

    /**
     * @var string
     */
    public $backgroundColor;

    /**
     * @var string
     */
    public $fontColor;
    protected $_name = [
        'filterType' => 'filterType',
        'visibleValues' => 'visibleValues',
        'conditions' => 'conditions',
        'conditionOperator' => 'conditionOperator',
        'backgroundColor' => 'backgroundColor',
        'fontColor' => 'fontColor',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->filterType) {
            $res['filterType'] = $this->filterType;
        }
        if (null !== $this->visibleValues) {
            $res['visibleValues'] = $this->visibleValues;
        }
        if (null !== $this->conditions) {
            $res['conditions'] = [];
            if (null !== $this->conditions && \is_array($this->conditions)) {
                $n = 0;
                foreach ($this->conditions as $item) {
                    $res['conditions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->conditionOperator) {
            $res['conditionOperator'] = $this->conditionOperator;
        }
        if (null !== $this->backgroundColor) {
            $res['backgroundColor'] = $this->backgroundColor;
        }
        if (null !== $this->fontColor) {
            $res['fontColor'] = $this->fontColor;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CriteriaValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['filterType'])) {
            $model->filterType = $map['filterType'];
        }
        if (isset($map['visibleValues'])) {
            if (!empty($map['visibleValues'])) {
                $model->visibleValues = $map['visibleValues'];
            }
        }
        if (isset($map['conditions'])) {
            if (!empty($map['conditions'])) {
                $model->conditions = [];
                $n = 0;
                foreach ($map['conditions'] as $item) {
                    $model->conditions[$n++] = null !== $item ? conditions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['conditionOperator'])) {
            $model->conditionOperator = $map['conditionOperator'];
        }
        if (isset($map['backgroundColor'])) {
            $model->backgroundColor = $map['backgroundColor'];
        }
        if (isset($map['fontColor'])) {
            $model->fontColor = $map['fontColor'];
        }

        return $model;
    }
}
