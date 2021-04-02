<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponseBody\attendees;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponseBody\end;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponseBody\location;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponseBody\onlineMeetingInfo;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponseBody\organizer;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponseBody\recurrence;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponseBody\reminders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventResponseBody\start;
use AlibabaCloud\Tea\Model;

class CreateEventResponseBody extends Model
{
    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $summary;

    /**
     * @var string
     */
    public $description;

    /**
     * @description 日程开始时间
     *
     * @var start
     */
    public $start;

    /**
     * @var end
     */
    public $end;

    /**
     * @var bool
     */
    public $isAllDay;

    /**
     * @var recurrence
     */
    public $recurrence;

    /**
     * @var attendees[]
     */
    public $attendees;

    /**
     * @var organizer
     */
    public $organizer;

    /**
     * @var location
     */
    public $location;

    /**
     * @var reminders[]
     */
    public $reminders;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 更新时间
     *
     * @var string
     */
    public $updateTime;

    /**
     * @var onlineMeetingInfo
     */
    public $onlineMeetingInfo;
    protected $_name = [
        'id'                => 'id',
        'summary'           => 'summary',
        'description'       => 'description',
        'start'             => 'start',
        'end'               => 'end',
        'isAllDay'          => 'isAllDay',
        'recurrence'        => 'recurrence',
        'attendees'         => 'attendees',
        'organizer'         => 'organizer',
        'location'          => 'location',
        'reminders'         => 'reminders',
        'createTime'        => 'createTime',
        'updateTime'        => 'updateTime',
        'onlineMeetingInfo' => 'onlineMeetingInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->start) {
            $res['start'] = null !== $this->start ? $this->start->toMap() : null;
        }
        if (null !== $this->end) {
            $res['end'] = null !== $this->end ? $this->end->toMap() : null;
        }
        if (null !== $this->isAllDay) {
            $res['isAllDay'] = $this->isAllDay;
        }
        if (null !== $this->recurrence) {
            $res['recurrence'] = null !== $this->recurrence ? $this->recurrence->toMap() : null;
        }
        if (null !== $this->attendees) {
            $res['attendees'] = [];
            if (null !== $this->attendees && \is_array($this->attendees)) {
                $n = 0;
                foreach ($this->attendees as $item) {
                    $res['attendees'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->organizer) {
            $res['organizer'] = null !== $this->organizer ? $this->organizer->toMap() : null;
        }
        if (null !== $this->location) {
            $res['location'] = null !== $this->location ? $this->location->toMap() : null;
        }
        if (null !== $this->reminders) {
            $res['reminders'] = [];
            if (null !== $this->reminders && \is_array($this->reminders)) {
                $n = 0;
                foreach ($this->reminders as $item) {
                    $res['reminders'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }
        if (null !== $this->onlineMeetingInfo) {
            $res['onlineMeetingInfo'] = null !== $this->onlineMeetingInfo ? $this->onlineMeetingInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateEventResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['start'])) {
            $model->start = start::fromMap($map['start']);
        }
        if (isset($map['end'])) {
            $model->end = end::fromMap($map['end']);
        }
        if (isset($map['isAllDay'])) {
            $model->isAllDay = $map['isAllDay'];
        }
        if (isset($map['recurrence'])) {
            $model->recurrence = recurrence::fromMap($map['recurrence']);
        }
        if (isset($map['attendees'])) {
            if (!empty($map['attendees'])) {
                $model->attendees = [];
                $n                = 0;
                foreach ($map['attendees'] as $item) {
                    $model->attendees[$n++] = null !== $item ? attendees::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['organizer'])) {
            $model->organizer = organizer::fromMap($map['organizer']);
        }
        if (isset($map['location'])) {
            $model->location = location::fromMap($map['location']);
        }
        if (isset($map['reminders'])) {
            if (!empty($map['reminders'])) {
                $model->reminders = [];
                $n                = 0;
                foreach ($map['reminders'] as $item) {
                    $model->reminders[$n++] = null !== $item ? reminders::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }
        if (isset($map['onlineMeetingInfo'])) {
            $model->onlineMeetingInfo = onlineMeetingInfo::fromMap($map['onlineMeetingInfo']);
        }

        return $model;
    }
}
