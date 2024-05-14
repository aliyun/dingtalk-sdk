<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendCardRequest extends Model
{
    /**
     * @example biz-xxxxx
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example {"var1":"xxx","var2":"xxx"}
     *
     * @var string
     */
    public $cardData;

    /**
     * @example xxxxceshi_1
     *
     * @var string
     */
    public $deviceCode;

    /**
     * @example Device-3bb10262-31f9-494f-9fde-0a910b8exxxx
     *
     * @var string
     */
    public $deviceUuid;

    /**
     * @example cide+m5TmAcxA3OU6Un59xxxx==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var bool
     */
    public $partVisible;

    /**
     * @var string[]
     */
    public $receivers;

    /**
     * @description This parameter is required.
     *
     * @example abcxxxxxxxx
     *
     * @var string
     */
    public $templateId;

    /**
     * @var bool
     */
    public $topbox;

    /**
     * @example 0123459456
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
