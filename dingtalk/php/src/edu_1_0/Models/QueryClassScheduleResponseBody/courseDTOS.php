<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody\courseDTOS\classrooms;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryClassScheduleResponseBody\courseDTOS\eduUserModels;
use AlibabaCloud\Tea\Model;

class courseDTOS extends Model
{
    /**
     * @description 课程所在班级id
     *
     * @var int
     */
    public $classId;

    /**
     * @description 课堂列表
     *
     * @var classrooms[]
     */
    public $classrooms;

    /**
     * @description 课程编码
     *
     * @var string
     */
    public $code;

    /**
     * @description 课程组编码
     *
     * @var string
     */
    public $courseGroupCode;

    /**
     * @description 课程封面地址
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @description 创建者组织id
     *
     * @var string
     */
    public $creatorCorpId;

    /**
     * @description 创建者UserId
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 创建者UserName
     *
     * @var string
     */
    public $creatorUserName;

    /**
     * @description 课程参与人列表
     *
     * @var eduUserModels[]
     */
    public $eduUserModels;

    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 课程扩展信息
     *
     * @var string
     */
    public $extInfo;

    /**
     * @description 课程介绍
     *
     * @var string
     */
    public $introduce;

    /**
     * @description 课程名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 课程所在节次序列号
     *
     * @var int
     */
    public $sectionIndex;

    /**
     * @description 课程名称
     *
     * @var string
     */
    public $sectionName;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 课程状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 学科编码
     *
     * @var string
     */
    public $subjectCode;

    /**
     * @description 老师CorpId
     *
     * @var string
     */
    public $teacherCorpId;

    /**
     * @description 老师UserId
     *
     * @var string
     */
    public $teacherUserId;

    /**
     * @description 老师UserName
     *
     * @var string
     */
    public $teacherUserName;
    protected $_name = [
        'classId'         => 'classId',
        'classrooms'      => 'classrooms',
        'code'            => 'code',
        'courseGroupCode' => 'courseGroupCode',
        'coverUrl'        => 'coverUrl',
        'creatorCorpId'   => 'creatorCorpId',
        'creatorUserId'   => 'creatorUserId',
        'creatorUserName' => 'creatorUserName',
        'eduUserModels'   => 'eduUserModels',
        'endTime'         => 'endTime',
        'extInfo'         => 'extInfo',
        'introduce'       => 'introduce',
        'name'            => 'name',
        'sectionIndex'    => 'sectionIndex',
        'sectionName'     => 'sectionName',
        'startTime'       => 'startTime',
        'status'          => 'status',
        'subjectCode'     => 'subjectCode',
        'teacherCorpId'   => 'teacherCorpId',
        'teacherUserId'   => 'teacherUserId',
        'teacherUserName' => 'teacherUserName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->classrooms) {
            $res['classrooms'] = [];
            if (null !== $this->classrooms && \is_array($this->classrooms)) {
                $n = 0;
                foreach ($this->classrooms as $item) {
                    $res['classrooms'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->courseGroupCode) {
            $res['courseGroupCode'] = $this->courseGroupCode;
        }
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }
        if (null !== $this->creatorCorpId) {
            $res['creatorCorpId'] = $this->creatorCorpId;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->creatorUserName) {
            $res['creatorUserName'] = $this->creatorUserName;
        }
        if (null !== $this->eduUserModels) {
            $res['eduUserModels'] = [];
            if (null !== $this->eduUserModels && \is_array($this->eduUserModels)) {
                $n = 0;
                foreach ($this->eduUserModels as $item) {
                    $res['eduUserModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->introduce) {
            $res['introduce'] = $this->introduce;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sectionIndex) {
            $res['sectionIndex'] = $this->sectionIndex;
        }
        if (null !== $this->sectionName) {
            $res['sectionName'] = $this->sectionName;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }
        if (null !== $this->teacherCorpId) {
            $res['teacherCorpId'] = $this->teacherCorpId;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
        }
        if (null !== $this->teacherUserName) {
            $res['teacherUserName'] = $this->teacherUserName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return courseDTOS
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['classrooms'])) {
            if (!empty($map['classrooms'])) {
                $model->classrooms = [];
                $n                 = 0;
                foreach ($map['classrooms'] as $item) {
                    $model->classrooms[$n++] = null !== $item ? classrooms::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['courseGroupCode'])) {
            $model->courseGroupCode = $map['courseGroupCode'];
        }
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['creatorCorpId'])) {
            $model->creatorCorpId = $map['creatorCorpId'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['creatorUserName'])) {
            $model->creatorUserName = $map['creatorUserName'];
        }
        if (isset($map['eduUserModels'])) {
            if (!empty($map['eduUserModels'])) {
                $model->eduUserModels = [];
                $n                    = 0;
                foreach ($map['eduUserModels'] as $item) {
                    $model->eduUserModels[$n++] = null !== $item ? eduUserModels::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['introduce'])) {
            $model->introduce = $map['introduce'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sectionIndex'])) {
            $model->sectionIndex = $map['sectionIndex'];
        }
        if (isset($map['sectionName'])) {
            $model->sectionName = $map['sectionName'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }
        if (isset($map['teacherCorpId'])) {
            $model->teacherCorpId = $map['teacherCorpId'];
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }
        if (isset($map['teacherUserName'])) {
            $model->teacherUserName = $map['teacherUserName'];
        }

        return $model;
    }
}
