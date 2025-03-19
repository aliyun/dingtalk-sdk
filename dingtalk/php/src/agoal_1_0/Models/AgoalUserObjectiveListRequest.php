<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalUserObjectiveListRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 211042291978xxxx
     *
     * @var string
     */
    public $dingUserId;

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
     * @var string[]
     */
    public $periodIds;
    protected $_name = [
        'dingUserId' => 'dingUserId',
        'objectiveRuleId' => 'objectiveRuleId',
        'periodIds' => 'periodIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->objectiveRuleId) {
            $res['objectiveRuleId'] = $this->objectiveRuleId;
        }
        if (null !== $this->periodIds) {
            $res['periodIds'] = $this->periodIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalUserObjectiveListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['objectiveRuleId'])) {
            $model->objectiveRuleId = $map['objectiveRuleId'];
        }
        if (isset($map['periodIds'])) {
            if (!empty($map['periodIds'])) {
                $model->periodIds = $map['periodIds'];
            }
        }

        return $model;
    }
}
