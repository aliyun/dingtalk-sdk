<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPageTraceDataRequest extends Model
{
    /**
     * @var int
     */
    public $endTime;

    /**
     * @example 100
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 0
     *
     * @var int
     */
    public $nextToken;

    /**
     * @var string
     */
    public $staffId;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var string
     */
    public $traceId;
    protected $_name = [
        'endTime'    => 'endTime',
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'staffId'    => 'staffId',
        'startTime'  => 'startTime',
        'traceId'    => 'traceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->traceId) {
            $res['traceId'] = $this->traceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPageTraceDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['traceId'])) {
            $model->traceId = $map['traceId'];
        }

        return $model;
    }
}
