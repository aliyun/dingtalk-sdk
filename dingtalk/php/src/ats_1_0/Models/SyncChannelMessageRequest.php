<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncChannelMessageRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @example Corp-ABC-prd
     *
     * @var string
     */
    public $channel;

    /**
     * @example {"msgtype":"text","text":{"content":"月会通知"}}
     *
     * @var string
     */
    public $content;

    /**
     * @example 1667964772048
     *
     * @var int
     */
    public $createTime;

    /**
     * @example AppUid@Channel
     *
     * @var string
     */
    public $receiverUserId;

    /**
     * @example AppUid@Channel
     *
     * @var string
     */
    public $senderUserId;

    /**
     * @example 594c5b30-57bd-4001-8903-4dc64cdc6739
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
