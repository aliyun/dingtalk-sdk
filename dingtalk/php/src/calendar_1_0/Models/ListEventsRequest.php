<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListEventsRequest extends Model
{
    /**
     * @description 每个日程的参与者查询个数，默认100，最大100
     *
     * @var int
     */
    public $maxAttendees;

    /**
     * @description 返回的最大日程数，最大100个，默认100个
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 查询翻页token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 是否返回删除事件
     *
     * @var bool
     */
    public $showDeleted;

    /**
     * @description 增量查询token
     *
     * @var string
     */
    public $syncToken;

    /**
     * @description 查询截止时间
     *
     * @var string
     */
    public $timeMax;

    /**
     * @description 查询开始时间
     *
     * @var string
     */
    public $timeMin;
    protected $_name = [
        'maxAttendees' => 'maxAttendees',
        'maxResults'   => 'maxResults',
        'nextToken'    => 'nextToken',
        'showDeleted'  => 'showDeleted',
        'syncToken'    => 'syncToken',
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
        if (null !== $this->showDeleted) {
            $res['showDeleted'] = $this->showDeleted;
        }
        if (null !== $this->syncToken) {
            $res['syncToken'] = $this->syncToken;
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
     * @return ListEventsRequest
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
        if (isset($map['showDeleted'])) {
            $model->showDeleted = $map['showDeleted'];
        }
        if (isset($map['syncToken'])) {
            $model->syncToken = $map['syncToken'];
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
