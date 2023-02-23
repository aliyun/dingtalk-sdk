<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySingleGroupResponseBody;

use AlibabaCloud\Tea\Model;

class openConversations extends Model
{
    /**
     * @description 钉外账号在业务系统内的唯一标识。
     *
     * @var string
     */
    public $appUserId;

    /**
     * @description 群会话Id。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 钉内账号userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUserId'          => 'appUserId',
        'openConversationId' => 'openConversationId',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openConversations
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
