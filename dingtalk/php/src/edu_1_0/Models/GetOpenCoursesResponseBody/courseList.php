<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCoursesResponseBody;

use AlibabaCloud\Tea\Model;

class courseList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example fdjakl-fdaf-ds
     *
     * @var string
     */
    public $courseId;

    /**
     * @description This parameter is required.
     *
     * @example https://static.dingtalk.com/media/lALPDgCwRt4FagzMi8yZ_153_139.png
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $feedType;

    /**
     * @description This parameter is required.
     *
     * @example https://h5.dingtalk.com/live/video_lesson.htm?feedId=4aa5ter-05d8-4aac-834a-3b3847cf642e&mcnId=7536041420201104593&feedProperty=1&itemId=4aa563e1-05d8-4aac-841a-3b3847cf642e&dd_nav_bgcolor=FF2C2D2F#/live
     *
     * @var string
     */
    public $jumpUrl;

    /**
     * @description This parameter is required.
     *
     * @example 1618369786000
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @example 123124312314
     *
     * @var string
     */
    public $teacherId;

    /**
     * @description This parameter is required.
     *
     * @example 张老师
     *
     * @var string
     */
    public $teacherName;

    /**
     * @description This parameter is required.
     *
     * @example 开学第一课
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'courseId' => 'courseId',
        'coverUrl' => 'coverUrl',
        'feedType' => 'feedType',
        'jumpUrl' => 'jumpUrl',
        'startTime' => 'startTime',
        'teacherId' => 'teacherId',
        'teacherName' => 'teacherName',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseId) {
            $res['courseId'] = $this->courseId;
        }
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }
        if (null !== $this->feedType) {
            $res['feedType'] = $this->feedType;
        }
        if (null !== $this->jumpUrl) {
            $res['jumpUrl'] = $this->jumpUrl;
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
     * @return courseList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseId'])) {
            $model->courseId = $map['courseId'];
        }
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['feedType'])) {
            $model->feedType = $map['feedType'];
        }
        if (isset($map['jumpUrl'])) {
            $model->jumpUrl = $map['jumpUrl'];
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
