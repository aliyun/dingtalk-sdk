<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendInteractiveOTOMessageRequest;

use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @description 卡片回调的URL地址，不传此参数则无回调。
     * 回调URL暂不支持query参数。
     * @var string
     */
    public $callbackUrl;

    /**
     * @description 唯一标识一张卡片的ID，卡片幂等ID，可用于后续卡片更新。
     * > 该参数由开发者传入，确保唯一。
     * @var string
     */
    public $cardBizId;

    /**
     * @description 卡片模板内容参数，JsonObject结构型。
     * 卡片数据结构需要与卡片搭建平台上定义的参数结构一致。
     * @var string
     */
    public $cardData;

    /**
     * @description 卡片搭建平台模板ID，详情可查阅 [创建消息模板](https://open.dingtalk.com/document/group/create-message-template) 。
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description 消息接收人id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 卡片模板userId差异用户参数，json结构体。
     * 用户对应的数据结构需要与卡片搭建平台上定义的参数结构一致。
     *
     * @var string
     */
    public $userIdPrivateDataMap;
    protected $_name = [
        'callbackUrl'          => 'callbackUrl',
        'cardBizId'            => 'cardBizId',
        'cardData'             => 'cardData',
        'cardTemplateId'       => 'cardTemplateId',
        'userId'               => 'userId',
        'userIdPrivateDataMap' => 'userIdPrivateDataMap',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userIdPrivateDataMap) {
            $res['userIdPrivateDataMap'] = $this->userIdPrivateDataMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detail
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userIdPrivateDataMap'])) {
            $model->userIdPrivateDataMap = $map['userIdPrivateDataMap'];
        }

        return $model;
    }
}
