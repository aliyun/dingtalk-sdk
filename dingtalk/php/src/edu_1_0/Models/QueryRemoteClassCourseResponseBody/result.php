<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseResponseBody\result\attendParticipants;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryRemoteClassCourseResponseBody\result\teachingParticipant;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var attendParticipants[]
     */
    public $attendParticipants;

    /**
     * @var bool
     */
    public $canEdit;

    /**
     * @var string
     */
    public $courseCode;

    /**
     * @var string
     */
    public $courseName;

    /**
     * @var string[]
     */
    public $courseWays;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var int
     */
    public $startTime;

    /**
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
        'courseWays'          => 'courseWays',
        'endTime'             => 'endTime',
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
        if (null !== $this->courseWays) {
            $res['courseWays'] = $this->courseWays;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
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
        if (isset($map['courseWays'])) {
            if (!empty($map['courseWays'])) {
                $model->courseWays = $map['courseWays'];
            }
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
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
