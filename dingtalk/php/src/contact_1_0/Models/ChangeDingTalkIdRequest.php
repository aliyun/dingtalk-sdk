<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChangeDingTalkIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example abc123
     *
     * @var string
     */
    public $dingTalkId;

    /**
     * @description This parameter is required.
     *
     * @example userIdBB
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dingTalkId' => 'dingTalkId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingTalkId) {
            $res['dingTalkId'] = $this->dingTalkId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChangeDingTalkIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingTalkId'])) {
            $model->dingTalkId = $map['dingTalkId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
