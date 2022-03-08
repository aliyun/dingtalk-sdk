<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUniversityCourseGroupResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryUniversityCourseGroupResponseBody\universityCourseGroupInfo\courserGroupItemModels;
use AlibabaCloud\Tea\Model;

class universityCourseGroupInfo extends Model
{
    /**
     * @description 课程组编码
     *
     * @var string
     */
    public $courseGroupCode;

    /**
     * @description 课程组介绍
     *
     * @var string
     */
    public $courseGroupIntroduce;

    /**
     * @description 课程组名称
     *
     * @var string
     */
    public $courseGroupName;

    /**
     * @description 课程组详细
     *
     * @var courserGroupItemModels[]
     */
    public $courserGroupItemModels;

    /**
     * @description 合作方课程组code
     *
     * @var string
     */
    public $isvCourseGroupCode;

    /**
     * @description 学段编码
     *
     * @var string
     */
    public $periodCode;

    /**
     * @description 学年
     *
     * @var string
     */
    public $schoolYear;

    /**
     * @description 学期
     *
     * @var int
     */
    public $semester;

    /**
     * @description 学科名称
     *
     * @var string
     */
    public $subjectName;
    protected $_name = [
        'courseGroupCode'        => 'courseGroupCode',
        'courseGroupIntroduce'   => 'courseGroupIntroduce',
        'courseGroupName'        => 'courseGroupName',
        'courserGroupItemModels' => 'courserGroupItemModels',
        'isvCourseGroupCode'     => 'isvCourseGroupCode',
        'periodCode'             => 'periodCode',
        'schoolYear'             => 'schoolYear',
        'semester'               => 'semester',
        'subjectName'            => 'subjectName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseGroupCode) {
            $res['courseGroupCode'] = $this->courseGroupCode;
        }
        if (null !== $this->courseGroupIntroduce) {
            $res['courseGroupIntroduce'] = $this->courseGroupIntroduce;
        }
        if (null !== $this->courseGroupName) {
            $res['courseGroupName'] = $this->courseGroupName;
        }
        if (null !== $this->courserGroupItemModels) {
            $res['courserGroupItemModels'] = [];
            if (null !== $this->courserGroupItemModels && \is_array($this->courserGroupItemModels)) {
                $n = 0;
                foreach ($this->courserGroupItemModels as $item) {
                    $res['courserGroupItemModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isvCourseGroupCode) {
            $res['isvCourseGroupCode'] = $this->isvCourseGroupCode;
        }
        if (null !== $this->periodCode) {
            $res['periodCode'] = $this->periodCode;
        }
        if (null !== $this->schoolYear) {
            $res['schoolYear'] = $this->schoolYear;
        }
        if (null !== $this->semester) {
            $res['semester'] = $this->semester;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return universityCourseGroupInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseGroupCode'])) {
            $model->courseGroupCode = $map['courseGroupCode'];
        }
        if (isset($map['courseGroupIntroduce'])) {
            $model->courseGroupIntroduce = $map['courseGroupIntroduce'];
        }
        if (isset($map['courseGroupName'])) {
            $model->courseGroupName = $map['courseGroupName'];
        }
        if (isset($map['courserGroupItemModels'])) {
            if (!empty($map['courserGroupItemModels'])) {
                $model->courserGroupItemModels = [];
                $n                             = 0;
                foreach ($map['courserGroupItemModels'] as $item) {
                    $model->courserGroupItemModels[$n++] = null !== $item ? courserGroupItemModels::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isvCourseGroupCode'])) {
            $model->isvCourseGroupCode = $map['isvCourseGroupCode'];
        }
        if (isset($map['periodCode'])) {
            $model->periodCode = $map['periodCode'];
        }
        if (isset($map['schoolYear'])) {
            $model->schoolYear = $map['schoolYear'];
        }
        if (isset($map['semester'])) {
            $model->semester = $map['semester'];
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }

        return $model;
    }
}
