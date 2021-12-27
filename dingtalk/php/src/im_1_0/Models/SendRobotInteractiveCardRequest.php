<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardRequest\sendOptions;
use AlibabaCloud\Tea\Model;

class SendRobotInteractiveCardRequest extends Model
{
    /**
     * @var string
     */
    public $requestId;

    /**
     * @var string
     */
    public $dingAccessTokenType;

    /**
     * @var string
     */
    public $dingClientId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingOpenAppId;

    /**
     * @var int
     */
    public $dingUid;

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
     * @description 【openConversationId & singleChatReceiver 二选一必填】单聊会话接受者json串
     *
     * @var string
     */
    public $singleChatReceiver;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @description 机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode
     *
     * @var string
     */
    public $robotCode;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @description 卡片模板-文本内容参数（卡片json结构体）
     *
     * @var string
     */
    public $cardData;

    /**
     * @var int
     */
    public $dingOauthAppId;

    /**
     * @description 互动卡片发送选项
     *
     * @var sendOptions
     */
    public $sendOptions;
    protected $_name = [
        'requestId'           => 'RequestId',
        'dingAccessTokenType' => 'dingAccessTokenType',
        'dingClientId'        => 'dingClientId',
        'dingIsvOrgId'        => 'dingIsvOrgId',
        'dingOpenAppId'       => 'dingOpenAppId',
        'dingUid'             => 'dingUid',
        'cardTemplateId'      => 'cardTemplateId',
        'openConversationId'  => 'openConversationId',
        'singleChatReceiver'  => 'singleChatReceiver',
        'dingTokenGrantType'  => 'dingTokenGrantType',
        'cardBizId'           => 'cardBizId',
        'dingSuiteKey'        => 'dingSuiteKey',
        'robotCode'           => 'robotCode',
        'dingOrgId'           => 'dingOrgId',
        'cardData'            => 'cardData',
        'dingOauthAppId'      => 'dingOauthAppId',
        'sendOptions'         => 'sendOptions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['RequestId'] = $this->requestId;
        }
        if (null !== $this->dingAccessTokenType) {
            $res['dingAccessTokenType'] = $this->dingAccessTokenType;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOpenAppId) {
            $res['dingOpenAppId'] = $this->dingOpenAppId;
        }
        if (null !== $this->dingUid) {
            $res['dingUid'] = $this->dingUid;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->singleChatReceiver) {
            $res['singleChatReceiver'] = $this->singleChatReceiver;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = $this->cardData;
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }
        if (null !== $this->sendOptions) {
            $res['sendOptions'] = null !== $this->sendOptions ? $this->sendOptions->toMap() : null;
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
        if (isset($map['RequestId'])) {
            $model->requestId = $map['RequestId'];
        }
        if (isset($map['dingAccessTokenType'])) {
            $model->dingAccessTokenType = $map['dingAccessTokenType'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOpenAppId'])) {
            $model->dingOpenAppId = $map['dingOpenAppId'];
        }
        if (isset($map['dingUid'])) {
            $model->dingUid = $map['dingUid'];
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['singleChatReceiver'])) {
            $model->singleChatReceiver = $map['singleChatReceiver'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = $map['cardData'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }
        if (isset($map['sendOptions'])) {
            $model->sendOptions = sendOptions::fromMap($map['sendOptions']);
        }

        return $model;
    }
}
