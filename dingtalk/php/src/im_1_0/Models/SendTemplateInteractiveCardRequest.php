<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardRequest\sendOptions;
use AlibabaCloud\Tea\Model;

class SendTemplateInteractiveCardRequest extends Model
{
    /**
     * @description 可控制卡片回调的url【可空：不填写无需回调】
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @description 卡片模板-文本内容参数（卡片json结构体）
     *
     * @var string
     */
    public $cardData;

    /**
     * @description 卡片内容模板ID，响应模板目前有：TuWenCard01、TuWenCard02、TuWenCard03、TuWenCard04 4种
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
     * @description 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
     *
     * @var string
     */
    public $outTrackId;

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
