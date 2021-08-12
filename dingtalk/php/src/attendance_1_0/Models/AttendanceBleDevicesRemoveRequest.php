<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class AttendanceBleDevicesRemoveRequest extends Model
{
    /**
     * @description 操作人id
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 考勤组Id
     *
     * @var string
     */
    public $groupKey;

    /**
     * @description 蓝牙设备Id列表
     *
     * @var int[]
     */
    public $deviceIdList;
    protected $_name = [
        'opUserId'     => 'opUserId',
        'groupKey'     => 'groupKey',
        'deviceIdList' => 'deviceIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->groupKey) {
            $res['groupKey'] = $this->groupKey;
        }
        if (null !== $this->deviceIdList) {
            $res['deviceIdList'] = $this->deviceIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AttendanceBleDevicesRemoveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['groupKey'])) {
            $model->groupKey = $map['groupKey'];
        }
        if (isset($map['deviceIdList'])) {
            if (!empty($map['deviceIdList'])) {
                $model->deviceIdList = $map['deviceIdList'];
            }
        }

        return $model;
    }
}
