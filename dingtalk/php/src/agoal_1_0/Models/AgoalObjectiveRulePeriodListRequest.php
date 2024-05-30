<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalObjectiveRulePeriodListRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $objectiveRuleId;
    protected $_name = [
        'objectiveRuleId' => 'objectiveRuleId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalObjectiveRulePeriodListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectiveRuleId'])) {
            $model->objectiveRuleId = $map['objectiveRuleId'];
        }

        return $model;
    }
}
