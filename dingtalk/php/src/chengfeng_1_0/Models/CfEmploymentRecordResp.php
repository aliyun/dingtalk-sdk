<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CfEmploymentRecordResp extends Model
{
    /**
     * @example 666
     *
     * @var string
     */
    public $deptCode;

    /**
     * @example 开发部
     *
     * @var string
     */
    public $deptName;

    /**
     * @example 3
     *
     * @var string
     */
    public $employeeStatus;

    /**
     * @example 1652198400000
     *
     * @var string
     */
    public $endDate;

    /**
     * @example true
     *
     * @var bool
     */
    public $isLatestRecord;

    /**
     * @example P1
     *
     * @var string
     */
    public $jobLevelName;

    /**
     * @example 23
     *
     * @var string
     */
    public $jobPositionCode;

    /**
     * @example Java开发工程师
     *
     * @var string
     */
    public $jobPositionName;

    /**
     * @example 343
     *
     * @var string
     */
    public $jobPostCode;

    /**
     * @example 技术岗位
     *
     * @var string
     */
    public $jobPostName;

    /**
     * @example 1
     *
     * @var string
     */
    public $serviceStatus;

    /**
     * @example 5
     *
     * @var string
     */
    public $serviceType;

    /**
     * @example 1638892800000
     *
     * @var string
     */
    public $startDate;

    /**
     * @example 123456
     *
     * @var string
     */
    public $workNumbers;
    protected $_name = [
        'deptCode'        => 'deptCode',
        'deptName'        => 'deptName',
        'employeeStatus'  => 'employeeStatus',
        'endDate'         => 'endDate',
        'isLatestRecord'  => 'isLatestRecord',
        'jobLevelName'    => 'jobLevelName',
        'jobPositionCode' => 'jobPositionCode',
        'jobPositionName' => 'jobPositionName',
        'jobPostCode'     => 'jobPostCode',
        'jobPostName'     => 'jobPostName',
        'serviceStatus'   => 'serviceStatus',
        'serviceType'     => 'serviceType',
        'startDate'       => 'startDate',
        'workNumbers'     => 'workNumbers',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->employeeStatus) {
            $res['employeeStatus'] = $this->employeeStatus;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->isLatestRecord) {
            $res['isLatestRecord'] = $this->isLatestRecord;
        }
        if (null !== $this->jobLevelName) {
            $res['jobLevelName'] = $this->jobLevelName;
        }
        if (null !== $this->jobPositionCode) {
            $res['jobPositionCode'] = $this->jobPositionCode;
        }
        if (null !== $this->jobPositionName) {
            $res['jobPositionName'] = $this->jobPositionName;
        }
        if (null !== $this->jobPostCode) {
            $res['jobPostCode'] = $this->jobPostCode;
        }
        if (null !== $this->jobPostName) {
            $res['jobPostName'] = $this->jobPostName;
        }
        if (null !== $this->serviceStatus) {
            $res['serviceStatus'] = $this->serviceStatus;
        }
        if (null !== $this->serviceType) {
            $res['serviceType'] = $this->serviceType;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->workNumbers) {
            $res['workNumbers'] = $this->workNumbers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CfEmploymentRecordResp
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['employeeStatus'])) {
            $model->employeeStatus = $map['employeeStatus'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['isLatestRecord'])) {
            $model->isLatestRecord = $map['isLatestRecord'];
        }
        if (isset($map['jobLevelName'])) {
            $model->jobLevelName = $map['jobLevelName'];
        }
        if (isset($map['jobPositionCode'])) {
            $model->jobPositionCode = $map['jobPositionCode'];
        }
        if (isset($map['jobPositionName'])) {
            $model->jobPositionName = $map['jobPositionName'];
        }
        if (isset($map['jobPostCode'])) {
            $model->jobPostCode = $map['jobPostCode'];
        }
        if (isset($map['jobPostName'])) {
            $model->jobPostName = $map['jobPostName'];
        }
        if (isset($map['serviceStatus'])) {
            $model->serviceStatus = $map['serviceStatus'];
        }
        if (isset($map['serviceType'])) {
            $model->serviceType = $map['serviceType'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['workNumbers'])) {
            $model->workNumbers = $map['workNumbers'];
        }

        return $model;
    }
}
