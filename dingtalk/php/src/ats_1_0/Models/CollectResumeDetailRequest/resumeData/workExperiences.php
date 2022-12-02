<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;

use AlibabaCloud\Tea\Model;

class workExperiences extends Model
{
    /**
     * @description 公司名称
     *
     * @var string
     */
    public $companyName;

    /**
     * @description 部门
     *
     * @var string
     */
    public $department;

    /**
     * @description 工作详情描述
     *
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $endDate;

    /**
     * @description 职位名称
     *
     * @var string
     */
    public $jobTitle;

    /**
     * @description 工作地点
     *
     * @var string
     */
    public $location;

    /**
     * @description 工作职责
     *
     * @var string
     */
    public $responsibility;

    /**
     * @var string
     */
    public $startDate;
    protected $_name = [
        'companyName'    => 'companyName',
        'department'     => 'department',
        'description'    => 'description',
        'endDate'        => 'endDate',
        'jobTitle'       => 'jobTitle',
        'location'       => 'location',
        'responsibility' => 'responsibility',
        'startDate'      => 'startDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyName) {
            $res['companyName'] = $this->companyName;
        }
        if (null !== $this->department) {
            $res['department'] = $this->department;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->jobTitle) {
            $res['jobTitle'] = $this->jobTitle;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->responsibility) {
            $res['responsibility'] = $this->responsibility;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workExperiences
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyName'])) {
            $model->companyName = $map['companyName'];
        }
        if (isset($map['department'])) {
            $model->department = $map['department'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['jobTitle'])) {
            $model->jobTitle = $map['jobTitle'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['responsibility'])) {
            $model->responsibility = $map['responsibility'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
