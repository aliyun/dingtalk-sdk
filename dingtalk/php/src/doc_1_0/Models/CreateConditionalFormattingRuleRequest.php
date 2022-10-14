<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleRequest\cellStyle;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleRequest\duplicateCondition;
use AlibabaCloud\Tea\Model;

class CreateConditionalFormattingRuleRequest extends Model
{
    /**
     * @description 设定当前配置的规则的单元格样式
     *
     * @var cellStyle
     */
    public $cellStyle;

    /**
     * @description 重复值规则
     *
     * @var duplicateCondition
     */
    public $duplicateCondition;

    /**
     * @description 条件格式生效的区域。
     *
     * @var string[]
     */
    public $ranges;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'cellStyle'          => 'cellStyle',
        'duplicateCondition' => 'duplicateCondition',
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
