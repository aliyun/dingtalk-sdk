<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result;

use AlibabaCloud\Tea\Model;

class shiftSetting extends Model
{
    /**
     * @example 12
     *
     * @var string
     */
    public $attendDays;

    /**
     * @example dinge87f1xxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2020-09-06 15:49:27
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2020-09-06 15:49:27
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @var int
     */
    public $overtimeBehindDuration;

    /**
     * @var int
     */
    public $overtimeFrontDuration;

    /**
     * @var bool
     */
    public $overtimeOpen;

    /**
     * @var int
     */
    public $overtimeType;

    /**
     * @example 678215070
     *
     * @var int
     */
    public $shiftId;

    /**
     * @example 233840112
     *
     * @var int
     */
    public $shiftSettingId;

    /**
     * @example NORMAL
     *
     * @var string
     */
    public $shiftType;

    /**
     * @example 600
     *
     * @var int
     */
    public $workTimeMinutes;
    protected $_name = [
        'attendDays' => 'attendDays',
        'corpId' => 'corpId',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'overtimeBehindDuration' => 'overtimeBehindDuration',
        'overtimeFrontDuration' => 'overtimeFrontDuration',
        'overtimeOpen' => 'overtimeOpen',
        'overtimeType' => 'overtimeType',
        'shiftId' => 'shiftId',
        'shiftSettingId' => 'shiftSettingId',
        'shiftType' => 'shiftType',
        'workTimeMinutes' => 'workTimeMinutes',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendDays) {
            $res['attendDays'] = $this->attendDays;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->overtimeBehindDuration) {
            $res['overtimeBehindDuration'] = $this->overtimeBehindDuration;
        }
        if (null !== $this->overtimeFrontDuration) {
            $res['overtimeFrontDuration'] = $this->overtimeFrontDuration;
        }
        if (null !== $this->overtimeOpen) {
            $res['overtimeOpen'] = $this->overtimeOpen;
        }
        if (null !== $this->overtimeType) {
            $res['overtimeType'] = $this->overtimeType;
        }
        if (null !== $this->shiftId) {
            $res['shiftId'] = $this->shiftId;
        }
        if (null !== $this->shiftSettingId) {
            $res['shiftSettingId'] = $this->shiftSettingId;
        }
        if (null !== $this->shiftType) {
            $res['shiftType'] = $this->shiftType;
        }
        if (null !== $this->workTimeMinutes) {
            $res['workTimeMinutes'] = $this->workTimeMinutes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return shiftSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendDays'])) {
            $model->attendDays = $map['attendDays'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['overtimeBehindDuration'])) {
            $model->overtimeBehindDuration = $map['overtimeBehindDuration'];
        }
        if (isset($map['overtimeFrontDuration'])) {
            $model->overtimeFrontDuration = $map['overtimeFrontDuration'];
        }
        if (isset($map['overtimeOpen'])) {
            $model->overtimeOpen = $map['overtimeOpen'];
        }
        if (isset($map['overtimeType'])) {
            $model->overtimeType = $map['overtimeType'];
        }
        if (isset($map['shiftId'])) {
            $model->shiftId = $map['shiftId'];
        }
        if (isset($map['shiftSettingId'])) {
            $model->shiftSettingId = $map['shiftSettingId'];
        }
        if (isset($map['shiftType'])) {
            $model->shiftType = $map['shiftType'];
        }
        if (isset($map['workTimeMinutes'])) {
            $model->workTimeMinutes = $map['workTimeMinutes'];
        }

        return $model;
    }
}
