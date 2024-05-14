<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest\courserGroupItemModels\courserGroupItemEndDate;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest\courserGroupItemModels\courserGroupItemStartDate;
use AlibabaCloud\Tea\Model;

class courserGroupItemModels extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1、单周；2、双周；3、全周
     *
     * @var int
     */
    public $classPeriodType;

    /**
     * @description This parameter is required.
     *
     * @example 10001
     *
     * @var int
     */
    public $classroomId;

    /**
     * @description This parameter is required.
     *
     * @example 1;音视频直播\2:线下课程\4:音视频及线下
     *
     * @var int
     */
    public $courseType;

    /**
     * @description This parameter is required.
     *
     * @var courserGroupItemEndDate
     */
    public $courserGroupItemEndDate;

    /**
     * @description This parameter is required.
     *
     * @var courserGroupItemStartDate
     */
    public $courserGroupItemStartDate;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $dayOfWeek;

    /**
     * @description This parameter is required.
     *
     * @var int[]
     */
    public $sectionIndex;
    protected $_name = [
        'classPeriodType'           => 'classPeriodType',
        'classroomId'               => 'classroomId',
        'courseType'                => 'courseType',
        'courserGroupItemEndDate'   => 'courserGroupItemEndDate',
        'courserGroupItemStartDate' => 'courserGroupItemStartDate',
        'dayOfWeek'                 => 'dayOfWeek',
        'sectionIndex'              => 'sectionIndex',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classPeriodType) {
            $res['classPeriodType'] = $this->classPeriodType;
        }
        if (null !== $this->classroomId) {
            $res['classroomId'] = $this->classroomId;
        }
        if (null !== $this->courseType) {
            $res['courseType'] = $this->courseType;
        }
        if (null !== $this->courserGroupItemEndDate) {
            $res['courserGroupItemEndDate'] = null !== $this->courserGroupItemEndDate ? $this->courserGroupItemEndDate->toMap() : null;
        }
        if (null !== $this->courserGroupItemStartDate) {
            $res['courserGroupItemStartDate'] = null !== $this->courserGroupItemStartDate ? $this->courserGroupItemStartDate->toMap() : null;
        }
        if (null !== $this->dayOfWeek) {
            $res['dayOfWeek'] = $this->dayOfWeek;
        }
        if (null !== $this->sectionIndex) {
            $res['sectionIndex'] = $this->sectionIndex;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return courserGroupItemModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classPeriodType'])) {
            $model->classPeriodType = $map['classPeriodType'];
        }
        if (isset($map['classroomId'])) {
            $model->classroomId = $map['classroomId'];
        }
        if (isset($map['courseType'])) {
            $model->courseType = $map['courseType'];
        }
        if (isset($map['courserGroupItemEndDate'])) {
            $model->courserGroupItemEndDate = courserGroupItemEndDate::fromMap($map['courserGroupItemEndDate']);
        }
        if (isset($map['courserGroupItemStartDate'])) {
            $model->courserGroupItemStartDate = courserGroupItemStartDate::fromMap($map['courserGroupItemStartDate']);
        }
        if (isset($map['dayOfWeek'])) {
            $model->dayOfWeek = $map['dayOfWeek'];
        }
        if (isset($map['sectionIndex'])) {
            if (!empty($map['sectionIndex'])) {
                $model->sectionIndex = $map['sectionIndex'];
            }
        }

        return $model;
    }
}
