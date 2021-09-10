<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineResponseBody\result\machineBluetoothVO;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 设备id (deviceUid加密之后)
     *
     * @var string
     */
    public $deviceId;

    /**
     * @description 设备id (deviceId)
     *
     * @var int
     */
    public $devId;

    /**
     * @description 设备名称
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description 设备类型名称
     *
     * @var string
     */
    public $productName;

    /**
     * @description 网络状态
     *
     * @var string
     */
    public $netStatus;

    /**
     * @description 固件版本
     *
     * @var string
     */
    public $productVersion;

    /**
     * @description 设备sn号
     *
     * @var string
     */
    public $deviceSn;

    /**
     * @description 人脸容量
     *
     * @var int
     */
    public $maxFace;

    /**
     * @description 音量模式
     *
     * @var int
     */
    public $voiceMode;

    /**
     * @description 设备管理员列表
     *
     * @var string[]
     */
    public $atmManagerList;

    /**
     * @description 考勤机蓝牙相关设置信息
     *
     * @var machineBluetoothVO
     */
    public $machineBluetoothVO;
    protected $_name = [
        'deviceId'           => 'deviceId',
        'devId'              => 'devId',
        'deviceName'         => 'deviceName',
        'productName'        => 'productName',
        'netStatus'          => 'netStatus',
        'productVersion'     => 'productVersion',
        'deviceSn'           => 'deviceSn',
        'maxFace'            => 'maxFace',
        'voiceMode'          => 'voiceMode',
        'atmManagerList'     => 'atmManagerList',
        'machineBluetoothVO' => 'machineBluetoothVO',
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
        if (null !== $this->devId) {
            $res['devId'] = $this->devId;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->netStatus) {
            $res['netStatus'] = $this->netStatus;
        }
        if (null !== $this->productVersion) {
            $res['productVersion'] = $this->productVersion;
        }
        if (null !== $this->deviceSn) {
            $res['deviceSn'] = $this->deviceSn;
        }
        if (null !== $this->maxFace) {
            $res['maxFace'] = $this->maxFace;
        }
        if (null !== $this->voiceMode) {
            $res['voiceMode'] = $this->voiceMode;
        }
        if (null !== $this->atmManagerList) {
            $res['atmManagerList'] = $this->atmManagerList;
        }
        if (null !== $this->machineBluetoothVO) {
            $res['machineBluetoothVO'] = null !== $this->machineBluetoothVO ? $this->machineBluetoothVO->toMap() : null;
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
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['devId'])) {
            $model->devId = $map['devId'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['netStatus'])) {
            $model->netStatus = $map['netStatus'];
        }
        if (isset($map['productVersion'])) {
            $model->productVersion = $map['productVersion'];
        }
        if (isset($map['deviceSn'])) {
            $model->deviceSn = $map['deviceSn'];
        }
        if (isset($map['maxFace'])) {
            $model->maxFace = $map['maxFace'];
        }
        if (isset($map['voiceMode'])) {
            $model->voiceMode = $map['voiceMode'];
        }
        if (isset($map['atmManagerList'])) {
            if (!empty($map['atmManagerList'])) {
                $model->atmManagerList = $map['atmManagerList'];
            }
        }
        if (isset($map['machineBluetoothVO'])) {
            $model->machineBluetoothVO = machineBluetoothVO::fromMap($map['machineBluetoothVO']);
        }

        return $model;
    }
}
