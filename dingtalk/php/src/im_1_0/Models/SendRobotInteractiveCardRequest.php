<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendRobotInteractiveCardRequest\sendOptions;
use AlibabaCloud\Tea\Model;

class SendRobotInteractiveCardRequest extends Model
{
    /**
     * @example https://xxx
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @description This parameter is required.
     *
     * @example cardXXXX01
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @description This parameter is required.
     *
     * @example 根据具体的cardTemplateId参考文档格式
     *
     * @var string
     */
    public $cardData;

    /**
     * @description This parameter is required.
     *
     * @example xxxxxxxx
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @example cidXXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var bool
     */
    public $pullStrategy;

    /**
     * @description This parameter is required.
     *
     * @example xxxxxx
     *
     * @var string
     */
    public $robotCode;

    /**
     * @var sendOptions
     */
    public $sendOptions;

    /**
     * @example 以userId为例：{"userId":"userId0001"}；以unionId为例{"unionId":"unionId001"}
     *
     * @var string
     */
    public $singleChatReceiver;

    /**
     * @var string
     */
    public $unionIdPrivateDataMap;

    /**
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
