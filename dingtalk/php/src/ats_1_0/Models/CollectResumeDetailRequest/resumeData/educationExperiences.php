<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;

use AlibabaCloud\Tea\Model;

class educationExperiences extends Model
{
    /**
     * @description 学历
     *
     * @var int
     */
    public $degree;

    /**
     * @description 院系
     *
     * @var string
     */
    public $department;

    /**
     * @description 详细描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 结束时间
     *
     * @var string
     */
    public $endDate;

    /**
     * @description 专业
     *
     * @var string
     */
    public $major;

    /**
     * @description 学校名称
     *
     * @var string
     */
    public $schoolName;

    /**
     * @description 开始时间
     *
     * @var string
     */
    public $startDate;
    protected $_name = [
        'degree'      => 'degree',
        'department'  => 'department',
        'description' => 'description',
        'endDate'     => 'endDate',
        'major'       => 'major',
        'schoolName'  => 'schoolName',
        'startDate'   => 'startDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->degree) {
            $res['degree'] = $this->degree;
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
        if (null !== $this->major) {
            $res['major'] = $this->major;
        }
        if (null !== $this->schoolName) {
            $res['schoolName'] = $this->schoolName;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return educationExperiences
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['degree'])) {
            $model->degree = $map['degree'];
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
        if (isset($map['major'])) {
            $model->major = $map['major'];
        }
        if (isset($map['schoolName'])) {
            $model->schoolName = $map['schoolName'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
