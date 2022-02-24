<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendInteractiveCardRequest\cardData;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendInteractiveCardRequest\cardOptions;
use AlibabaCloud\Tea\Model;

class SendInteractiveCardRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 卡片模板ID
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description 接收卡片的群的openConversationId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 互动卡片消息需要群会话部分人可见时的接收人列表，不填写默认群会话所有人可见
     *
     * @var string[]
     */
    public $receiverUserIdList;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @description 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
     *
     * @var string
     */
    public $robotCode;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @description 发送的会话类型：单聊-0, 群聊-1（单聊时：openConversationId不用填写；receiverUserIdList填写有且一个员工号）
     *
     * @var int
     */
    public $conversationType;

    /**
     * @description 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
     *
     * @var string
     */
    public $callbackRouteKey;

    /**
     * @description 卡片公共主体部分数据
     *
     * @var cardData
     */
    public $cardData;

    /**
     * @description 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
     *
     * @var PrivateDataValue[]
     */
    public $privateData;

    /**
     * @var int
     */
    public $dingOauthAppId;

    /**
     * @description 【robotCode & chatBotId二选一必填】机器人ID（企业机器人）
     *
     * @var string
     */
    public $chatBotId;

    /**
     * @description 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
     *
     * @var int
     */
    public $userIdType;

    /**
     * @description 消息@人，{123456:"钉三多"}，key：根据userIdType来设置，【特殊设置：如果key、value都为"@ALL"则判断at所有人】
     *
     * @var string[]
     */
    public $atOpenIds;

    /**
     * @description 卡片属性
     *
     * @var cardOptions
     */
    public $cardOptions;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'cardTemplateId'     => 'cardTemplateId',
        'openConversationId' => 'openConversationId',
        'receiverUserIdList' => 'receiverUserIdList',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'outTrackId'         => 'outTrackId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'robotCode'          => 'robotCode',
        'dingOrgId'          => 'dingOrgId',
        'conversationType'   => 'conversationType',
        'callbackRouteKey'   => 'callbackRouteKey',
        'cardData'           => 'cardData',
        'privateData'        => 'privateData',
        'dingOauthAppId'     => 'dingOauthAppId',
        'chatBotId'          => 'chatBotId',
        'userIdType'         => 'userIdType',
        'atOpenIds'          => 'atOpenIds',
        'cardOptions'        => 'cardOptions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->receiverUserIdList) {
            $res['receiverUserIdList'] = $this->receiverUserIdList;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
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
        if (null !== $this->conversationType) {
            $res['conversationType'] = $this->conversationType;
        }
        if (null !== $this->callbackRouteKey) {
            $res['callbackRouteKey'] = $this->callbackRouteKey;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = null !== $this->cardData ? $this->cardData->toMap() : null;
        }
        if (null !== $this->privateData) {
            $res['privateData'] = [];
            if (null !== $this->privateData && \is_array($this->privateData)) {
                foreach ($this->privateData as $key => $val) {
                    $res['privateData'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }
        if (null !== $this->chatBotId) {
            $res['chatBotId'] = $this->chatBotId;
        }
        if (null !== $this->userIdType) {
            $res['userIdType'] = $this->userIdType;
        }
        if (null !== $this->atOpenIds) {
            $res['atOpenIds'] = $this->atOpenIds;
        }
        if (null !== $this->cardOptions) {
            $res['cardOptions'] = null !== $this->cardOptions ? $this->cardOptions->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendInteractiveCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['receiverUserIdList'])) {
            if (!empty($map['receiverUserIdList'])) {
                $model->receiverUserIdList = $map['receiverUserIdList'];
            }
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
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
        if (isset($map['conversationType'])) {
            $model->conversationType = $map['conversationType'];
        }
        if (isset($map['callbackRouteKey'])) {
            $model->callbackRouteKey = $map['callbackRouteKey'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = cardData::fromMap($map['cardData']);
        }
        if (isset($map['privateData'])) {
            $model->privateData = $map['privateData'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }
        if (isset($map['chatBotId'])) {
            $model->chatBotId = $map['chatBotId'];
        }
        if (isset($map['userIdType'])) {
            $model->userIdType = $map['userIdType'];
        }
        if (isset($map['atOpenIds'])) {
            $model->atOpenIds = $map['atOpenIds'];
        }
        if (isset($map['cardOptions'])) {
            $model->cardOptions = cardOptions::fromMap($map['cardOptions']);
        }

        return $model;
    }
}
