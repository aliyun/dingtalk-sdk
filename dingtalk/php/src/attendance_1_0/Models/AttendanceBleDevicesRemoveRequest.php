<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class AttendanceBleDevicesRemoveRequest extends Model
{
    /**
     * @description 蓝牙设备Id列表
     *
     * @var int[]
     */
    public $deviceIdList;

    /**
     * @description 考勤组Id
     *
     * @var string
     */
    public $groupKey;

    /**
     * @description 操作人id
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'deviceIdList' => 'deviceIdList',
        'groupKey'     => 'groupKey',
        'opUserId'     => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceIdList) {
            $res['deviceIdList'] = $this->deviceIdList;
        }
        if (null !== $this->groupKey) {
            $res['groupKey'] = $this->groupKey;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
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
        if (isset($map['deviceIdList'])) {
            if (!empty($map['deviceIdList'])) {
                $model->deviceIdList = $map['deviceIdList'];
            }
        }
        if (isset($map['groupKey'])) {
            $model->groupKey = $map['groupKey'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
