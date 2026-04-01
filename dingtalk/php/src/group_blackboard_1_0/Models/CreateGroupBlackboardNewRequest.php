<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupBlackboardNewRequest extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var bool
     */
    public $sendDing;

    /**
     * @var bool
     */
    public $sticky;

    /**
     * @var string
     */
    public $uniqueId;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'content' => 'content',
        'openConversationId' => 'openConversationId',
        'sendDing' => 'sendDing',
        'sticky' => 'sticky',
        'uniqueId' => 'uniqueId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->sendDing) {
            $res['sendDing'] = $this->sendDing;
        }
        if (null !== $this->sticky) {
            $res['sticky'] = $this->sticky;
        }
        if (null !== $this->uniqueId) {
            $res['uniqueId'] = $this->uniqueId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupBlackboardNewRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['sendDing'])) {
            $model->sendDing = $map['sendDing'];
        }
        if (isset($map['sticky'])) {
            $model->sticky = $map['sticky'];
        }
        if (isset($map['uniqueId'])) {
            $model->uniqueId = $map['uniqueId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
