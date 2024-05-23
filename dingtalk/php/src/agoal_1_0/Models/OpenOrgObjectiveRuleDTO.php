<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenOrgObjectiveRuleDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $objectiveRuleId;

    /**
     * @description This parameter is required.
     *
     * @example 测试规则
     *
     * @var string
     */
    public $objectiveRuleName;
    protected $_name = [
        'objectiveRuleId'   => 'objectiveRuleId',
        'objectiveRuleName' => 'objectiveRuleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectiveRuleId) {
            $res['objectiveRuleId'] = $this->objectiveRuleId;
        }
        if (null !== $this->objectiveRuleName) {
            $res['objectiveRuleName'] = $this->objectiveRuleName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenOrgObjectiveRuleDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectiveRuleId'])) {
            $model->objectiveRuleId = $map['objectiveRuleId'];
        }
        if (isset($map['objectiveRuleName'])) {
            $model->objectiveRuleName = $map['objectiveRuleName'];
        }

        return $model;
    }
}
