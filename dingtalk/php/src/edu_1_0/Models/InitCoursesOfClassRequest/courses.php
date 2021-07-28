<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest\courses\dateModel;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest\courses\sectionModel;
use AlibabaCloud\Tea\Model;

class courses extends Model
{
    /**
     * @description 老师的staffId。
     *
     * @var string[]
     */
    public $teacherStaffIds;

    /**
     * @description 课程名称。
     *
     * @var string
     */
    public $courseName;

    /**
     * @description 上课时间。
     *
     * @var dateModel
     */
    public $dateModel;

    /**
     * @description 课程节次。
     *
     * @var sectionModel
     */
    public $sectionModel;

    /**
     * @description 创建者名称。
     *
     * @var string
     */
    public $creatorName;

    /**
     * @description 上课地点
     *
     * @var string
     */
    public $location;
    protected $_name = [
        'teacherStaffIds' => 'teacherStaffIds',
        'courseName'      => 'courseName',
        'dateModel'       => 'dateModel',
        'sectionModel'    => 'sectionModel',
        'creatorName'     => 'creatorName',
        'location'        => 'location',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->teacherStaffIds) {
            $res['teacherStaffIds'] = $this->teacherStaffIds;
        }
        if (null !== $this->courseName) {
            $res['courseName'] = $this->courseName;
        }
        if (null !== $this->dateModel) {
            $res['dateModel'] = null !== $this->dateModel ? $this->dateModel->toMap() : null;
        }
        if (null !== $this->sectionModel) {
            $res['sectionModel'] = null !== $this->sectionModel ? $this->sectionModel->toMap() : null;
        }
        if (null !== $this->creatorName) {
            $res['creatorName'] = $this->creatorName;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return courses
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['teacherStaffIds'])) {
            if (!empty($map['teacherStaffIds'])) {
                $model->teacherStaffIds = $map['teacherStaffIds'];
            }
        }
        if (isset($map['courseName'])) {
            $model->courseName = $map['courseName'];
        }
        if (isset($map['dateModel'])) {
            $model->dateModel = dateModel::fromMap($map['dateModel']);
        }
        if (isset($map['sectionModel'])) {
            $model->sectionModel = sectionModel::fromMap($map['sectionModel']);
        }
        if (isset($map['creatorName'])) {
            $model->creatorName = $map['creatorName'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }

        return $model;
    }
}
