<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageRequest extends Model
{
    /**
     * @description 消息的唯一id
     *
     * @var string
     */
    public $bizId;

    /**
     * @description 发送者
     *
     * @var string
     */
    public $fromUserId;

    /**
     * @description 设备sn
     *
     * @var string
     */
    public $sn;

    /**
     * @description 接收者
     *
     * @var string[]
     */
    public $toUserIdList;

    /**
     * @description 发送消息的类型
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'bizId'        => 'bizId',
        'fromUserId'   => 'fromUserId',
        'sn'           => 'sn',
        'toUserIdList' => 'toUserIdList',
        'type'         => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->fromUserId) {
            $res['fromUserId'] = $this->fromUserId;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->toUserIdList) {
            $res['toUserIdList'] = $this->toUserIdList;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['fromUserId'])) {
            $model->fromUserId = $map['fromUserId'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['toUserIdList'])) {
            if (!empty($map['toUserIdList'])) {
                $model->toUserIdList = $map['toUserIdList'];
            }
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
