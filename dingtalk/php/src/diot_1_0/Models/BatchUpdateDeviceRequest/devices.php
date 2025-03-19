<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchUpdateDeviceRequest;

use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchUpdateDeviceRequest\devices\liveUrls;
use AlibabaCloud\Tea\Model;

class devices extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 002
     *
     * @var string
     */
    public $deviceId;

    /**
     * @example 摄像头002
     *
     * @var string
     */
    public $deviceName;

    /**
     * @example 0
     *
     * @var int
     */
    public $deviceStatus;

    /**
     * @var mixed[]
     */
    public $extraData;

    /**
     * @var liveUrls
     */
    public $liveUrls;

    /**
     * @example 社区南门
     *
     * @var string
     */
    public $location;
    protected $_name = [
        'deviceId' => 'deviceId',
        'deviceName' => 'deviceName',
        'deviceStatus' => 'deviceStatus',
        'extraData' => 'extraData',
        'liveUrls' => 'liveUrls',
        'location' => 'location',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->deviceStatus) {
            $res['deviceStatus'] = $this->deviceStatus;
        }
        if (null !== $this->extraData) {
            $res['extraData'] = $this->extraData;
        }
        if (null !== $this->liveUrls) {
            $res['liveUrls'] = null !== $this->liveUrls ? $this->liveUrls->toMap() : null;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return devices
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['deviceStatus'])) {
            $model->deviceStatus = $map['deviceStatus'];
        }
        if (isset($map['extraData'])) {
            $model->extraData = $map['extraData'];
        }
        if (isset($map['liveUrls'])) {
            $model->liveUrls = liveUrls::fromMap($map['liveUrls']);
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }

        return $model;
    }
}
