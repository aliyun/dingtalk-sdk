<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupBlackboardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 这是一条群公告
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example cid123456
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example false
     *
     * @var bool
     */
    public $sendDing;

    /**
     * @example false
     *
     * @var bool
     */
    public $sticky;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $uniqueId;

    /**
     * @description This parameter is required.
     *
     * @example 001
     *
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
     * @return CreateGroupBlackboardRequest
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
