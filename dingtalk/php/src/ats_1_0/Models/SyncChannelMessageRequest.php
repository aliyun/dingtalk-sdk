<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncChannelMessageRequest extends Model
{
    /**
     * @var string
     */
    public $bizCode;

    /**
     * @description 渠道标识。
     *
     * @var string
     */
    public $channel;

    /**
     * @description 消息内容。
     *
     * @var string
     */
    public $content;

    /**
     * @description 消息创建时间。
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 消息接收者ID。
     *
     * @var string
     */
    public $receiverUserId;

    /**
     * @description 消息发送者用户ID。
     *
     * @var string
     */
    public $senderUserId;

    /**
     * @description 消息UUID，业务方产生用于去重。
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'bizCode'        => 'bizCode',
        'channel'        => 'channel',
        'content'        => 'content',
        'createTime'     => 'createTime',
        'receiverUserId' => 'receiverUserId',
        'senderUserId'   => 'senderUserId',
        'uuid'           => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->receiverUserId) {
            $res['receiverUserId'] = $this->receiverUserId;
        }
        if (null !== $this->senderUserId) {
            $res['senderUserId'] = $this->senderUserId;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncChannelMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['receiverUserId'])) {
            $model->receiverUserId = $map['receiverUserId'];
        }
        if (isset($map['senderUserId'])) {
            $model->senderUserId = $map['senderUserId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
