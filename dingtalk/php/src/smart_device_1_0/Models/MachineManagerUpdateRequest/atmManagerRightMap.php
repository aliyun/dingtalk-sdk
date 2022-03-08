<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\MachineManagerUpdateRequest;

use AlibabaCloud\Tea\Model;

class atmManagerRightMap extends Model
{
    /**
     * @description 添加/删除考勤人员。
     *
     * @var bool
     */
    public $attendancePersonManage;

    /**
     * @description 蓝牙打卡管理。
     *
     * @var bool
     */
    public $bluetoothPunchManage;

    /**
     * @description 设备解绑并重置。
     *
     * @var bool
     */
    public $deviceReset;

    /**
     * @description 设备设置。
     *
     * @var bool
     */
    public $deviceSettings;

    /**
     * @description 人脸打卡管理。
     *
     * @var bool
     */
    public $facePunchManage;

    /**
     * @description 指纹打卡管理。
     *
     * @var bool
     */
    public $fingerPunchManage;
    protected $_name = [
        'attendancePersonManage' => 'attendancePersonManage',
        'bluetoothPunchManage'   => 'bluetoothPunchManage',
        'deviceReset'            => 'deviceReset',
        'deviceSettings'         => 'deviceSettings',
        'facePunchManage'        => 'facePunchManage',
        'fingerPunchManage'      => 'fingerPunchManage',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendancePersonManage) {
            $res['attendancePersonManage'] = $this->attendancePersonManage;
        }
        if (null !== $this->bluetoothPunchManage) {
            $res['bluetoothPunchManage'] = $this->bluetoothPunchManage;
        }
        if (null !== $this->deviceReset) {
            $res['deviceReset'] = $this->deviceReset;
        }
        if (null !== $this->deviceSettings) {
            $res['deviceSettings'] = $this->deviceSettings;
        }
        if (null !== $this->facePunchManage) {
            $res['facePunchManage'] = $this->facePunchManage;
        }
        if (null !== $this->fingerPunchManage) {
            $res['fingerPunchManage'] = $this->fingerPunchManage;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return atmManagerRightMap
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendancePersonManage'])) {
            $model->attendancePersonManage = $map['attendancePersonManage'];
        }
        if (isset($map['bluetoothPunchManage'])) {
            $model->bluetoothPunchManage = $map['bluetoothPunchManage'];
        }
        if (isset($map['deviceReset'])) {
            $model->deviceReset = $map['deviceReset'];
        }
        if (isset($map['deviceSettings'])) {
            $model->deviceSettings = $map['deviceSettings'];
        }
        if (isset($map['facePunchManage'])) {
            $model->facePunchManage = $map['facePunchManage'];
        }
        if (isset($map['fingerPunchManage'])) {
            $model->fingerPunchManage = $map['fingerPunchManage'];
        }

        return $model;
    }
}
