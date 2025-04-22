<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddTraceEventRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $actionKey;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $actionTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizCode;

    /**
     * @var string
     */
    public $bizReq;

    /**
     * @var string
     */
    public $bizResp;

    /**
     * @var string
     */
    public $deviceId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $eventId;

    /**
     * @var string
     */
    public $eventType;

    /**
     * @var string
     */
    public $eventUnit;

    /**
     * @var string
     */
    public $eventValue;

    /**
     * @var string
     */
    public $extend;

    /**
     * @var string
     */
    public $platform;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'actionKey' => 'actionKey',
        'actionTime' => 'actionTime',
        'bizCode' => 'bizCode',
        'bizReq' => 'bizReq',
        'bizResp' => 'bizResp',
        'deviceId' => 'deviceId',
        'eventId' => 'eventId',
        'eventType' => 'eventType',
        'eventUnit' => 'eventUnit',
        'eventValue' => 'eventValue',
        'extend' => 'extend',
        'platform' => 'platform',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionKey) {
            $res['actionKey'] = $this->actionKey;
        }
        if (null !== $this->actionTime) {
            $res['actionTime'] = $this->actionTime;
        }
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->bizReq) {
            $res['bizReq'] = $this->bizReq;
        }
        if (null !== $this->bizResp) {
            $res['bizResp'] = $this->bizResp;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->eventUnit) {
            $res['eventUnit'] = $this->eventUnit;
        }
        if (null !== $this->eventValue) {
            $res['eventValue'] = $this->eventValue;
        }
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddTraceEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionKey'])) {
            $model->actionKey = $map['actionKey'];
        }
        if (isset($map['actionTime'])) {
            $model->actionTime = $map['actionTime'];
        }
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['bizReq'])) {
            $model->bizReq = $map['bizReq'];
        }
        if (isset($map['bizResp'])) {
            $model->bizResp = $map['bizResp'];
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['eventUnit'])) {
            $model->eventUnit = $map['eventUnit'];
        }
        if (isset($map['eventValue'])) {
            $model->eventValue = $map['eventValue'];
        }
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
