<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AttendanceBleDevicesQueryResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 34666777
     *
     * @var int
     */
    public $deviceId;

    /**
     * @example 蓝牙设备
     *
     * @var string
     */
    public $deviceName;

    /**
     * @example 12321kllksdf
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
     * @return result
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
