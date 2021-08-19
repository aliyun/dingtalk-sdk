<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListEventsViewRequest extends Model
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
    protected $_name = [
        'timeMin'    => 'timeMin',
        'timeMax'    => 'timeMax',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
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
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListEventsViewRequest
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
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
