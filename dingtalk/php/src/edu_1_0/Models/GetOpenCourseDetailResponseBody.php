<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCourseDetailResponseBody\pushModel;
use AlibabaCloud\Tea\Model;

class GetOpenCourseDetailResponseBody extends Model
{
    /**
     * @description 课程id
     *
     * @var string
     */
    public $courseId;

    /**
     * @description 课程类型: 0-直播 2-视频内容
     *
     * @var int
     */
    public $courseType;

    /**
     * @description 封面图片地址
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @description 课程介绍
     *
     * @var string
     */
    public $introduction;

    /**
     * @description 发布详情model
     *
     * @var pushModel
     */
    public $pushModel;

    /**
     * @description 课程开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 老师的userId
     *
     * @var string
     */
    public $teacherId;

    /**
     * @description 老师名称
     *
     * @var string
     */
    public $teacherName;

    /**
     * @description 课程标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'courseId'     => 'courseId',
        'courseType'   => 'courseType',
        'coverUrl'     => 'coverUrl',
        'introduction' => 'introduction',
        'pushModel'    => 'pushModel',
        'startTime'    => 'startTime',
        'teacherId'    => 'teacherId',
        'teacherName'  => 'teacherName',
        'title'        => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseId) {
            $res['courseId'] = $this->courseId;
        }
        if (null !== $this->courseType) {
            $res['courseType'] = $this->courseType;
        }
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
        }
        if (null !== $this->pushModel) {
            $res['pushModel'] = null !== $this->pushModel ? $this->pushModel->toMap() : null;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->teacherId) {
            $res['teacherId'] = $this->teacherId;
        }
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOpenCourseDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseId'])) {
            $model->courseId = $map['courseId'];
        }
        if (isset($map['courseType'])) {
            $model->courseType = $map['courseType'];
        }
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
        }
        if (isset($map['pushModel'])) {
            $model->pushModel = pushModel::fromMap($map['pushModel']);
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['teacherId'])) {
            $model->teacherId = $map['teacherId'];
        }
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
