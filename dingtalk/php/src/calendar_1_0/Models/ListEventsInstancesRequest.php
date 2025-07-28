<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListEventsInstancesRequest extends Model
{
    /**
     * @example 100
     *
     * @var int
     */
    public $maxAttendees;

    /**
     * @example 100
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @example cnNTbW1YbxxxxdEgvdlQrQT09
     *
     * @var string
     */
    public $seriesMasterId;

    /**
     * @var string
     */
    public $startRecurrenceId;
    protected $_name = [
        'maxAttendees' => 'maxAttendees',
        'maxResults' => 'maxResults',
        'seriesMasterId' => 'seriesMasterId',
        'startRecurrenceId' => 'startRecurrenceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxAttendees) {
            $res['maxAttendees'] = $this->maxAttendees;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->seriesMasterId) {
            $res['seriesMasterId'] = $this->seriesMasterId;
        }
        if (null !== $this->startRecurrenceId) {
            $res['startRecurrenceId'] = $this->startRecurrenceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListEventsInstancesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxAttendees'])) {
            $model->maxAttendees = $map['maxAttendees'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['seriesMasterId'])) {
            $model->seriesMasterId = $map['seriesMasterId'];
        }
        if (isset($map['startRecurrenceId'])) {
            $model->startRecurrenceId = $map['startRecurrenceId'];
        }

        return $model;
    }
}
