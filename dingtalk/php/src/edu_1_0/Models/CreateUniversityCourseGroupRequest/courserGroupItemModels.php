<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest\courserGroupItemModels\courserGroupItemEndDate;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest\courserGroupItemModels\courserGroupItemStartDate;
use AlibabaCloud\Tea\Model;

class courserGroupItemModels extends Model
{
    /**
     * @description 一周的第几天
     *
     * @var int
     */
    public $dayOfWeek;

    /**
     * @description 上课周期
     *
     * @var int
     */
    public $classPeriodType;

    /**
     * @description 课程组详细开始时间
     *
     * @var courserGroupItemStartDate
     */
    public $courserGroupItemStartDate;

    /**
     * @description 课节
     *
     * @var int[]
     */
    public $sectionIndex;

    /**
     * @description 课程组详细结束时间
     *
     * @var courserGroupItemEndDate
     */
    public $courserGroupItemEndDate;

    /**
     * @description 课程类型
     *
     * @var int
     */
    public $courseType;

    /**
     * @description 教室id
     *
     * @var int
     */
    public $classroomId;
    protected $_name = [
        'dayOfWeek'                 => 'dayOfWeek',
        'classPeriodType'           => 'classPeriodType',
        'courserGroupItemStartDate' => 'courserGroupItemStartDate',
        'sectionIndex'              => 'sectionIndex',
        'courserGroupItemEndDate'   => 'courserGroupItemEndDate',
        'courseType'                => 'courseType',
        'classroomId'               => 'classroomId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dayOfWeek) {
            $res['dayOfWeek'] = $this->dayOfWeek;
        }
        if (null !== $this->classPeriodType) {
            $res['classPeriodType'] = $this->classPeriodType;
        }
        if (null !== $this->courserGroupItemStartDate) {
            $res['courserGroupItemStartDate'] = null !== $this->courserGroupItemStartDate ? $this->courserGroupItemStartDate->toMap() : null;
        }
        if (null !== $this->sectionIndex) {
            $res['sectionIndex'] = $this->sectionIndex;
        }
        if (null !== $this->courserGroupItemEndDate) {
            $res['courserGroupItemEndDate'] = null !== $this->courserGroupItemEndDate ? $this->courserGroupItemEndDate->toMap() : null;
        }
        if (null !== $this->courseType) {
            $res['courseType'] = $this->courseType;
        }
        if (null !== $this->classroomId) {
            $res['classroomId'] = $this->classroomId;
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
        if (isset($map['dayOfWeek'])) {
            $model->dayOfWeek = $map['dayOfWeek'];
        }
        if (isset($map['classPeriodType'])) {
            $model->classPeriodType = $map['classPeriodType'];
        }
        if (isset($map['courserGroupItemStartDate'])) {
            $model->courserGroupItemStartDate = courserGroupItemStartDate::fromMap($map['courserGroupItemStartDate']);
        }
        if (isset($map['sectionIndex'])) {
            if (!empty($map['sectionIndex'])) {
                $model->sectionIndex = $map['sectionIndex'];
            }
        }
        if (isset($map['courserGroupItemEndDate'])) {
            $model->courserGroupItemEndDate = courserGroupItemEndDate::fromMap($map['courserGroupItemEndDate']);
        }
        if (isset($map['courseType'])) {
            $model->courseType = $map['courseType'];
        }
        if (isset($map['classroomId'])) {
            $model->classroomId = $map['classroomId'];
        }

        return $model;
    }
}
