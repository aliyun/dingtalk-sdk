<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\InteractiveCardCreateInstanceRequest\cardData;
use AlibabaCloud\Tea\Model;

class InteractiveCardCreateInstanceRequest extends Model
{
    /**
     * @description 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
     *
     * @var string
     */
    public $callbackRouteKey;

    /**
     * @var cardData
     */
    public $cardData;

    /**
     * @description 卡片模板ID
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description 【robotCode & chatBotId二选一必填】机器人ID（企业机器人）
     *
     * @var string
     */
    public $chatBotId;

    /**
     * @description 发送的会话类型：单聊-0, 群聊-1（单聊时：openConversationId不用填写；receiverUserIdList填写有且一个员工号）
     *
     * @var int
     */
    public $conversationType;

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
     * @description 指定用户可见的按钮列表（key：用户userId；value：用户数据）
     *
     * @var PrivateDataValue[]
     */
    public $privateData;

    /**
     * @description 是否开启卡片纯拉模式
     *
     * @var bool
     */
    public $pullStrategy;

    /**
     * @description 接收人userId列表
     *
     * @var string[]
     */
    public $receiverUserIdList;

    /**
     * @description 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 用户ID类型：1：staffId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
     *
     * @var int
     */
    public $userIdType;
    protected $_name = [
        'callbackRouteKey'   => 'callbackRouteKey',
        'cardData'           => 'cardData',
        'cardTemplateId'     => 'cardTemplateId',
        'chatBotId'          => 'chatBotId',
        'conversationType'   => 'conversationType',
        'openConversationId' => 'openConversationId',
        'outTrackId'         => 'outTrackId',
        'privateData'        => 'privateData',
        'pullStrategy'       => 'pullStrategy',
        'receiverUserIdList' => 'receiverUserIdList',
        'robotCode'          => 'robotCode',
        'userIdType'         => 'userIdType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callbackRouteKey) {
            $res['callbackRouteKey'] = $this->callbackRouteKey;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = null !== $this->cardData ? $this->cardData->toMap() : null;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->chatBotId) {
            $res['chatBotId'] = $this->chatBotId;
        }
        if (null !== $this->conversationType) {
            $res['conversationType'] = $this->conversationType;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->privateData) {
            $res['privateData'] = [];
            if (null !== $this->privateData && \is_array($this->privateData)) {
                foreach ($this->privateData as $key => $val) {
                    $res['privateData'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->pullStrategy) {
            $res['pullStrategy'] = $this->pullStrategy;
        }
        if (null !== $this->receiverUserIdList) {
            $res['receiverUserIdList'] = $this->receiverUserIdList;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->userIdType) {
            $res['userIdType'] = $this->userIdType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InteractiveCardCreateInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callbackRouteKey'])) {
            $model->callbackRouteKey = $map['callbackRouteKey'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = cardData::fromMap($map['cardData']);
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['chatBotId'])) {
            $model->chatBotId = $map['chatBotId'];
        }
        if (isset($map['conversationType'])) {
            $model->conversationType = $map['conversationType'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['privateData'])) {
            $model->privateData = $map['privateData'];
        }
        if (isset($map['pullStrategy'])) {
            $model->pullStrategy = $map['pullStrategy'];
        }
        if (isset($map['receiverUserIdList'])) {
            if (!empty($map['receiverUserIdList'])) {
                $model->receiverUserIdList = $map['receiverUserIdList'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['userIdType'])) {
            $model->userIdType = $map['userIdType'];
        }

        return $model;
    }
}
