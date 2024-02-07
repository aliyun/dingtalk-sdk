<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail\meeting\alarm;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail\meeting\attendees;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail\meeting\organizer;
use AlibabaCloud\Tea\Model;

class meeting extends Model
{
    /**
     * @var alarm
     */
    public $alarm;

    /**
     * @var attendees[]
     */
    public $attendees;

    /**
     * @example 会议描述
     *
     * @var string
     */
    public $description;

    /**
     * @example 1701692590881
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 会议室
     *
     * @var string
     */
    public $location;

    /**
     * @example REQUEST
     *
     * @var string
     */
    public $method;

    /**
     * @var organizer
     */
    public $organizer;

    /**
     * @example 1
     *
     * @var int
     */
    public $sequence;

    /**
     * @example 1701692590881
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 测试会议
     *
     * @var string
     */
    public $summary;

    /**
     * @example uuidssssss
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'alarm'       => 'alarm',
        'attendees'   => 'attendees',
        'description' => 'description',
        'endTime'     => 'endTime',
        'location'    => 'location',
        'method'      => 'method',
        'organizer'   => 'organizer',
        'sequence'    => 'sequence',
        'startTime'   => 'startTime',
        'summary'     => 'summary',
        'uuid'        => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alarm) {
            $res['alarm'] = null !== $this->alarm ? $this->alarm->toMap() : null;
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
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->method) {
            $res['method'] = $this->method;
        }
        if (null !== $this->organizer) {
            $res['organizer'] = null !== $this->organizer ? $this->organizer->toMap() : null;
        }
        if (null !== $this->sequence) {
            $res['sequence'] = $this->sequence;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return meeting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alarm'])) {
            $model->alarm = alarm::fromMap($map['alarm']);
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
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['method'])) {
            $model->method = $map['method'];
        }
        if (isset($map['organizer'])) {
            $model->organizer = organizer::fromMap($map['organizer']);
        }
        if (isset($map['sequence'])) {
            $model->sequence = $map['sequence'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
