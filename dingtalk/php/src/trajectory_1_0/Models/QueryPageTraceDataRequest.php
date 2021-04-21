<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPageTraceDataRequest extends Model
{
    /**
     * @description traceId
     *
     * @var string
     */
    public $traceId;

    /**
     * @description 起始位置
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 查询数量
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 终止时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 员工ID
     *
     * @var string
     */
    public $staffId;
    protected $_name = [
        'traceId'    => 'traceId',
        'nextToken'  => 'nextToken',
        'maxResults' => 'maxResults',
        'startTime'  => 'startTime',
        'endTime'    => 'endTime',
        'staffId'    => 'staffId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->traceId) {
            $res['traceId'] = $this->traceId;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
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
        if (isset($map['traceId'])) {
            $model->traceId = $map['traceId'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
