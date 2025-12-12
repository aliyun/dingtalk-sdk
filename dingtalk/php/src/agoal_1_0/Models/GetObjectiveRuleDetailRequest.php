<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetObjectiveRuleDetailRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $objectiveRuleId;
    protected $_name = [
        'objectiveRuleId' => 'objectiveRuleId',
    ];

    public function validate() {}

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
     * @return GetObjectiveRuleDetailRequest
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
