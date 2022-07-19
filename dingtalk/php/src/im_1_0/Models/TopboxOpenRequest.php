<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class TopboxOpenRequest extends Model
{
    /**
     * @description 发送的会话类型：单聊-0, 群聊-1
     *
     * @var int
     */
    public $conversationType;

    /**
     * @description 酷应用编码
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description 吊顶的过期时间（绝对时间）
     *
     * @var int
     */
    public $expiredTime;

    /**
     * @description 接收卡片的群的openConversationId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @description 期望吊顶的端（多个"|"隔开，如："ios|win|"）
     *
     * @var string
     */
    public $platforms;

    /**
     * @description 接收人的员工号列表
     *
     * @var string[]
     */
    public $receiverUserIdList;

    /**
     * @description 机器人编码
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'conversationType'   => 'conversationType',
        'coolAppCode'        => 'coolAppCode',
        'expiredTime'        => 'expiredTime',
        'openConversationId' => 'openConversationId',
        'outTrackId'         => 'outTrackId',
        'platforms'          => 'platforms',
        'receiverUserIdList' => 'receiverUserIdList',
        'robotCode'          => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationType) {
            $res['conversationType'] = $this->conversationType;
        }
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->expiredTime) {
            $res['expiredTime'] = $this->expiredTime;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->platforms) {
            $res['platforms'] = $this->platforms;
        }
        if (null !== $this->receiverUserIdList) {
            $res['receiverUserIdList'] = $this->receiverUserIdList;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TopboxOpenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationType'])) {
            $model->conversationType = $map['conversationType'];
        }
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['expiredTime'])) {
            $model->expiredTime = $map['expiredTime'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['platforms'])) {
            $model->platforms = $map['platforms'];
        }
        if (isset($map['receiverUserIdList'])) {
            if (!empty($map['receiverUserIdList'])) {
                $model->receiverUserIdList = $map['receiverUserIdList'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
