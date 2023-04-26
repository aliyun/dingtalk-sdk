<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceResponseBody\result\controllers;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var controllers[]
     */
    public $controllers;

    /**
     * @example "ding994a046bca84545935c2f4657eb6378f"
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 1234
     *
     * @var string
     */
    public $deviceId;

    /**
     * @example "14:85:7f:e5:f3:f3"
     *
     * @var string
     */
    public $deviceMac;

    /**
     * @example winbox
     *
     * @var string
     */
    public $deviceModel;

    /**
     * @example 钉钉会议设备_xxxx
     *
     * @var string
     */
    public $deviceName;

    /**
     * @example 1204
     *
     * @var int
     */
    public $deviceServiceId;

    /**
     * @example "02caa8169c80f74a2d375093a6107016"
     *
     * @var string
     */
    public $deviceSn;

    /**
     * @example 空闲：idle  投屏中：projection   会议响铃中：conf_incoming   会议中：conf_running   使用白板中：white_board   离线: offline
     *
     * @var string
     */
    public $deviceStatus;

    /**
     * @example 视频会议设备:"touyingyi"   设备控制器:"meetingaccessory"
     *
     * @var string
     */
    public $deviceType;

    /**
     * @example "lmvUrRkpboRrSMtgsiS9V3AiEiE"
     *
     * @var string
     */
    public $deviceUnionId;

    /**
     * @example "7263defed6b361fedf0fe6a3b578b96e808b09d6ca6282ed"
     *
     * @var string
     */
    public $openRoomId;

    /**
     * @example 123456
     *
     * @var string
     */
    public $shareCode;
    protected $_name = [
        'controllers'     => 'controllers',
        'corpId'          => 'corpId',
        'deviceId'        => 'deviceId',
        'deviceMac'       => 'deviceMac',
        'deviceModel'     => 'deviceModel',
        'deviceName'      => 'deviceName',
        'deviceServiceId' => 'deviceServiceId',
        'deviceSn'        => 'deviceSn',
        'deviceStatus'    => 'deviceStatus',
        'deviceType'      => 'deviceType',
        'deviceUnionId'   => 'deviceUnionId',
        'openRoomId'      => 'openRoomId',
        'shareCode'       => 'shareCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->controllers) {
            $res['controllers'] = [];
            if (null !== $this->controllers && \is_array($this->controllers)) {
                $n = 0;
                foreach ($this->controllers as $item) {
                    $res['controllers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->deviceMac) {
            $res['deviceMac'] = $this->deviceMac;
        }
        if (null !== $this->deviceModel) {
            $res['deviceModel'] = $this->deviceModel;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->deviceServiceId) {
            $res['deviceServiceId'] = $this->deviceServiceId;
        }
        if (null !== $this->deviceSn) {
            $res['deviceSn'] = $this->deviceSn;
        }
        if (null !== $this->deviceStatus) {
            $res['deviceStatus'] = $this->deviceStatus;
        }
        if (null !== $this->deviceType) {
            $res['deviceType'] = $this->deviceType;
        }
        if (null !== $this->deviceUnionId) {
            $res['deviceUnionId'] = $this->deviceUnionId;
        }
        if (null !== $this->openRoomId) {
            $res['openRoomId'] = $this->openRoomId;
        }
        if (null !== $this->shareCode) {
            $res['shareCode'] = $this->shareCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['controllers'])) {
            if (!empty($map['controllers'])) {
                $model->controllers = [];
                $n                  = 0;
                foreach ($map['controllers'] as $item) {
                    $model->controllers[$n++] = null !== $item ? controllers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['deviceMac'])) {
            $model->deviceMac = $map['deviceMac'];
        }
        if (isset($map['deviceModel'])) {
            $model->deviceModel = $map['deviceModel'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['deviceServiceId'])) {
            $model->deviceServiceId = $map['deviceServiceId'];
        }
        if (isset($map['deviceSn'])) {
            $model->deviceSn = $map['deviceSn'];
        }
        if (isset($map['deviceStatus'])) {
            $model->deviceStatus = $map['deviceStatus'];
        }
        if (isset($map['deviceType'])) {
            $model->deviceType = $map['deviceType'];
        }
        if (isset($map['deviceUnionId'])) {
            $model->deviceUnionId = $map['deviceUnionId'];
        }
        if (isset($map['openRoomId'])) {
            $model->openRoomId = $map['openRoomId'];
        }
        if (isset($map['shareCode'])) {
            $model->shareCode = $map['shareCode'];
        }

        return $model;
    }
}
