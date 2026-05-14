<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupResponseBody extends Model
{
    /**
     * @description 群会话Id
     *
     * @var string
     */
    public $chatid;

    /**
     * @description 会话类型标记
     *
     * @var int
     */
    public $conversationTag;

    /**
     * @description 开放群会话Id
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'chatid' => 'chatid',
        'conversationTag' => 'conversationTag',
        'openConversationId' => 'openConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatid) {
            $res['chatid'] = $this->chatid;
        }
        if (null !== $this->conversationTag) {
            $res['conversationTag'] = $this->conversationTag;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatid'])) {
            $model->chatid = $map['chatid'];
        }
        if (isset($map['conversationTag'])) {
            $model->conversationTag = $map['conversationTag'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
