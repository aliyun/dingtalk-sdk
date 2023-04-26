<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponseBody\result\attendParticipants;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponseBody\result\recordInfos;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponseBody\result\teachingParticipant;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var attendParticipants[]
     */
    public $attendParticipants;

    /**
     * @example false
     *
     * @var bool
     */
    public $canEdit;

    /**
     * @example UvCIp16813006
     *
     * @var string
     */
    public $courseCode;

    /**
     * @example 春天来了
     *
     * @var string
     */
    public $courseName;

    /**
     * @example 1635157800000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example https://pre-live.edu.dingtalk.com/live/showLive?courseCode=UvCIp16813006#/aiclass
     *
     * @var string
     */
    public $liveUrl;

    /**
     * @var recordInfos[]
     */
    public $recordInfos;

    /**
     * @example 1
     *
     * @var int
     */
    public $roomStatus;

    /**
     * @example 1635150600000
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
     * @var teachingParticipant
     */
    public $teachingParticipant;
    protected $_name = [
        'attendParticipants'  => 'attendParticipants',
        'canEdit'             => 'canEdit',
        'courseCode'          => 'courseCode',
        'courseName'          => 'courseName',
        'endTime'             => 'endTime',
        'liveUrl'             => 'liveUrl',
        'recordInfos'         => 'recordInfos',
        'roomStatus'          => 'roomStatus',
        'startTime'           => 'startTime',
        'status'              => 'status',
        'teachingParticipant' => 'teachingParticipant',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendParticipants) {
            $res['attendParticipants'] = [];
            if (null !== $this->attendParticipants && \is_array($this->attendParticipants)) {
                $n = 0;
                foreach ($this->attendParticipants as $item) {
                    $res['attendParticipants'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->canEdit) {
            $res['canEdit'] = $this->canEdit;
        }
        if (null !== $this->courseCode) {
            $res['courseCode'] = $this->courseCode;
        }
        if (null !== $this->courseName) {
            $res['courseName'] = $this->courseName;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->liveUrl) {
            $res['liveUrl'] = $this->liveUrl;
        }
        if (null !== $this->recordInfos) {
            $res['recordInfos'] = [];
            if (null !== $this->recordInfos && \is_array($this->recordInfos)) {
                $n = 0;
                foreach ($this->recordInfos as $item) {
                    $res['recordInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->roomStatus) {
            $res['roomStatus'] = $this->roomStatus;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->teachingParticipant) {
            $res['teachingParticipant'] = null !== $this->teachingParticipant ? $this->teachingParticipant->toMap() : null;
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
        if (isset($map['attendParticipants'])) {
            if (!empty($map['attendParticipants'])) {
                $model->attendParticipants = [];
                $n                         = 0;
                foreach ($map['attendParticipants'] as $item) {
                    $model->attendParticipants[$n++] = null !== $item ? attendParticipants::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['canEdit'])) {
            $model->canEdit = $map['canEdit'];
        }
        if (isset($map['courseCode'])) {
            $model->courseCode = $map['courseCode'];
        }
        if (isset($map['courseName'])) {
            $model->courseName = $map['courseName'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['liveUrl'])) {
            $model->liveUrl = $map['liveUrl'];
        }
        if (isset($map['recordInfos'])) {
            if (!empty($map['recordInfos'])) {
                $model->recordInfos = [];
                $n                  = 0;
                foreach ($map['recordInfos'] as $item) {
                    $model->recordInfos[$n++] = null !== $item ? recordInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['roomStatus'])) {
            $model->roomStatus = $map['roomStatus'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['teachingParticipant'])) {
            $model->teachingParticipant = teachingParticipant::fromMap($map['teachingParticipant']);
        }

        return $model;
    }
}
