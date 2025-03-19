<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PageQueryClassCourseResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example {""}
     *
     * @var string
     */
    public $attributes;

    /**
     * @example classId_xxx
     *
     * @var string
     */
    public $classId;

    /**
     * @example 一年级一班
     *
     * @var string
     */
    public $className;

    /**
     * @example room_xxx
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
     * @example 0
     *
     * @var int
     */
    public $classType;

    /**
     * @example ding_xxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example code_xxx
     *
     * @var string
     */
    public $courseCode;

    /**
     * @example 2024-11-21 00:00:00
     *
     * @var string
     */
    public $courseDate;

    /**
     * @example 语文
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
     * @example 2024-11-21 00:00:00
     *
     * @var string
     */
    public $endTime;

    /**
     * @example ISV_XXX
     *
     * @var string
     */
    public $isvCode;

    /**
     * @example courseId
     *
     * @var string
     */
    public $isvCourseId;

    /**
     * @example 备注
     *
     * @var string
     */
    public $memo;

    /**
     * @example 2024
     *
     * @var string
     */
    public $schoolYear;

    /**
     * @example 1
     *
     * @var int
     */
    public $semester;

    /**
     * @example 2024-11-21 00:00:00
     *
     * @var string
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
        'attributes' => 'attributes',
        'classId' => 'classId',
        'className' => 'className',
        'classRoomId' => 'classRoomId',
        'classRoomName' => 'classRoomName',
        'classType' => 'classType',
        'corpId' => 'corpId',
        'courseCode' => 'courseCode',
        'courseDate' => 'courseDate',
        'courseName' => 'courseName',
        'courseWeek' => 'courseWeek',
        'endTime' => 'endTime',
        'isvCode' => 'isvCode',
        'isvCourseId' => 'isvCourseId',
        'memo' => 'memo',
        'schoolYear' => 'schoolYear',
        'semester' => 'semester',
        'startTime' => 'startTime',
        'status' => 'status',
        'teachWeek' => 'teachWeek',
        'timeslotName' => 'timeslotName',
        'timeslotNum' => 'timeslotNum',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->classRoomId) {
            $res['classRoomId'] = $this->classRoomId;
        }
        if (null !== $this->classRoomName) {
            $res['classRoomName'] = $this->classRoomName;
        }
        if (null !== $this->classType) {
            $res['classType'] = $this->classType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
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
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->isvCourseId) {
            $res['isvCourseId'] = $this->isvCourseId;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->schoolYear) {
            $res['schoolYear'] = $this->schoolYear;
        }
        if (null !== $this->semester) {
            $res['semester'] = $this->semester;
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
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['classRoomId'])) {
            $model->classRoomId = $map['classRoomId'];
        }
        if (isset($map['classRoomName'])) {
            $model->classRoomName = $map['classRoomName'];
        }
        if (isset($map['classType'])) {
            $model->classType = $map['classType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
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
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['isvCourseId'])) {
            $model->isvCourseId = $map['isvCourseId'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['schoolYear'])) {
            $model->schoolYear = $map['schoolYear'];
        }
        if (isset($map['semester'])) {
            $model->semester = $map['semester'];
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
