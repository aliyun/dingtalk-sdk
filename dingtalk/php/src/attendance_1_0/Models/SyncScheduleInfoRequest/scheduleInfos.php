<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\SyncScheduleInfoRequest;

use AlibabaCloud\Tea\Model;

class scheduleInfos extends Model
{
    /**
     * @var int
     */
    public $planId;

    /**
     * @var string[]
     */
    public $positionKeys;

    /**
     * @var bool
     */
    public $retainAttendanceCheck;

    /**
     * @var string[]
     */
    public $wifiKeys;
    protected $_name = [
        'planId'                => 'planId',
        'positionKeys'          => 'positionKeys',
        'retainAttendanceCheck' => 'retainAttendanceCheck',
        'wifiKeys'              => 'wifiKeys',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->planId) {
            $res['planId'] = $this->planId;
        }
        if (null !== $this->positionKeys) {
            $res['positionKeys'] = $this->positionKeys;
        }
        if (null !== $this->retainAttendanceCheck) {
            $res['retainAttendanceCheck'] = $this->retainAttendanceCheck;
        }
        if (null !== $this->wifiKeys) {
            $res['wifiKeys'] = $this->wifiKeys;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return scheduleInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['planId'])) {
            $model->planId = $map['planId'];
        }
        if (isset($map['positionKeys'])) {
            if (!empty($map['positionKeys'])) {
                $model->positionKeys = $map['positionKeys'];
            }
        }
        if (isset($map['retainAttendanceCheck'])) {
            $model->retainAttendanceCheck = $map['retainAttendanceCheck'];
        }
        if (isset($map['wifiKeys'])) {
            if (!empty($map['wifiKeys'])) {
                $model->wifiKeys = $map['wifiKeys'];
            }
        }

        return $model;
    }
}
