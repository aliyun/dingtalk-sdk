<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardRequest\sendOptions;
use AlibabaCloud\Tea\Model;

class SendRobotInteractiveCardRequest extends Model
{
    /**
     * @description 可交互卡片回调的url【可空：不填写无需回调】
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @description 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @description 卡片模板-文本内容参数（卡片json结构体）
     *
     * @var string
     */
    public $cardData;

    /**
     * @description 卡片搭建平台模板ID
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description 【openConversationId & singleChatReceiver 二选一必填】接收卡片的加密群ID，特指多人群会话（非单聊）
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 是否开启卡片纯拉模式
     *
     * @var bool
     */
    public $pullStrategy;

    /**
     * @description 机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 互动卡片发送选项
     *
     * @var sendOptions
     */
    public $sendOptions;

    /**
     * @description 【openConversationId & singleChatReceiver 二选一必填】单聊会话接受者json串
     *
     * @var string
     */
    public $singleChatReceiver;

    /**
     * @description 卡片模板-userId差异用户参数（json结构体）
     *
     * @var string
     */
    public $unionIdPrivateDataMap;

    /**
     * @description 卡片模板-userId差异用户参数（json结构体）
     *
     * @var string
     */
    public $userIdPrivateDataMap;
    protected $_name = [
        'callbackUrl'           => 'callbackUrl',
        'cardBizId'             => 'cardBizId',
        'cardData'              => 'cardData',
        'cardTemplateId'        => 'cardTemplateId',
        'openConversationId'    => 'openConversationId',
        'pullStrategy'          => 'pullStrategy',
        'robotCode'             => 'robotCode',
        'sendOptions'           => 'sendOptions',
        'singleChatReceiver'    => 'singleChatReceiver',
        'unionIdPrivateDataMap' => 'unionIdPrivateDataMap',
        'userIdPrivateDataMap'  => 'userIdPrivateDataMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callbackUrl) {
            $res['callbackUrl'] = $this->callbackUrl;
        }
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = $this->cardData;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->pullStrategy) {
            $res['pullStrategy'] = $this->pullStrategy;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->sendOptions) {
            $res['sendOptions'] = null !== $this->sendOptions ? $this->sendOptions->toMap() : null;
        }
        if (null !== $this->singleChatReceiver) {
            $res['singleChatReceiver'] = $this->singleChatReceiver;
        }
        if (null !== $this->unionIdPrivateDataMap) {
            $res['unionIdPrivateDataMap'] = $this->unionIdPrivateDataMap;
        }
        if (null !== $this->userIdPrivateDataMap) {
            $res['userIdPrivateDataMap'] = $this->userIdPrivateDataMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendRobotInteractiveCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
        }
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = $map['cardData'];
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['pullStrategy'])) {
            $model->pullStrategy = $map['pullStrategy'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['sendOptions'])) {
            $model->sendOptions = sendOptions::fromMap($map['sendOptions']);
        }
        if (isset($map['singleChatReceiver'])) {
            $model->singleChatReceiver = $map['singleChatReceiver'];
        }
        if (isset($map['unionIdPrivateDataMap'])) {
            $model->unionIdPrivateDataMap = $map['unionIdPrivateDataMap'];
        }
        if (isset($map['userIdPrivateDataMap'])) {
            $model->userIdPrivateDataMap = $map['userIdPrivateDataMap'];
        }

        return $model;
    }
}
