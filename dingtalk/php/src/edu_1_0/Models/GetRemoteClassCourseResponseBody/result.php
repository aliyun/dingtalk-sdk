<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponseBody\result\attendParticipants;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponseBody\result\teachingParticipant;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 课程code
     *
     * @var string
     */
    public $courseCode;

    /**
     * @description 课程名称
     *
     * @var string
     */
    public $courseName;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 课程状态：0: 未开始；1: 已开始；2: 已结束
     *
     * @var int
     */
    public $status;

    /**
     * @description 课堂当前状态：0: 未进行；1: 进行中
     *
     * @var int
     */
    public $roomStatus;

    /**
     * @description 课程是否可以编辑或删除
     *
     * @var bool
     */
    public $canEdit;

    /**
     * @description 授课设备
     *
     * @var teachingParticipant
     */
    public $teachingParticipant;

    /**
     * @description 听课设备列表
     *
     * @var attendParticipants[]
     */
    public $attendParticipants;
    protected $_name = [
        'courseCode'          => 'courseCode',
        'courseName'          => 'courseName',
        'startTime'           => 'startTime',
        'endTime'             => 'endTime',
        'status'              => 'status',
        'roomStatus'          => 'roomStatus',
        'canEdit'             => 'canEdit',
        'teachingParticipant' => 'teachingParticipant',
        'attendParticipants'  => 'attendParticipants',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
        }
        if (null !== $this->courseName) {
            $res['courseName'] = $this->courseName;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->roomStatus) {
            $res['roomStatus'] = $this->roomStatus;
        }
        if (null !== $this->canEdit) {
            $res['canEdit'] = $this->canEdit;
        }
        if (null !== $this->teachingParticipant) {
            $res['teachingParticipant'] = null !== $this->teachingParticipant ? $this->teachingParticipant->toMap() : null;
        }
        if (null !== $this->attendParticipants) {
            $res['attendParticipants'] = [];
            if (null !== $this->attendParticipants && \is_array($this->attendParticipants)) {
                $n = 0;
                foreach ($this->attendParticipants as $item) {
                    $res['attendParticipants'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }
        if (isset($map['courseName'])) {
            $model->courseName = $map['courseName'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['roomStatus'])) {
            $model->roomStatus = $map['roomStatus'];
        }
        if (isset($map['canEdit'])) {
            $model->canEdit = $map['canEdit'];
        }
        if (isset($map['teachingParticipant'])) {
            $model->teachingParticipant = teachingParticipant::fromMap($map['teachingParticipant']);
        }
        if (isset($map['attendParticipants'])) {
            if (!empty($map['attendParticipants'])) {
                $model->attendParticipants = [];
                $n                         = 0;
                foreach ($map['attendParticipants'] as $item) {
                    $model->attendParticipants[$n++] = null !== $item ? attendParticipants::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
