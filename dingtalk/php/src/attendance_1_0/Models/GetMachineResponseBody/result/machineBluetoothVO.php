<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineResponseBody\result;

use AlibabaCloud\Tea\Model;

class machineBluetoothVO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 绿城-未来park
     *
     * @var string
     */
    public $address;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $bluetoothCheckWithFace;

    /**
     * @description This parameter is required.
     *
     * @example default
     *
     * @var string
     */
    public $bluetoothDistanceMode;

    /**
     * @description This parameter is required.
     *
     * @example 默认 (最远5-10米)
     *
     * @var string
     */
    public $bluetoothDistanceModeDesc;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $bluetoothValue;

    /**
     * @description This parameter is required.
     *
     * @example 30.285871310763888
     *
     * @var float
     */
    public $latitude;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $limitUserDeviceCount;

    /**
     * @description This parameter is required.
     *
     * @example 120.01757758246528
     *
     * @var float
     */
    public $longitude;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $monitorLocationAbnormal;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $userDeviceCount;
    protected $_name = [
        'address' => 'address',
        'bluetoothCheckWithFace' => 'bluetoothCheckWithFace',
        'bluetoothDistanceMode' => 'bluetoothDistanceMode',
        'bluetoothDistanceModeDesc' => 'bluetoothDistanceModeDesc',
        'bluetoothValue' => 'bluetoothValue',
        'latitude' => 'latitude',
        'limitUserDeviceCount' => 'limitUserDeviceCount',
        'longitude' => 'longitude',
        'monitorLocationAbnormal' => 'monitorLocationAbnormal',
        'userDeviceCount' => 'userDeviceCount',
    ];

    public function validate() {}

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
