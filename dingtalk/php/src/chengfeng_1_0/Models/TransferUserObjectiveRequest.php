<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class TransferUserObjectiveRequest extends Model
{
    /**
     * @description 目标ID
     *
     * @var string
     */
    public $objectiveId;

    /**
     * @description 目标钉钉userId
     *
     * @var string
     */
    public $targetUserId;
    protected $_name = [
        'objectiveId'  => 'objectiveId',
        'targetUserId' => 'targetUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }
        if (null !== $this->targetUserId) {
            $res['targetUserId'] = $this->targetUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TransferUserObjectiveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }
        if (isset($map['targetUserId'])) {
            $model->targetUserId = $map['targetUserId'];
        }

        return $model;
    }
}
