<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleResponseBody\scheduleInformation;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleResponseBody\scheduleInformation\scheduleItems\end;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleResponseBody\scheduleInformation\scheduleItems\organizer;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleResponseBody\scheduleInformation\scheduleItems\start;
use AlibabaCloud\Tea\Model;

class scheduleItems extends Model
{
    /**
     * @var end
     */
    public $end;

    /**
     * @var string
     */
    public $eventId;

    /**
     * @var organizer
     */
    public $organizer;

    /**
     * @var start
     */
    public $start;

    /**
     * @example BUSY
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'end'       => 'end',
        'eventId'   => 'eventId',
        'organizer' => 'organizer',
        'start'     => 'start',
        'status'    => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->end) {
            $res['end'] = null !== $this->end ? $this->end->toMap() : null;
        }
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }
        if (null !== $this->organizer) {
            $res['organizer'] = null !== $this->organizer ? $this->organizer->toMap() : null;
        }
        if (null !== $this->start) {
            $res['start'] = null !== $this->start ? $this->start->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return scheduleItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['end'])) {
            $model->end = end::fromMap($map['end']);
        }
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }
        if (isset($map['organizer'])) {
            $model->organizer = organizer::fromMap($map['organizer']);
        }
        if (isset($map['start'])) {
            $model->start = start::fromMap($map['start']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
