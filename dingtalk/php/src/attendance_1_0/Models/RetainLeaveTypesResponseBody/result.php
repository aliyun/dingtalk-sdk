<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesResponseBody\result\leaveCertificate;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesResponseBody\result\submitTimeRule;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\RetainLeaveTypesResponseBody\result\visibilityRules;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example lieu_leave
     *
     * @var string
     */
    public $bizType;

    /**
     * @example 8
     *
     * @var int
     */
    public $hoursInPerDay;

    /**
     * @var leaveCertificate
     */
    public $leaveCertificate;

    /**
     * @example 2e8b764e-7989-4b5d-ac64-xxxxx
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @example ""
     *
     * @var string
     */
    public $leaveHourCeil;

    /**
     * @example 高级测试假期
     *
     * @var string
     */
    public $leaveName;

    /**
     * @var bool
     */
    public $leaveTimeCeil;

    /**
     * @example hour
     *
     * @var string
     */
    public $leaveTimeCeilMinUnit;

    /**
     * @example hour
     *
     * @var string
     */
    public $leaveViewUnit;

    /**
     * @example 30
     *
     * @var int
     */
    public $lieuDelayNum;

    /**
     * @example day
     *
     * @var string
     */
    public $lieuDelayUnit;

    /**
     * @example 24
     *
     * @var int
     */
    public $maxLeaveTime;

    /**
     * @example 0.5
     *
     * @var float
     */
    public $minLeaveHour;

    /**
     * @var bool
     */
    public $naturalDayLeave;

    /**
     * @var bool
     */
    public $paidLeave;

    /**
     * @var submitTimeRule
     */
    public $submitTimeRule;

    /**
     * @var visibilityRules[]
     */
    public $visibilityRules;

    /**
     * @example formal
     *
     * @var string
     */
    public $whenCanLeave;
    protected $_name = [
        'bizType'              => 'bizType',
        'hoursInPerDay'        => 'hoursInPerDay',
        'leaveCertificate'     => 'leaveCertificate',
        'leaveCode'            => 'leaveCode',
        'leaveHourCeil'        => 'leaveHourCeil',
        'leaveName'            => 'leaveName',
        'leaveTimeCeil'        => 'leaveTimeCeil',
        'leaveTimeCeilMinUnit' => 'leaveTimeCeilMinUnit',
        'leaveViewUnit'        => 'leaveViewUnit',
        'lieuDelayNum'         => 'lieuDelayNum',
        'lieuDelayUnit'        => 'lieuDelayUnit',
        'maxLeaveTime'         => 'maxLeaveTime',
        'minLeaveHour'         => 'minLeaveHour',
        'naturalDayLeave'      => 'naturalDayLeave',
        'paidLeave'            => 'paidLeave',
        'submitTimeRule'       => 'submitTimeRule',
        'visibilityRules'      => 'visibilityRules',
        'whenCanLeave'         => 'whenCanLeave',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->hoursInPerDay) {
            $res['hoursInPerDay'] = $this->hoursInPerDay;
        }
        if (null !== $this->leaveCertificate) {
            $res['leaveCertificate'] = null !== $this->leaveCertificate ? $this->leaveCertificate->toMap() : null;
        }
        if (null !== $this->leaveCode) {
            $res['leaveCode'] = $this->leaveCode;
        }
        if (null !== $this->leaveHourCeil) {
            $res['leaveHourCeil'] = $this->leaveHourCeil;
        }
        if (null !== $this->leaveName) {
            $res['leaveName'] = $this->leaveName;
        }
        if (null !== $this->leaveTimeCeil) {
            $res['leaveTimeCeil'] = $this->leaveTimeCeil;
        }
        if (null !== $this->leaveTimeCeilMinUnit) {
            $res['leaveTimeCeilMinUnit'] = $this->leaveTimeCeilMinUnit;
        }
        if (null !== $this->leaveViewUnit) {
            $res['leaveViewUnit'] = $this->leaveViewUnit;
        }
        if (null !== $this->lieuDelayNum) {
            $res['lieuDelayNum'] = $this->lieuDelayNum;
        }
        if (null !== $this->lieuDelayUnit) {
            $res['lieuDelayUnit'] = $this->lieuDelayUnit;
        }
        if (null !== $this->maxLeaveTime) {
            $res['maxLeaveTime'] = $this->maxLeaveTime;
        }
        if (null !== $this->minLeaveHour) {
            $res['minLeaveHour'] = $this->minLeaveHour;
        }
        if (null !== $this->naturalDayLeave) {
            $res['naturalDayLeave'] = $this->naturalDayLeave;
        }
        if (null !== $this->paidLeave) {
            $res['paidLeave'] = $this->paidLeave;
        }
        if (null !== $this->submitTimeRule) {
            $res['submitTimeRule'] = null !== $this->submitTimeRule ? $this->submitTimeRule->toMap() : null;
        }
        if (null !== $this->visibilityRules) {
            $res['visibilityRules'] = [];
            if (null !== $this->visibilityRules && \is_array($this->visibilityRules)) {
                $n = 0;
                foreach ($this->visibilityRules as $item) {
                    $res['visibilityRules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->whenCanLeave) {
            $res['whenCanLeave'] = $this->whenCanLeave;
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
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['hoursInPerDay'])) {
            $model->hoursInPerDay = $map['hoursInPerDay'];
        }
        if (isset($map['leaveCertificate'])) {
            $model->leaveCertificate = leaveCertificate::fromMap($map['leaveCertificate']);
        }
        if (isset($map['leaveCode'])) {
            $model->leaveCode = $map['leaveCode'];
        }
        if (isset($map['leaveHourCeil'])) {
            $model->leaveHourCeil = $map['leaveHourCeil'];
        }
        if (isset($map['leaveName'])) {
            $model->leaveName = $map['leaveName'];
        }
        if (isset($map['leaveTimeCeil'])) {
            $model->leaveTimeCeil = $map['leaveTimeCeil'];
        }
        if (isset($map['leaveTimeCeilMinUnit'])) {
            $model->leaveTimeCeilMinUnit = $map['leaveTimeCeilMinUnit'];
        }
        if (isset($map['leaveViewUnit'])) {
            $model->leaveViewUnit = $map['leaveViewUnit'];
        }
        if (isset($map['lieuDelayNum'])) {
            $model->lieuDelayNum = $map['lieuDelayNum'];
        }
        if (isset($map['lieuDelayUnit'])) {
            $model->lieuDelayUnit = $map['lieuDelayUnit'];
        }
        if (isset($map['maxLeaveTime'])) {
            $model->maxLeaveTime = $map['maxLeaveTime'];
        }
        if (isset($map['minLeaveHour'])) {
            $model->minLeaveHour = $map['minLeaveHour'];
        }
        if (isset($map['naturalDayLeave'])) {
            $model->naturalDayLeave = $map['naturalDayLeave'];
        }
        if (isset($map['paidLeave'])) {
            $model->paidLeave = $map['paidLeave'];
        }
        if (isset($map['submitTimeRule'])) {
            $model->submitTimeRule = submitTimeRule::fromMap($map['submitTimeRule']);
        }
        if (isset($map['visibilityRules'])) {
            if (!empty($map['visibilityRules'])) {
                $model->visibilityRules = [];
                $n                      = 0;
                foreach ($map['visibilityRules'] as $item) {
                    $model->visibilityRules[$n++] = null !== $item ? visibilityRules::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['whenCanLeave'])) {
            $model->whenCanLeave = $map['whenCanLeave'];
        }

        return $model;
    }
}
