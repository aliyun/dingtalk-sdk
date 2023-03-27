<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CfEmploymentRecordResp extends Model
{
    /**
     * @description 部门编码
     *
     * @var string
     */
    public $deptCode;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $deptName;

    /**
     * @description 人员状态(2:试用,3:正式)
     *
     * @var string
     */
    public $employeeStatus;

    /**
     * @description 结束时间
     *
     * @var string
     */
    public $endDate;

    /**
     * @description 是否是最新任职
     *
     * @var bool
     */
    public $isLatestRecord;

    /**
     * @description 职级名称
     *
     * @var string
     */
    public $jobLevelName;

    /**
     * @description 职位编码
     *
     * @var string
     */
    public $jobPositionCode;

    /**
     * @description 职位名称
     *
     * @var string
     */
    public $jobPositionName;

    /**
     * @description 职务编码
     *
     * @var string
     */
    public $jobPostCode;

    /**
     * @description 职务名称
     *
     * @var string
     */
    public $jobPostName;

    /**
     * @description 任职状态(1:任职中,2:任职结束)
     *
     * @var string
     */
    public $serviceStatus;

    /**
     * @description 任职类型(5:主职, 6:兼职)
     *
     * @var string
     */
    public $serviceType;

    /**
     * @description 开始时间
     *
     * @var string
     */
    public $startDate;

    /**
     * @description 工号
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
