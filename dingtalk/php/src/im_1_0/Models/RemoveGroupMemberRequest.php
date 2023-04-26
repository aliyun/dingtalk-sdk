<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveGroupMemberRequest extends Model
{
    /**
     * @var string[]
     */
    public $appUserIds;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @example 1745****8777
     *
     * @var string
     */
    public $operatorId;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'appUserIds'         => 'appUserIds',
        'openConversationId' => 'openConversationId',
        'operatorId'         => 'operatorId',
        'userIds'            => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserIds) {
            $res['appUserIds'] = $this->appUserIds;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveGroupMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserIds'])) {
            if (!empty($map['appUserIds'])) {
                $model->appUserIds = $map['appUserIds'];
            }
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
