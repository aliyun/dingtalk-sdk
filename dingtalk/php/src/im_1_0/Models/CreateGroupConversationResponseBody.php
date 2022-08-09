<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupConversationResponseBody extends Model
{
    /**
     * @description 添加成功的钉外成员列表。
     *
     * @var string[]
     */
    public $appUserIds;

    /**
     * @description 钉钉群会话Id。
     *
     * @var string
     */
    public $conversationId;

    /**
     * @description 群会话Id。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 添加成功的钉内成员列表。
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'appUserIds'         => 'appUserIds',
        'conversationId'     => 'conversationId',
        'openConversationId' => 'openConversationId',
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
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupConversationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserIds'])) {
            if (!empty($map['appUserIds'])) {
                $model->appUserIds = $map['appUserIds'];
            }
        }
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
