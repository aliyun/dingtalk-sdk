<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendRobotMessageRequest extends Model
{
    /**
     * @description 是否@全员
     *
     * @var bool
     */
    public $atAll;

    /**
     * @description @人的appuid列表
     *
     * @var string[]
     */
    public $atAppUids;

    /**
     * @description @人的手机号列表
     *
     * @var string[]
     */
    public $atMobiles;

    /**
     * @description @人的unionid列表
     *
     * @var string[]
     */
    public $atUnionIds;

    /**
     * @description @人的userid列表
     *
     * @var string[]
     */
    public $atUsers;

    /**
     * @description 租户channel
     *
     * @var string
     */
    public $channel;

    /**
     * @description 消息模板内容替换参数，多媒体类型
     *
     * @var mixed[]
     */
    public $msgMediaIdParamMap;

    /**
     * @description 消息模板内容替换参数，普通文本类型
     *
     * @var mixed[]
     */
    public $msgParamMap;

    /**
     * @description 消息模板id
     *
     * @var string
     */
    public $msgTemplateId;

    /**
     * @description 消息接收人appuid列表
     *
     * @var string[]
     */
    public $receiverAppUids;

    /**
     * @description 消息接收人手机号列表
     *
     * @var string[]
     */
    public $receiverMobiles;

    /**
     * @description 消息接收人unionId列表
     *
     * @var string[]
     */
    public $receiverUnionIds;

    /**
     * @description 消息接收人userId列表
     *
     * @var string[]
     */
    public $receiverUserIds;

    /**
     * @description 用于发送卡片的机器人编码，与场景群模板中的机器人编码保持一致
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 会话id
     *
     * @var string
     */
    public $targetOpenConversationId;
    protected $_name = [
        'atAll'                    => 'atAll',
        'atAppUids'                => 'atAppUids',
        'atMobiles'                => 'atMobiles',
        'atUnionIds'               => 'atUnionIds',
        'atUsers'                  => 'atUsers',
        'channel'                  => 'channel',
        'msgMediaIdParamMap'       => 'msgMediaIdParamMap',
        'msgParamMap'              => 'msgParamMap',
        'msgTemplateId'            => 'msgTemplateId',
        'receiverAppUids'          => 'receiverAppUids',
        'receiverMobiles'          => 'receiverMobiles',
        'receiverUnionIds'         => 'receiverUnionIds',
        'receiverUserIds'          => 'receiverUserIds',
        'robotCode'                => 'robotCode',
        'targetOpenConversationId' => 'targetOpenConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atAll) {
            $res['atAll'] = $this->atAll;
        }
        if (null !== $this->atAppUids) {
            $res['atAppUids'] = $this->atAppUids;
        }
        if (null !== $this->atMobiles) {
            $res['atMobiles'] = $this->atMobiles;
        }
        if (null !== $this->atUnionIds) {
            $res['atUnionIds'] = $this->atUnionIds;
        }
        if (null !== $this->atUsers) {
            $res['atUsers'] = $this->atUsers;
        }
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->msgMediaIdParamMap) {
            $res['msgMediaIdParamMap'] = $this->msgMediaIdParamMap;
        }
        if (null !== $this->msgParamMap) {
            $res['msgParamMap'] = $this->msgParamMap;
        }
        if (null !== $this->msgTemplateId) {
            $res['msgTemplateId'] = $this->msgTemplateId;
        }
        if (null !== $this->receiverAppUids) {
            $res['receiverAppUids'] = $this->receiverAppUids;
        }
        if (null !== $this->receiverMobiles) {
            $res['receiverMobiles'] = $this->receiverMobiles;
        }
        if (null !== $this->receiverUnionIds) {
            $res['receiverUnionIds'] = $this->receiverUnionIds;
        }
        if (null !== $this->receiverUserIds) {
            $res['receiverUserIds'] = $this->receiverUserIds;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->targetOpenConversationId) {
            $res['targetOpenConversationId'] = $this->targetOpenConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendRobotMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atAll'])) {
            $model->atAll = $map['atAll'];
        }
        if (isset($map['atAppUids'])) {
            if (!empty($map['atAppUids'])) {
                $model->atAppUids = $map['atAppUids'];
            }
        }
        if (isset($map['atMobiles'])) {
            if (!empty($map['atMobiles'])) {
                $model->atMobiles = $map['atMobiles'];
            }
        }
        if (isset($map['atUnionIds'])) {
            if (!empty($map['atUnionIds'])) {
                $model->atUnionIds = $map['atUnionIds'];
            }
        }
        if (isset($map['atUsers'])) {
            if (!empty($map['atUsers'])) {
                $model->atUsers = $map['atUsers'];
            }
        }
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['msgMediaIdParamMap'])) {
            $model->msgMediaIdParamMap = $map['msgMediaIdParamMap'];
        }
        if (isset($map['msgParamMap'])) {
            $model->msgParamMap = $map['msgParamMap'];
        }
        if (isset($map['msgTemplateId'])) {
            $model->msgTemplateId = $map['msgTemplateId'];
        }
        if (isset($map['receiverAppUids'])) {
            if (!empty($map['receiverAppUids'])) {
                $model->receiverAppUids = $map['receiverAppUids'];
            }
        }
        if (isset($map['receiverMobiles'])) {
            if (!empty($map['receiverMobiles'])) {
                $model->receiverMobiles = $map['receiverMobiles'];
            }
        }
        if (isset($map['receiverUnionIds'])) {
            if (!empty($map['receiverUnionIds'])) {
                $model->receiverUnionIds = $map['receiverUnionIds'];
            }
        }
        if (isset($map['receiverUserIds'])) {
            if (!empty($map['receiverUserIds'])) {
                $model->receiverUserIds = $map['receiverUserIds'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['targetOpenConversationId'])) {
            $model->targetOpenConversationId = $map['targetOpenConversationId'];
        }

        return $model;
    }
}
