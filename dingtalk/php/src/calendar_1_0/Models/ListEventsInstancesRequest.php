<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListEventsInstancesRequest extends Model
{
    /**
     * @description listInstances每个日程的参与者查询个数，默认100，最大100。
     *
     * @var int
     */
    public $maxAttendees;

    /**
     * @description listInstances返回的最大日程数，最大100个，默认100个。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 循环主日程id。
     *
     * @var string
     */
    public $seriesMasterId;

    /**
     * @description 大于等于次序列id的所有实例
     *
     * @var string
     */
    public $startRecurrenceId;
    protected $_name = [
        'maxAttendees'      => 'maxAttendees',
        'maxResults'        => 'maxResults',
        'seriesMasterId'    => 'seriesMasterId',
        'startRecurrenceId' => 'startRecurrenceId',
    ];

    public function validate()
    {
    }

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
