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
     * @example 年假
     *
     * @var string
     */
    public $leaveName;

    /**
     * @example day
     *
     * @var string
     */
    public $leaveViewUnit;

    /**
     * @example true
     *
     * @var bool
     */
    public $naturalDayLeave;

    /**
     * @var submitTimeRule
     */
    public $submitTimeRule;

    /**
     * @var visibilityRules[]
     */
    public $visibilityRules;

    /**
     * @example user01
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'bizType'          => 'bizType',
        'extras'           => 'extras',
        'hoursInPerDay'    => 'hoursInPerDay',
        'leaveCertificate' => 'leaveCertificate',
        'leaveName'        => 'leaveName',
        'leaveViewUnit'    => 'leaveViewUnit',
        'naturalDayLeave'  => 'naturalDayLeave',
        'submitTimeRule'   => 'submitTimeRule',
        'visibilityRules'  => 'visibilityRules',
        'opUserId'         => 'opUserId',
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
        if (null !== $this->hoursInPerDay) {
            $res['hoursInPerDay'] = $this->hoursInPerDay;
        }
        if (null !== $this->leaveCertificate) {
            $res['leaveCertificate'] = null !== $this->leaveCertificate ? $this->leaveCertificate->toMap() : null;
        }
        if (null !== $this->leaveName) {
            $res['leaveName'] = $this->leaveName;
        }
        if (null !== $this->leaveViewUnit) {
            $res['leaveViewUnit'] = $this->leaveViewUnit;
        }
        if (null !== $this->naturalDayLeave) {
            $res['naturalDayLeave'] = $this->naturalDayLeave;
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
        if (isset($map['hoursInPerDay'])) {
            $model->hoursInPerDay = $map['hoursInPerDay'];
        }
        if (isset($map['leaveCertificate'])) {
            $model->leaveCertificate = leaveCertificate::fromMap($map['leaveCertificate']);
        }
        if (isset($map['leaveName'])) {
            $model->leaveName = $map['leaveName'];
        }
        if (isset($map['leaveViewUnit'])) {
            $model->leaveViewUnit = $map['leaveViewUnit'];
        }
        if (isset($map['naturalDayLeave'])) {
            $model->naturalDayLeave = $map['naturalDayLeave'];
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
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
