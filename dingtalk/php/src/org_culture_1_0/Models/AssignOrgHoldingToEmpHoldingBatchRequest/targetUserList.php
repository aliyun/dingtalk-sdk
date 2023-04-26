<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\AssignOrgHoldingToEmpHoldingBatchRequest;

use AlibabaCloud\Tea\Model;

class targetUserList extends Model
{
    /**
     * @example 4353453454241
     *
     * @var string
     */
    public $outId;

    /**
     * @example 551341216920908910
     *
     * @var string
     */
    public $targetUserId;
    protected $_name = [
        'outId'        => 'outId',
        'targetUserId' => 'targetUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outId) {
            $res['outId'] = $this->outId;
        }
        if (null !== $this->targetUserId) {
            $res['targetUserId'] = $this->targetUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return targetUserList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outId'])) {
            $model->outId = $map['outId'];
        }
        if (isset($map['targetUserId'])) {
            $model->targetUserId = $map['targetUserId'];
        }

        return $model;
    }
}
