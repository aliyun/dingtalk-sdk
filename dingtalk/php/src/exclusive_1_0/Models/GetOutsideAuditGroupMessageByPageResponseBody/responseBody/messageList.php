<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutsideAuditGroupMessageByPageResponseBody\responseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOutsideAuditGroupMessageByPageResponseBody\responseBody\messageList\sender;
use AlibabaCloud\Tea\Model;

class messageList extends Model
{
    /**
     * @example {   "text": {     "content": "这是一段文本"   } }
     *
     * @var string
     */
    public $content;

    /**
     * @example text/audio/video
     *
     * @var string
     */
    public $contentType;

    /**
     * @example 2022-07-05 15:43:03
     *
     * @var string
     */
    public $createAt;

    /**
     * @example cid123456
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var sender
     */
    public $sender;
    protected $_name = [
        'content' => 'content',
        'contentType' => 'contentType',
        'createAt' => 'createAt',
        'openConversationId' => 'openConversationId',
        'sender' => 'sender',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->createAt) {
            $res['createAt'] = $this->createAt;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->sender) {
            $res['sender'] = null !== $this->sender ? $this->sender->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return messageList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['createAt'])) {
            $model->createAt = $map['createAt'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['sender'])) {
            $model->sender = sender::fromMap($map['sender']);
        }

        return $model;
    }
}
