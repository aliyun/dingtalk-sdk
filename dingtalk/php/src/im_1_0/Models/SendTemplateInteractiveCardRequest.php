<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendTemplateInteractiveCardRequest\sendOptions;
use AlibabaCloud\Tea\Model;

class SendTemplateInteractiveCardRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 卡片内容模板ID，响应模板目前有：TuWenCard01、TuWenCard02、TuWenCard03、TuWenCard04 4种
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description 接收卡片的加密群ID
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
     *
     * @var string
     */
    public $outTrackId;

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
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'cardTemplateId'     => 'cardTemplateId',
        'openConversationId' => 'openConversationId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'outTrackId'         => 'outTrackId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'robotCode'          => 'robotCode',
        'dingOrgId'          => 'dingOrgId',
        'callbackUrl'        => 'callbackUrl',
        'cardData'           => 'cardData',
        'dingOauthAppId'     => 'dingOauthAppId',
        'sendOptions'        => 'sendOptions',
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
        if (null !== $this->callbackUrl) {
            $res['callbackUrl'] = $this->callbackUrl;
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
     * @return SendTemplateInteractiveCardRequest
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
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
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
