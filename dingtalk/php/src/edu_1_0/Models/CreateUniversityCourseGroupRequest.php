<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest\courserGroupItemModels;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateUniversityCourseGroupRequest\teacherInfos;
use AlibabaCloud\Tea\Model;

class CreateUniversityCourseGroupRequest extends Model
{
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
     * @description 课程详细
     *
     * @var courserGroupItemModels[]
     */
    public $courserGroupItemModels;

    /**
     * @description 扩展参数
     *
     * @var string
     */
    public $ext;

    /**
     * @description 合作方课程组code
     *
     * @var string
     */
    public $isvCourseGroupCode;

    /**
     * @description 学段code
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
     * @description 学科
     *
     * @var string
     */
    public $subjectName;

    /**
     * @description 教师信息
     *
     * @var teacherInfos[]
     */
    public $teacherInfos;

    /**
     * @description 操作人
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'courseGroupIntroduce'   => 'courseGroupIntroduce',
        'courseGroupName'        => 'courseGroupName',
        'courserGroupItemModels' => 'courserGroupItemModels',
        'ext'                    => 'ext',
        'isvCourseGroupCode'     => 'isvCourseGroupCode',
        'periodCode'             => 'periodCode',
        'schoolYear'             => 'schoolYear',
        'semester'               => 'semester',
        'subjectName'            => 'subjectName',
        'teacherInfos'           => 'teacherInfos',
        'opUserId'               => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
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
        if (null !== $this->teacherInfos) {
            $res['teacherInfos'] = [];
            if (null !== $this->teacherInfos && \is_array($this->teacherInfos)) {
                $n = 0;
                foreach ($this->teacherInfos as $item) {
                    $res['teacherInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateUniversityCourseGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
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
        if (isset($map['teacherInfos'])) {
            if (!empty($map['teacherInfos'])) {
                $model->teacherInfos = [];
                $n                   = 0;
                foreach ($map['teacherInfos'] as $item) {
                    $model->teacherInfos[$n++] = null !== $item ? teacherInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
