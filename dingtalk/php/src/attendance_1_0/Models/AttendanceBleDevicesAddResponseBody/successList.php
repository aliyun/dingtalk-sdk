<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesAddResponseBody;

use AlibabaCloud\Tea\Model;

class successList extends Model
{
    /**
     * @description 蓝牙设备Id
     *
     * @var int
     */
    public $deviceId;

    /**
     * @description 蓝牙设备名称
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description sn
     *
     * @var string
     */
    public $sn;
    protected $_name = [
        'deviceId'   => 'deviceId',
        'deviceName' => 'deviceName',
        'sn'         => 'sn',
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
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return successList
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
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }

        return $model;
    }
}
