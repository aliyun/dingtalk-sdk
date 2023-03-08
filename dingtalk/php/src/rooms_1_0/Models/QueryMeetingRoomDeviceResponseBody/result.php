<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomDeviceResponseBody\result\controllers;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 设备控制器
     *
     * @var controllers[]
     */
    public $controllers;

    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 设备id
     *
     * @var string
     */
    public $deviceId;

    /**
     * @description 设备mac地址
     *
     * @var string
     */
    public $deviceMac;

    /**
     * @description 设备型号
     *
     * @var string
     */
    public $deviceModel;

    /**
     * @description 设备名称
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description 设备注册serviceId
     *
     * @var int
     */
    public $deviceServiceId;

    /**
     * @description 设备sn
     *
     * @var string
     */
    public $deviceSn;

    /**
     * @description 设备状态
     *
     * @var string
     */
    public $deviceStatus;

    /**
     * @description 设备类型
     *
     * @var string
     */
    public $deviceType;

    /**
     * @description 设备unionId
     *
     * @var string
     */
    public $deviceUnionId;

    /**
     * @description 设备绑定会议室id
     *
     * @var string
     */
    public $openRoomId;

    /**
     * @description 设备投屏码
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
