<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineResponseBody\result\machineBluetoothVO;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $atmManagerList;

    /**
     * @description This parameter is required.
     *
     * @example 1406333705
     *
     * @var int
     */
    public $devId;

    /**
     * @description This parameter is required.
     *
     * @example 2078053438
     *
     * @var string
     */
    public $deviceId;

    /**
     * @description This parameter is required.
     *
     * @example 泱云❄️的体00056
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description This parameter is required.
     *
     * @example 0601IFW201001N000056
     *
     * @var string
     */
    public $deviceSn;

    /**
     * @description This parameter is required.
     *
     * @var machineBluetoothVO
     */
    public $machineBluetoothVO;

    /**
     * @description This parameter is required.
     *
     * @example 10000
     *
     * @var int
     */
    public $maxFace;

    /**
     * @description This parameter is required.
     *
     * @example 4
     *
     * @var string
     */
    public $netStatus;

    /**
     * @description This parameter is required.
     *
     * @example M1F
     *
     * @var string
     */
    public $productName;

    /**
     * @description This parameter is required.
     *
     * @example 1.0.1-R-20200326.1543
     *
     * @var string
     */
    public $productVersion;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $voiceMode;
    protected $_name = [
        'atmManagerList'     => 'atmManagerList',
        'devId'              => 'devId',
        'deviceId'           => 'deviceId',
        'deviceName'         => 'deviceName',
        'deviceSn'           => 'deviceSn',
        'machineBluetoothVO' => 'machineBluetoothVO',
        'maxFace'            => 'maxFace',
        'netStatus'          => 'netStatus',
        'productName'        => 'productName',
        'productVersion'     => 'productVersion',
        'voiceMode'          => 'voiceMode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atmManagerList) {
            $res['atmManagerList'] = $this->atmManagerList;
        }
        if (null !== $this->devId) {
            $res['devId'] = $this->devId;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->deviceSn) {
            $res['deviceSn'] = $this->deviceSn;
        }
        if (null !== $this->machineBluetoothVO) {
            $res['machineBluetoothVO'] = null !== $this->machineBluetoothVO ? $this->machineBluetoothVO->toMap() : null;
        }
        if (null !== $this->maxFace) {
            $res['maxFace'] = $this->maxFace;
        }
        if (null !== $this->netStatus) {
            $res['netStatus'] = $this->netStatus;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->productVersion) {
            $res['productVersion'] = $this->productVersion;
        }
        if (null !== $this->voiceMode) {
            $res['voiceMode'] = $this->voiceMode;
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
        if (isset($map['atmManagerList'])) {
            if (!empty($map['atmManagerList'])) {
                $model->atmManagerList = $map['atmManagerList'];
            }
        }
        if (isset($map['devId'])) {
            $model->devId = $map['devId'];
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['deviceSn'])) {
            $model->deviceSn = $map['deviceSn'];
        }
        if (isset($map['machineBluetoothVO'])) {
            $model->machineBluetoothVO = machineBluetoothVO::fromMap($map['machineBluetoothVO']);
        }
        if (isset($map['maxFace'])) {
            $model->maxFace = $map['maxFace'];
        }
        if (isset($map['netStatus'])) {
            $model->netStatus = $map['netStatus'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['productVersion'])) {
            $model->productVersion = $map['productVersion'];
        }
        if (isset($map['voiceMode'])) {
            $model->voiceMode = $map['voiceMode'];
        }

        return $model;
    }
}
