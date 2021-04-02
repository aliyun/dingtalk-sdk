<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListEventsRequest extends Model
{
    /**
     * @description 查询开始时间
     *
     * @var string
     */
    public $timeMin;

    /**
     * @description 查询截止时间
     *
     * @var string
     */
    public $timeMax;

    /**
     * @description 是否返回删除事件
     *
     * @var bool
     */
    public $showDeleted;

    /**
     * @description 查询返回结果数
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
     * @description 增量查询token
     *
     * @var string
     */
    public $syncToken;
    protected $_name = [
        'timeMin'     => 'timeMin',
        'timeMax'     => 'timeMax',
        'showDeleted' => 'showDeleted',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'syncToken'   => 'syncToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->timeMin) {
            $res['timeMin'] = $this->timeMin;
        }
        if (null !== $this->timeMax) {
            $res['timeMax'] = $this->timeMax;
        }
        if (null !== $this->showDeleted) {
            $res['showDeleted'] = $this->showDeleted;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->syncToken) {
            $res['syncToken'] = $this->syncToken;
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
        if (isset($map['timeMin'])) {
            $model->timeMin = $map['timeMin'];
        }
        if (isset($map['timeMax'])) {
            $model->timeMax = $map['timeMax'];
        }
        if (isset($map['showDeleted'])) {
            $model->showDeleted = $map['showDeleted'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['syncToken'])) {
            $model->syncToken = $map['syncToken'];
        }

        return $model;
    }
}
