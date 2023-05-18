<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\sections;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\sections\punches\lateBackSetting;
use AlibabaCloud\Tea\Model;

class punches extends Model
{
    /**
     * @var int
     */
    public $absenteeismLateMinutes;

    /**
     * @example 0
     *
     * @var int
     */
    public $across;

    /**
     * @var int
     */
    public $beginMin;

    /**
     * @example 1970-01-01 19:00:00
     *
     * @var string
     */
    public $checkTime;

    /**
     * @example OnDuty
     *
     * @var string
     */
    public $checkType;

    /**
     * @example -1
     *
     * @var int
     */
    public $endMin;

    /**
     * @var bool
     */
    public $freeCheck;

    /**
     * @var lateBackSetting
     */
    public $lateBackSetting;

    /**
     * @example 0
     *
     * @var int
     */
    public $permitMinutes;

    /**
     * @example 33928201
     *
     * @var int
     */
    public $puncheId;

    /**
     * @var int
     */
    public $seriousLateMinutes;
    protected $_name = [
        'absenteeismLateMinutes' => 'absenteeismLateMinutes',
        'across'                 => 'across',
        'beginMin'               => 'beginMin',
        'checkTime'              => 'checkTime',
        'checkType'              => 'checkType',
        'endMin'                 => 'end_min',
        'freeCheck'              => 'freeCheck',
        'lateBackSetting'        => 'lateBackSetting',
        'permitMinutes'          => 'permitMinutes',
        'puncheId'               => 'puncheId',
        'seriousLateMinutes'     => 'seriousLateMinutes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->absenteeismLateMinutes) {
            $res['absenteeismLateMinutes'] = $this->absenteeismLateMinutes;
        }
        if (null !== $this->across) {
            $res['across'] = $this->across;
        }
        if (null !== $this->beginMin) {
            $res['beginMin'] = $this->beginMin;
        }
        if (null !== $this->checkTime) {
            $res['checkTime'] = $this->checkTime;
        }
        if (null !== $this->checkType) {
            $res['checkType'] = $this->checkType;
        }
        if (null !== $this->endMin) {
            $res['end_min'] = $this->endMin;
        }
        if (null !== $this->freeCheck) {
            $res['freeCheck'] = $this->freeCheck;
        }
        if (null !== $this->lateBackSetting) {
            $res['lateBackSetting'] = null !== $this->lateBackSetting ? $this->lateBackSetting->toMap() : null;
        }
        if (null !== $this->permitMinutes) {
            $res['permitMinutes'] = $this->permitMinutes;
        }
        if (null !== $this->puncheId) {
            $res['puncheId'] = $this->puncheId;
        }
        if (null !== $this->seriousLateMinutes) {
            $res['seriousLateMinutes'] = $this->seriousLateMinutes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return punches
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['absenteeismLateMinutes'])) {
            $model->absenteeismLateMinutes = $map['absenteeismLateMinutes'];
        }
        if (isset($map['across'])) {
            $model->across = $map['across'];
        }
        if (isset($map['beginMin'])) {
            $model->beginMin = $map['beginMin'];
        }
        if (isset($map['checkTime'])) {
            $model->checkTime = $map['checkTime'];
        }
        if (isset($map['checkType'])) {
            $model->checkType = $map['checkType'];
        }
        if (isset($map['end_min'])) {
            $model->endMin = $map['end_min'];
        }
        if (isset($map['freeCheck'])) {
            $model->freeCheck = $map['freeCheck'];
        }
        if (isset($map['lateBackSetting'])) {
            $model->lateBackSetting = lateBackSetting::fromMap($map['lateBackSetting']);
        }
        if (isset($map['permitMinutes'])) {
            $model->permitMinutes = $map['permitMinutes'];
        }
        if (isset($map['puncheId'])) {
            $model->puncheId = $map['puncheId'];
        }
        if (isset($map['seriousLateMinutes'])) {
            $model->seriousLateMinutes = $map['seriousLateMinutes'];
        }

        return $model;
    }
}
