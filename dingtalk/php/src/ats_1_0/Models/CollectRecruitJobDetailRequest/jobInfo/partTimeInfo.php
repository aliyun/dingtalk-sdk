<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest\jobInfo;

use AlibabaCloud\Tea\Model;

class partTimeInfo extends Model
{
    /**
     * @description 联系电话
     *
     * @var string
     */
    public $contactNumber;

    /**
     * @description 薪资发放周期
     *
     * @var string
     */
    public $salaryPeriod;

    /**
     * @description 薪资结算类型
     *
     * @var string
     */
    public $settleType;

    /**
     * @description 是否指定工作日期
     *
     * @var string
     */
    public $specifyWorkDate;

    /**
     * @description 是否指定工作时间
     *
     * @var string
     */
    public $specifyWorkTime;

    /**
     * @description 工作开始时间
     *
     * @var string
     */
    public $workBeginTimeMin;

    /**
     * @description 工作日期类型
     *
     * @var string
     */
    public $workDateType;

    /**
     * @description 工作结束日期
     *
     * @var string
     */
    public $workEndDate;

    /**
     * @description 工作结束时间
     *
     * @var string
     */
    public $workEndTimeMin;

    /**
     * @description 工作开始日期
     *
     * @var string
     */
    public $workStartDate;
    protected $_name = [
        'contactNumber'    => 'contactNumber',
        'salaryPeriod'     => 'salaryPeriod',
        'settleType'       => 'settleType',
        'specifyWorkDate'  => 'specifyWorkDate',
        'specifyWorkTime'  => 'specifyWorkTime',
        'workBeginTimeMin' => 'workBeginTimeMin',
        'workDateType'     => 'workDateType',
        'workEndDate'      => 'workEndDate',
        'workEndTimeMin'   => 'workEndTimeMin',
        'workStartDate'    => 'workStartDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactNumber) {
            $res['contactNumber'] = $this->contactNumber;
        }
        if (null !== $this->salaryPeriod) {
            $res['salaryPeriod'] = $this->salaryPeriod;
        }
        if (null !== $this->settleType) {
            $res['settleType'] = $this->settleType;
        }
        if (null !== $this->specifyWorkDate) {
            $res['specifyWorkDate'] = $this->specifyWorkDate;
        }
        if (null !== $this->specifyWorkTime) {
            $res['specifyWorkTime'] = $this->specifyWorkTime;
        }
        if (null !== $this->workBeginTimeMin) {
            $res['workBeginTimeMin'] = $this->workBeginTimeMin;
        }
        if (null !== $this->workDateType) {
            $res['workDateType'] = $this->workDateType;
        }
        if (null !== $this->workEndDate) {
            $res['workEndDate'] = $this->workEndDate;
        }
        if (null !== $this->workEndTimeMin) {
            $res['workEndTimeMin'] = $this->workEndTimeMin;
        }
        if (null !== $this->workStartDate) {
            $res['workStartDate'] = $this->workStartDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return partTimeInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactNumber'])) {
            $model->contactNumber = $map['contactNumber'];
        }
        if (isset($map['salaryPeriod'])) {
            $model->salaryPeriod = $map['salaryPeriod'];
        }
        if (isset($map['settleType'])) {
            $model->settleType = $map['settleType'];
        }
        if (isset($map['specifyWorkDate'])) {
            $model->specifyWorkDate = $map['specifyWorkDate'];
        }
        if (isset($map['specifyWorkTime'])) {
            $model->specifyWorkTime = $map['specifyWorkTime'];
        }
        if (isset($map['workBeginTimeMin'])) {
            $model->workBeginTimeMin = $map['workBeginTimeMin'];
        }
        if (isset($map['workDateType'])) {
            $model->workDateType = $map['workDateType'];
        }
        if (isset($map['workEndDate'])) {
            $model->workEndDate = $map['workEndDate'];
        }
        if (isset($map['workEndTimeMin'])) {
            $model->workEndTimeMin = $map['workEndTimeMin'];
        }
        if (isset($map['workStartDate'])) {
            $model->workStartDate = $map['workStartDate'];
        }

        return $model;
    }
}
