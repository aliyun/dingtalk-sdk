<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetFilterCriteriaRequest;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\SetFilterCriteriaRequest\filterCriteria\conditions;
use AlibabaCloud\Tea\Model;

class filterCriteria extends Model
{
    /**
     * @var string
     */
    public $backgroundColor;

    /**
     * @var string
     */
    public $conditionOperator;

    /**
     * @var conditions[]
     */
    public $conditions;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $filterType;

    /**
     * @var string
     */
    public $fontColor;

    /**
     * @var string[]
     */
    public $visibleValues;
    protected $_name = [
        'backgroundColor' => 'backgroundColor',
        'conditionOperator' => 'conditionOperator',
        'conditions' => 'conditions',
        'filterType' => 'filterType',
        'fontColor' => 'fontColor',
        'visibleValues' => 'visibleValues',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundColor) {
            $res['backgroundColor'] = $this->backgroundColor;
        }
        if (null !== $this->conditionOperator) {
            $res['conditionOperator'] = $this->conditionOperator;
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
        if (null !== $this->filterType) {
            $res['filterType'] = $this->filterType;
        }
        if (null !== $this->fontColor) {
            $res['fontColor'] = $this->fontColor;
        }
        if (null !== $this->visibleValues) {
            $res['visibleValues'] = $this->visibleValues;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filterCriteria
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['backgroundColor'])) {
            $model->backgroundColor = $map['backgroundColor'];
        }
        if (isset($map['conditionOperator'])) {
            $model->conditionOperator = $map['conditionOperator'];
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
        if (isset($map['filterType'])) {
            $model->filterType = $map['filterType'];
        }
        if (isset($map['fontColor'])) {
            $model->fontColor = $map['fontColor'];
        }
        if (isset($map['visibleValues'])) {
            if (!empty($map['visibleValues'])) {
                $model->visibleValues = $map['visibleValues'];
            }
        }

        return $model;
    }
}
