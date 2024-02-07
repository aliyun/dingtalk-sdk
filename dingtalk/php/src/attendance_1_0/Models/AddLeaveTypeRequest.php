<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AddLeaveTypeRequest\leaveCertificate;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AddLeaveTypeRequest\submitTimeRule;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\AddLeaveTypeRequest\visibilityRules;
use AlibabaCloud\Tea\Model;

class AddLeaveTypeRequest extends Model
{
    /**
     * @example general_leave
     *
     * @var string
     */
    public $bizType;

    /**
     * @example {"validity_type":"absolute_time","validity_value":"12-31"}
     *
     * @var string
     */
    public $extras;

    /**
     * @example false
     *
     * @var bool
     */
    public $freedomLeave;

    /**
     * @example 1000
     *
     * @var int
     */
    public $hoursInPerDay;

    /**
     * @var leaveCertificate
     */
    public $leaveCertificate;

    /**
     * @example up
     *
     * @var string
     */
    public $leaveHourCeil;

    /**
     * @example 年假
     *
     * @var string
     */
    public $leaveName;

    /**
     * @example false
     *
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
     * @example day
     *
     * @var string
     */
    public $leaveViewUnit;

    /**
     * @example 1
     *
     * @var int
     */
    public $maxLeaveTime;

    /**
     * @example 2
     *
     * @var float
     */
    public $minLeaveHour;

    /**
     * @example true
     *
     * @var bool
     */
    public $naturalDayLeave;

    /**
     * @example false
     *
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
     * @example entry
     *
     * @var string
     */
    public $whenCanLeave;

    /**
     * @example user01
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'bizType'              => 'bizType',
        'extras'               => 'extras',
        'freedomLeave'         => 'freedomLeave',
        'hoursInPerDay'        => 'hoursInPerDay',
        'leaveCertificate'     => 'leaveCertificate',
        'leaveHourCeil'        => 'leaveHourCeil',
        'leaveName'            => 'leaveName',
        'leaveTimeCeil'        => 'leaveTimeCeil',
        'leaveTimeCeilMinUnit' => 'leaveTimeCeilMinUnit',
        'leaveViewUnit'        => 'leaveViewUnit',
        'maxLeaveTime'         => 'maxLeaveTime',
        'minLeaveHour'         => 'minLeaveHour',
        'naturalDayLeave'      => 'naturalDayLeave',
        'paidLeave'            => 'paidLeave',
        'submitTimeRule'       => 'submitTimeRule',
        'visibilityRules'      => 'visibilityRules',
        'whenCanLeave'         => 'whenCanLeave',
        'opUserId'             => 'opUserId',
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
        if (null !== $this->extras) {
            $res['extras'] = $this->extras;
        }
        if (null !== $this->freedomLeave) {
            $res['freedomLeave'] = $this->freedomLeave;
        }
        if (null !== $this->hoursInPerDay) {
            $res['hoursInPerDay'] = $this->hoursInPerDay;
        }
        if (null !== $this->leaveCertificate) {
            $res['leaveCertificate'] = null !== $this->leaveCertificate ? $this->leaveCertificate->toMap() : null;
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
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddLeaveTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['extras'])) {
            $model->extras = $map['extras'];
        }
        if (isset($map['freedomLeave'])) {
            $model->freedomLeave = $map['freedomLeave'];
        }
        if (isset($map['hoursInPerDay'])) {
            $model->hoursInPerDay = $map['hoursInPerDay'];
        }
        if (isset($map['leaveCertificate'])) {
            $model->leaveCertificate = leaveCertificate::fromMap($map['leaveCertificate']);
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
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
