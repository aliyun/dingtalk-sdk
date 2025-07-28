<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeDetailRequest\resumeData;

use AlibabaCloud\Tea\Model;

class educationExperiences extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $degree;

    /**
     * @example 计算机学院
     *
     * @var string
     */
    public $department;

    /**
     * @example 在校期间.......
     *
     * @var string
     */
    public $description;

    /**
     * @example yyyy-MM-dd
     *
     * @var string
     */
    public $endDate;

    /**
     * @example 计算机科学与技术
     *
     * @var string
     */
    public $major;

    /**
     * @example 清华大学
     *
     * @var string
     */
    public $schoolName;

    /**
     * @example yyyy-MM-dd
     *
     * @var string
     */
    public $startDate;
    protected $_name = [
        'degree' => 'degree',
        'department' => 'department',
        'description' => 'description',
        'endDate' => 'endDate',
        'major' => 'major',
        'schoolName' => 'schoolName',
        'startDate' => 'startDate',
    ];

    public function validate() {}

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
