<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveTypeResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveTypeResponseBody\result\leaveCertificate;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveTypeResponseBody\result\submitTimeRule;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveTypeResponseBody\result\visibilityRules;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 每天折算的工作时长(百分之一 例如1天=10小时=1000)
     *
     * @var int
     */
    public $hoursInPerDay;

    /**
     * @description 请假证明
     *
     * @var leaveCertificate
     */
    public $leaveCertificate;

    /**
     * @description 假期类型唯一标识
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @description 假期名称
     *
     * @var string
     */
    public $leaveName;

    /**
     * @description 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
     *
     * @var string
     */
    public $leaveViewUnit;

    /**
     * @description 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
     *
     * @var bool
     */
    public $naturalDayLeave;

    /**
     * @description 开放接口自定义的:external oa后台新建的：inner
     *
     * @var string
     */
    public $source;

    /**
     * @description 限时提交规则
     *
     * @var submitTimeRule
     */
    public $submitTimeRule;

    /**
     * @description 有效类型 absolute_time(绝对时间)、relative_time(相对时间)其中一种
     *
     * @var string
     */
    public $validityType;

    /**
     * @description 延长日期(当validity_type为absolute_time该值该值不为空且满足yy-mm格式 validity_type为relative_time该值为大于1的整数)
     *
     * @var string
     */
    public $validityValue;

    /**
     * @description 适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司
     *
     * @var visibilityRules[]
     */
    public $visibilityRules;
    protected $_name = [
        'bizType'          => 'bizType',
        'hoursInPerDay'    => 'hoursInPerDay',
        'leaveCertificate' => 'leaveCertificate',
        'leaveCode'        => 'leaveCode',
        'leaveName'        => 'leaveName',
        'leaveViewUnit'    => 'leaveViewUnit',
        'naturalDayLeave'  => 'naturalDayLeave',
        'source'           => 'source',
        'submitTimeRule'   => 'submitTimeRule',
        'validityType'     => 'validityType',
        'validityValue'    => 'validityValue',
        'visibilityRules'  => 'visibilityRules',
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
        if (null !== $this->leaveName) {
            $res['leaveName'] = $this->leaveName;
        }
        if (null !== $this->leaveViewUnit) {
            $res['leaveViewUnit'] = $this->leaveViewUnit;
        }
        if (null !== $this->naturalDayLeave) {
            $res['naturalDayLeave'] = $this->naturalDayLeave;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->submitTimeRule) {
            $res['submitTimeRule'] = null !== $this->submitTimeRule ? $this->submitTimeRule->toMap() : null;
        }
        if (null !== $this->validityType) {
            $res['validityType'] = $this->validityType;
        }
        if (null !== $this->validityValue) {
            $res['validityValue'] = $this->validityValue;
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
        if (isset($map['leaveName'])) {
            $model->leaveName = $map['leaveName'];
        }
        if (isset($map['leaveViewUnit'])) {
            $model->leaveViewUnit = $map['leaveViewUnit'];
        }
        if (isset($map['naturalDayLeave'])) {
            $model->naturalDayLeave = $map['naturalDayLeave'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['submitTimeRule'])) {
            $model->submitTimeRule = submitTimeRule::fromMap($map['submitTimeRule']);
        }
        if (isset($map['validityType'])) {
            $model->validityType = $map['validityType'];
        }
        if (isset($map['validityValue'])) {
            $model->validityValue = $map['validityValue'];
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

        return $model;
    }
}
