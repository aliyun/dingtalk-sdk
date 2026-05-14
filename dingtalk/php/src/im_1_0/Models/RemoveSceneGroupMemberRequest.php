<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveSceneGroupMemberRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cidxxxxxx==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string[]
     */
    public $unionIds;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'openConversationId' => 'open_conversation_id',
        'unionIds' => 'union_ids',
        'userIds' => 'user_ids',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['open_conversation_id'] = $this->openConversationId;
        }
        if (null !== $this->unionIds) {
            $res['union_ids'] = $this->unionIds;
        }
        if (null !== $this->userIds) {
            $res['user_ids'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveSceneGroupMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['open_conversation_id'])) {
            $model->openConversationId = $map['open_conversation_id'];
        }
        if (isset($map['union_ids'])) {
            if (!empty($map['union_ids'])) {
                $model->unionIds = $map['union_ids'];
            }
        }
        if (isset($map['user_ids'])) {
            if (!empty($map['user_ids'])) {
                $model->userIds = $map['user_ids'];
            }
        }

        return $model;
    }
}
