<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushEventRequest extends Model
{
    /**
     * @example ding123456
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 002
     *
     * @var string
     */
    public $deviceId;

    /**
     * @description This parameter is required.
     *
     * @example sj123456
     *
     * @var string
     */
    public $eventId;

    /**
     * @description This parameter is required.
     *
     * @example 火焰告警
     *
     * @var string
     */
    public $eventName;

    /**
     * @description This parameter is required.
     *
     * @example fireDetect
     *
     * @var string
     */
    public $eventType;

    /**
     * @var mixed[]
     */
    public $extraData;

    /**
     * @example 社区南门
     *
     * @var string
     */
    public $location;

    /**
     * @example 社区南门发生火焰告警
     *
     * @var string
     */
    public $msg;

    /**
     * @description This parameter is required.
     *
     * @example 1638250958570
     *
     * @var int
     */
    public $occurrenceTime;

    /**
     * @var string[]
     */
    public $picUrls;
    protected $_name = [
        'corpId' => 'corpId',
        'deviceId' => 'deviceId',
        'eventId' => 'eventId',
        'eventName' => 'eventName',
        'eventType' => 'eventType',
        'extraData' => 'extraData',
        'location' => 'location',
        'msg' => 'msg',
        'occurrenceTime' => 'occurrenceTime',
        'picUrls' => 'picUrls',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }
        if (null !== $this->eventName) {
            $res['eventName'] = $this->eventName;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->extraData) {
            $res['extraData'] = $this->extraData;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->msg) {
            $res['msg'] = $this->msg;
        }
        if (null !== $this->occurrenceTime) {
            $res['occurrenceTime'] = $this->occurrenceTime;
        }
        if (null !== $this->picUrls) {
            $res['picUrls'] = $this->picUrls;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }
        if (isset($map['eventName'])) {
            $model->eventName = $map['eventName'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['extraData'])) {
            $model->extraData = $map['extraData'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['msg'])) {
            $model->msg = $map['msg'];
        }
        if (isset($map['occurrenceTime'])) {
            $model->occurrenceTime = $map['occurrenceTime'];
        }
        if (isset($map['picUrls'])) {
            if (!empty($map['picUrls'])) {
                $model->picUrls = $map['picUrls'];
            }
        }

        return $model;
    }
}
