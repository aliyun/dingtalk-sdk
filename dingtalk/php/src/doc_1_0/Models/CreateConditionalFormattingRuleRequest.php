<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleRequest\cellStyle;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleRequest\duplicateCondition;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleRequest\numberCondition;
use AlibabaCloud\Tea\Model;

class CreateConditionalFormattingRuleRequest extends Model
{
    /**
     * @var cellStyle
     */
    public $cellStyle;

    /**
     * @var duplicateCondition
     */
    public $duplicateCondition;

    /**
     * @var numberCondition
     */
    public $numberCondition;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $ranges;

    /**
     * @description This parameter is required.
     *
     * @example ppgAQuHfOoNVpJiStDwWCEgiEiE
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'cellStyle'          => 'cellStyle',
        'duplicateCondition' => 'duplicateCondition',
        'numberCondition'    => 'numberCondition',
        'ranges'             => 'ranges',
        'operatorId'         => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cellStyle) {
            $res['cellStyle'] = null !== $this->cellStyle ? $this->cellStyle->toMap() : null;
        }
        if (null !== $this->duplicateCondition) {
            $res['duplicateCondition'] = null !== $this->duplicateCondition ? $this->duplicateCondition->toMap() : null;
        }
        if (null !== $this->numberCondition) {
            $res['numberCondition'] = null !== $this->numberCondition ? $this->numberCondition->toMap() : null;
        }
        if (null !== $this->ranges) {
            $res['ranges'] = $this->ranges;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateConditionalFormattingRuleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cellStyle'])) {
            $model->cellStyle = cellStyle::fromMap($map['cellStyle']);
        }
        if (isset($map['duplicateCondition'])) {
            $model->duplicateCondition = duplicateCondition::fromMap($map['duplicateCondition']);
        }
        if (isset($map['numberCondition'])) {
            $model->numberCondition = numberCondition::fromMap($map['numberCondition']);
        }
        if (isset($map['ranges'])) {
            if (!empty($map['ranges'])) {
                $model->ranges = $map['ranges'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
