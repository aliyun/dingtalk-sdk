<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchUpdateDeviceRequest;

use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchUpdateDeviceRequest\devices\liveUrls;
use AlibabaCloud\Tea\Model;

class devices extends Model
{
    /**
     * @description 设备ID。
     *
     * @var string
     */
    public $deviceId;

    /**
     * @description 设备名称。
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description 设备状态 0:在线 1:离线
     *
     * @var int
     */
    public $deviceStatus;

    /**
     * @description 第三方平台定制参数，企业内部系统忽略。
     *
     * @var mixed[]
     */
    public $extraData;

    /**
     * @description 视频流地址直播流地址，支持rtmp、flv、hls等格式，需要https协议。
     *
     * @var liveUrls
     */
    public $liveUrls;

    /**
     * @description 设备地址。
     *
     * @var string
     */
    public $location;
    protected $_name = [
        'deviceId'     => 'deviceId',
        'deviceName'   => 'deviceName',
        'deviceStatus' => 'deviceStatus',
        'extraData'    => 'extraData',
        'liveUrls'     => 'liveUrls',
        'location'     => 'location',
    ];

    public function validate()
    {
    }

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
