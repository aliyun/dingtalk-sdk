<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendCardRequest extends Model
{
    /**
     * @description 卡片实例唯一标识
     *
     * @var string
     */
    public $bizId;

    /**
     * @description 卡片变量赋值，json结构
     *
     * @var string
     */
    public $cardData;

    /**
     * @description 设备业务标识
     *
     * @var string
     */
    public $deviceCode;

    /**
     * @description 设备uuid，唯一标识
     *
     * @var string
     */
    public $deviceUuid;

    /**
     * @description 群id，群的唯一标识
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 卡片是否群内部分人员可见
     *
     * @var bool
     */
    public $partVisible;

    /**
     * @description 群内指定人员可见
     *
     * @var string[]
     */
    public $receivers;

    /**
     * @description 卡片模板唯一标识，开放平台获取
     *
     * @var string
     */
    public $templateId;

    /**
     * @description 是否为吊顶卡片
     *
     * @var bool
     */
    public $topbox;

    /**
     * @description 用户通讯录唯一标识
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizId'              => 'bizId',
        'cardData'           => 'cardData',
        'deviceCode'         => 'deviceCode',
        'deviceUuid'         => 'deviceUuid',
        'openConversationId' => 'openConversationId',
        'partVisible'        => 'partVisible',
        'receivers'          => 'receivers',
        'templateId'         => 'templateId',
        'topbox'             => 'topbox',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = $this->cardData;
        }
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->deviceUuid) {
            $res['deviceUuid'] = $this->deviceUuid;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->partVisible) {
            $res['partVisible'] = $this->partVisible;
        }
        if (null !== $this->receivers) {
            $res['receivers'] = $this->receivers;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->topbox) {
            $res['topbox'] = $this->topbox;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = $map['cardData'];
        }
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['deviceUuid'])) {
            $model->deviceUuid = $map['deviceUuid'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['partVisible'])) {
            $model->partVisible = $map['partVisible'];
        }
        if (isset($map['receivers'])) {
            if (!empty($map['receivers'])) {
                $model->receivers = $map['receivers'];
            }
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['topbox'])) {
            $model->topbox = $map['topbox'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
