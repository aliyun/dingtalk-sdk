<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardRequest\sendOptions;
use AlibabaCloud\Tea\Model;

class SendTemplateInteractiveCardRequest extends Model
{
    /**
     * @example https://xxxx.com/.../
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @example 根据具体的cardTemplateId参考文档格式
     *
     * @var string
     */
    public $cardData;

    /**
     * @example TuWenCard01
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
     * @example cardXXXX01
     *
     * @var string
     */
    public $outTrackId;

    /**
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
    protected $_name = [
        'callbackUrl'        => 'callbackUrl',
        'cardData'           => 'cardData',
        'cardTemplateId'     => 'cardTemplateId',
        'openConversationId' => 'openConversationId',
        'outTrackId'         => 'outTrackId',
        'robotCode'          => 'robotCode',
        'sendOptions'        => 'sendOptions',
        'singleChatReceiver' => 'singleChatReceiver',
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
        if (null !== $this->cardData) {
            $res['cardData'] = $this->cardData;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendTemplateInteractiveCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
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
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
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

        return $model;
    }
}
