<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineResponseBody\result;

use AlibabaCloud\Tea\Model;

class machineBluetoothVO extends Model
{
    /**
     * @description 地址位置描述
     *
     * @var string
     */
    public $address;

    /**
     * @description 蓝牙打卡人脸识别开关值
     *
     * @var bool
     */
    public $bluetoothCheckWithFace;

    /**
     * @description 蓝牙打卡范围
     *
     * @var string
     */
    public $bluetoothDistanceMode;

    /**
     * @description 蓝牙打卡范围描述
     *
     * @var string
     */
    public $bluetoothDistanceModeDesc;

    /**
     * @description 蓝牙打卡开关
     *
     * @var bool
     */
    public $bluetoothValue;

    /**
     * @description 纬度
     *
     * @var float
     */
    public $latitude;

    /**
     * @description 是否限制员工常用手机
     *
     * @var bool
     */
    public $limitUserDeviceCount;

    /**
     * @description 经度
     *
     * @var float
     */
    public $longitude;

    /**
     * @description 是否打开位置异常监控
     *
     * @var bool
     */
    public $monitorLocationAbnormal;

    /**
     * @description 员工常用手机数量
     *
     * @var int
     */
    public $userDeviceCount;
    protected $_name = [
        'address'                   => 'address',
        'bluetoothCheckWithFace'    => 'bluetoothCheckWithFace',
        'bluetoothDistanceMode'     => 'bluetoothDistanceMode',
        'bluetoothDistanceModeDesc' => 'bluetoothDistanceModeDesc',
        'bluetoothValue'            => 'bluetoothValue',
        'latitude'                  => 'latitude',
        'limitUserDeviceCount'      => 'limitUserDeviceCount',
        'longitude'                 => 'longitude',
        'monitorLocationAbnormal'   => 'monitorLocationAbnormal',
        'userDeviceCount'           => 'userDeviceCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->bluetoothCheckWithFace) {
            $res['bluetoothCheckWithFace'] = $this->bluetoothCheckWithFace;
        }
        if (null !== $this->bluetoothDistanceMode) {
            $res['bluetoothDistanceMode'] = $this->bluetoothDistanceMode;
        }
        if (null !== $this->bluetoothDistanceModeDesc) {
            $res['bluetoothDistanceModeDesc'] = $this->bluetoothDistanceModeDesc;
        }
        if (null !== $this->bluetoothValue) {
            $res['bluetoothValue'] = $this->bluetoothValue;
        }
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }
        if (null !== $this->limitUserDeviceCount) {
            $res['limitUserDeviceCount'] = $this->limitUserDeviceCount;
        }
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
        }
        if (null !== $this->monitorLocationAbnormal) {
            $res['monitorLocationAbnormal'] = $this->monitorLocationAbnormal;
        }
        if (null !== $this->userDeviceCount) {
            $res['userDeviceCount'] = $this->userDeviceCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return machineBluetoothVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['bluetoothCheckWithFace'])) {
            $model->bluetoothCheckWithFace = $map['bluetoothCheckWithFace'];
        }
        if (isset($map['bluetoothDistanceMode'])) {
            $model->bluetoothDistanceMode = $map['bluetoothDistanceMode'];
        }
        if (isset($map['bluetoothDistanceModeDesc'])) {
            $model->bluetoothDistanceModeDesc = $map['bluetoothDistanceModeDesc'];
        }
        if (isset($map['bluetoothValue'])) {
            $model->bluetoothValue = $map['bluetoothValue'];
        }
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }
        if (isset($map['limitUserDeviceCount'])) {
            $model->limitUserDeviceCount = $map['limitUserDeviceCount'];
        }
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }
        if (isset($map['monitorLocationAbnormal'])) {
            $model->monitorLocationAbnormal = $map['monitorLocationAbnormal'];
        }
        if (isset($map['userDeviceCount'])) {
            $model->userDeviceCount = $map['userDeviceCount'];
        }

        return $model;
    }
}
