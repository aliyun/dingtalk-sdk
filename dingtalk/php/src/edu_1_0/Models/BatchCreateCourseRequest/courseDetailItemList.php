<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateCourseRequest;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateCourseRequest\courseDetailItemList\teacherList;
use AlibabaCloud\Tea\Model;

class courseDetailItemList extends Model
{
    /**
     * @example {""}
     *
     * @var string
     */
    public $attributes;

    /**
     * @example classroom_xxx
     *
     * @var string
     */
    public $classRoomId;

    /**
     * @example 音乐教室
     *
     * @var string
     */
    public $classRoomName;

    /**
     * @example courseCode_xxx
     *
     * @var string
     */
    public $courseCode;

    /**
     * @example 0
     *
     * @var int
     */
    public $courseDate;

    /**
     * @example 语言
     *
     * @var string
     */
    public $courseName;

    /**
     * @example 1
     *
     * @var int
     */
    public $courseWeek;

    /**
     * @example 0
     *
     * @var int
     */
    public $endTime;

    /**
     * @example courseId_xxx
     *
     * @var string
     */
    public $isvCourseId;

    /**
     * @example memo_xxx
     *
     * @var string
     */
    public $memo;

    /**
     * @example 0
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example 1
     *
     * @var int
     */
    public $teachWeek;

    /**
     * @var teacherList[]
     */
    public $teacherList;

    /**
     * @example 第一节
     *
     * @var string
     */
    public $timeslotName;

    /**
     * @example 1
     *
     * @var int
     */
    public $timeslotNum;

    /**
     * @example 1
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'attributes'    => 'attributes',
        'classRoomId'   => 'classRoomId',
        'classRoomName' => 'classRoomName',
        'courseCode'    => 'courseCode',
        'courseDate'    => 'courseDate',
        'courseName'    => 'courseName',
        'courseWeek'    => 'courseWeek',
        'endTime'       => 'endTime',
        'isvCourseId'   => 'isvCourseId',
        'memo'          => 'memo',
        'startTime'     => 'startTime',
        'status'        => 'status',
        'teachWeek'     => 'teachWeek',
        'teacherList'   => 'teacherList',
        'timeslotName'  => 'timeslotName',
        'timeslotNum'   => 'timeslotNum',
        'type'          => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }
        if (null !== $this->classRoomId) {
            $res['classRoomId'] = $this->classRoomId;
        }
        if (null !== $this->classRoomName) {
            $res['classRoomName'] = $this->classRoomName;
        }
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
        }
        if (null !== $this->courseDate) {
            $res['courseDate'] = $this->courseDate;
        }
        if (null !== $this->courseName) {
            $res['courseName'] = $this->courseName;
        }
        if (null !== $this->courseWeek) {
            $res['courseWeek'] = $this->courseWeek;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->isvCourseId) {
            $res['isvCourseId'] = $this->isvCourseId;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->teachWeek) {
            $res['teachWeek'] = $this->teachWeek;
        }
        if (null !== $this->teacherList) {
            $res['teacherList'] = [];
            if (null !== $this->teacherList && \is_array($this->teacherList)) {
                $n = 0;
                foreach ($this->teacherList as $item) {
                    $res['teacherList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->timeslotName) {
            $res['timeslotName'] = $this->timeslotName;
        }
        if (null !== $this->timeslotNum) {
            $res['timeslotNum'] = $this->timeslotNum;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return courseDetailItemList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
        if (isset($map['classRoomId'])) {
            $model->classRoomId = $map['classRoomId'];
        }
        if (isset($map['classRoomName'])) {
            $model->classRoomName = $map['classRoomName'];
        }
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }
        if (isset($map['courseDate'])) {
            $model->courseDate = $map['courseDate'];
        }
        if (isset($map['courseName'])) {
            $model->courseName = $map['courseName'];
        }
        if (isset($map['courseWeek'])) {
            $model->courseWeek = $map['courseWeek'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['isvCourseId'])) {
            $model->isvCourseId = $map['isvCourseId'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['teachWeek'])) {
            $model->teachWeek = $map['teachWeek'];
        }
        if (isset($map['teacherList'])) {
            if (!empty($map['teacherList'])) {
                $model->teacherList = [];
                $n                  = 0;
                foreach ($map['teacherList'] as $item) {
                    $model->teacherList[$n++] = null !== $item ? teacherList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['timeslotName'])) {
            $model->timeslotName = $map['timeslotName'];
        }
        if (isset($map['timeslotNum'])) {
            $model->timeslotNum = $map['timeslotNum'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
