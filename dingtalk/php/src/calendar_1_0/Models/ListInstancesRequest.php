<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListInstancesRequest extends Model
{
    /**
     * @example 100
     *
     * @var int
     */
    public $maxAttendees;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var string
     */
    public $timeMax;

    /**
     * @var string
     */
    public $timeMin;
    protected $_name = [
        'maxAttendees' => 'maxAttendees',
        'maxResults'   => 'maxResults',
        'nextToken'    => 'nextToken',
        'timeMax'      => 'timeMax',
        'timeMin'      => 'timeMin',
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->timeMax) {
            $res['timeMax'] = $this->timeMax;
        }
        if (null !== $this->timeMin) {
            $res['timeMin'] = $this->timeMin;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListInstancesRequest
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['timeMax'])) {
            $model->timeMax = $map['timeMax'];
        }
        if (isset($map['timeMin'])) {
            $model->timeMin = $map['timeMin'];
        }

        return $model;
    }
}
