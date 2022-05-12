<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendCardRequest extends Model
{
    /**
     * @var string
     */
    public $bizId;

    /**
     * @var string
     */
    public $cardData;

    /**
     * @var string
     */
    public $deviceCode;

    /**
     * @var string
     */
    public $deviceUuid;

    /**
     * @var string
     */
    public $encodeCid;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizId'      => 'bizId',
        'cardData'   => 'cardData',
        'deviceCode' => 'deviceCode',
        'deviceUuid' => 'deviceUuid',
        'encodeCid'  => 'encodeCid',
        'templateId' => 'templateId',
        'userId'     => 'userId',
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
        if (null !== $this->encodeCid) {
            $res['encodeCid'] = $this->encodeCid;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
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
        if (isset($map['encodeCid'])) {
            $model->encodeCid = $map['encodeCid'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
