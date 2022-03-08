<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest\courses\dateModel;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\UpdateCoursesOfClassRequest\courses\sectionModel;
use AlibabaCloud\Tea\Model;

class courses extends Model
{
    /**
     * @description 课程code：删除/更新必填
     *
     * @var string
     */
    public $courseCode;

    /**
     * @description 课组code
     *
     * @var string
     */
    public $courseGroupCode;

    /**
     * @description 课程名称
     *
     * @var string
     */
    public $courseName;

    /**
     * @description 创建者名字
     *
     * @var string
     */
    public $creatorName;

    /**
     * @description 上课日期
     *
     * @var dateModel
     */
    public $dateModel;

    /**
     * @description 删除标记：要删除为ture
     *
     * @var bool
     */
    public $deleteTag;

    /**
     * @description 上课地点
     *
     * @var string
     */
    public $location;

    /**
     * @description 节次模型
     *
     * @var sectionModel
     */
    public $sectionModel;

    /**
     * @description 老师Staffid
     *
     * @var string[]
     */
    public $teacherStaffIds;
    protected $_name = [
        'courseCode'      => 'courseCode',
        'courseGroupCode' => 'courseGroupCode',
        'courseName'      => 'courseName',
        'creatorName'     => 'creatorName',
        'dateModel'       => 'dateModel',
        'deleteTag'       => 'deleteTag',
        'location'        => 'location',
        'sectionModel'    => 'sectionModel',
        'teacherStaffIds' => 'teacherStaffIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
        }
        if (null !== $this->courseGroupCode) {
            $res['courseGroupCode'] = $this->courseGroupCode;
        }
        if (null !== $this->courseName) {
            $res['courseName'] = $this->courseName;
        }
        if (null !== $this->creatorName) {
            $res['creatorName'] = $this->creatorName;
        }
        if (null !== $this->dateModel) {
            $res['dateModel'] = null !== $this->dateModel ? $this->dateModel->toMap() : null;
        }
        if (null !== $this->deleteTag) {
            $res['deleteTag'] = $this->deleteTag;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->sectionModel) {
            $res['sectionModel'] = null !== $this->sectionModel ? $this->sectionModel->toMap() : null;
        }
        if (null !== $this->teacherStaffIds) {
            $res['teacherStaffIds'] = $this->teacherStaffIds;
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
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }
        if (isset($map['courseGroupCode'])) {
            $model->courseGroupCode = $map['courseGroupCode'];
        }
        if (isset($map['courseName'])) {
            $model->courseName = $map['courseName'];
        }
        if (isset($map['creatorName'])) {
            $model->creatorName = $map['creatorName'];
        }
        if (isset($map['dateModel'])) {
            $model->dateModel = dateModel::fromMap($map['dateModel']);
        }
        if (isset($map['deleteTag'])) {
            $model->deleteTag = $map['deleteTag'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['sectionModel'])) {
            $model->sectionModel = sectionModel::fromMap($map['sectionModel']);
        }
        if (isset($map['teacherStaffIds'])) {
            if (!empty($map['teacherStaffIds'])) {
                $model->teacherStaffIds = $map['teacherStaffIds'];
            }
        }

        return $model;
    }
}
