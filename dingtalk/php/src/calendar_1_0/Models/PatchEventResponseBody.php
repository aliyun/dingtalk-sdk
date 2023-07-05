<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\attendees;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\end;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\location;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\onlineMeetingInfo;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\organizer;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\recurrence;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\reminders;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\richTextDescription;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\start;
use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody\uiConfigs;
use AlibabaCloud\Tea\Model;

class PatchEventResponseBody extends Model
{
    /**
     * @var attendees[]
     */
    public $attendees;

    /**
     * @var string
     */
    public $createTime;

    /**
     * @var string
     */
    public $description;

    /**
     * @var end
     */
    public $end;

    /**
     * @var string
     */
    public $id;

    /**
     * @var bool
     */
    public $isAllDay;

    /**
     * @var location
     */
    public $location;

    /**
     * @var onlineMeetingInfo
     */
    public $onlineMeetingInfo;

    /**
     * @var organizer
     */
    public $organizer;

    /**
     * @var recurrence
     */
    public $recurrence;

    /**
     * @var reminders[]
     */
    public $reminders;

    /**
     * @var richTextDescription
     */
    public $richTextDescription;

    /**
     * @var start
     */
    public $start;

    /**
     * @var string
     */
    public $summary;

    /**
     * @var uiConfigs[]
     */
    public $uiConfigs;

    /**
     * @var string
     */
    public $updateTime;
    protected $_name = [
        'attendees'           => 'attendees',
        'createTime'          => 'createTime',
        'description'         => 'description',
        'end'                 => 'end',
        'id'                  => 'id',
        'isAllDay'            => 'isAllDay',
        'location'            => 'location',
        'onlineMeetingInfo'   => 'onlineMeetingInfo',
        'organizer'           => 'organizer',
        'recurrence'          => 'recurrence',
        'reminders'           => 'reminders',
        'richTextDescription' => 'richTextDescription',
        'start'               => 'start',
        'summary'             => 'summary',
        'uiConfigs'           => 'uiConfigs',
        'updateTime'          => 'updateTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendees) {
            $res['attendees'] = [];
            if (null !== $this->attendees && \is_array($this->attendees)) {
                $n = 0;
                foreach ($this->attendees as $item) {
                    $res['attendees'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->end) {
            $res['end'] = null !== $this->end ? $this->end->toMap() : null;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isAllDay) {
            $res['isAllDay'] = $this->isAllDay;
        }
        if (null !== $this->location) {
            $res['location'] = null !== $this->location ? $this->location->toMap() : null;
        }
        if (null !== $this->onlineMeetingInfo) {
            $res['onlineMeetingInfo'] = null !== $this->onlineMeetingInfo ? $this->onlineMeetingInfo->toMap() : null;
        }
        if (null !== $this->organizer) {
            $res['organizer'] = null !== $this->organizer ? $this->organizer->toMap() : null;
        }
        if (null !== $this->recurrence) {
            $res['recurrence'] = null !== $this->recurrence ? $this->recurrence->toMap() : null;
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
        if (null !== $this->richTextDescription) {
            $res['richTextDescription'] = null !== $this->richTextDescription ? $this->richTextDescription->toMap() : null;
        }
        if (null !== $this->start) {
            $res['start'] = null !== $this->start ? $this->start->toMap() : null;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->uiConfigs) {
            $res['uiConfigs'] = [];
            if (null !== $this->uiConfigs && \is_array($this->uiConfigs)) {
                $n = 0;
                foreach ($this->uiConfigs as $item) {
                    $res['uiConfigs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PatchEventResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendees'])) {
            if (!empty($map['attendees'])) {
                $model->attendees = [];
                $n                = 0;
                foreach ($map['attendees'] as $item) {
                    $model->attendees[$n++] = null !== $item ? attendees::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['end'])) {
            $model->end = end::fromMap($map['end']);
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isAllDay'])) {
            $model->isAllDay = $map['isAllDay'];
        }
        if (isset($map['location'])) {
            $model->location = location::fromMap($map['location']);
        }
        if (isset($map['onlineMeetingInfo'])) {
            $model->onlineMeetingInfo = onlineMeetingInfo::fromMap($map['onlineMeetingInfo']);
        }
        if (isset($map['organizer'])) {
            $model->organizer = organizer::fromMap($map['organizer']);
        }
        if (isset($map['recurrence'])) {
            $model->recurrence = recurrence::fromMap($map['recurrence']);
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
        if (isset($map['richTextDescription'])) {
            $model->richTextDescription = richTextDescription::fromMap($map['richTextDescription']);
        }
        if (isset($map['start'])) {
            $model->start = start::fromMap($map['start']);
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['uiConfigs'])) {
            if (!empty($map['uiConfigs'])) {
                $model->uiConfigs = [];
                $n                = 0;
                foreach ($map['uiConfigs'] as $item) {
                    $model->uiConfigs[$n++] = null !== $item ? uiConfigs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }

        return $model;
    }
}
