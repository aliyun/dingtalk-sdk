<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest\courses\dateModel;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\InitCoursesOfClassRequest\courses\sectionModel;
use AlibabaCloud\Tea\Model;

class courses extends Model
{
    /**
     * @description teacherStaffIds
     *
     * @var string[]
     */
    public $teacherStaffIds;

    /**
     * @description courseName
     *
     * @var string
     */
    public $courseName;

    /**
     * @description dateModel
     *
     * @var dateModel
     */
    public $dateModel;

    /**
     * @description sectionModel
     *
     * @var sectionModel
     */
    public $sectionModel;

    /**
     * @description creatorName
     *
     * @var string
     */
    public $creatorName;

    /**
     * @description location
     *
     * @var string
     */
    public $location;

    /**
     * @description deleteTag
     *
     * @var bool
     */
    public $deleteTag;
    protected $_name = [
        'teacherStaffIds' => 'teacherStaffIds',
        'courseName'      => 'courseName',
        'dateModel'       => 'dateModel',
        'sectionModel'    => 'sectionModel',
        'creatorName'     => 'creatorName',
        'location'        => 'location',
        'deleteTag'       => 'deleteTag',
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
        if (null !== $this->deleteTag) {
            $res['deleteTag'] = $this->deleteTag;
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
        if (isset($map['deleteTag'])) {
            $model->deleteTag = $map['deleteTag'];
        }

        return $model;
    }
}
