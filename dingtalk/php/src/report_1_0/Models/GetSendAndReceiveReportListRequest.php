<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSendAndReceiveReportListRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1507564800000
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example user123
     *
     * @var string
     */
    public $operationUserId;

    /**
     * @description This parameter is required.
     *
     * @example 1507564800000
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'endTime'         => 'endTime',
        'maxResults'      => 'maxResults',
        'nextToken'       => 'nextToken',
        'operationUserId' => 'operationUserId',
        'startTime'       => 'startTime',
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
        if (null !== $this->operationUserId) {
            $res['operationUserId'] = $this->operationUserId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSendAndReceiveReportListRequest
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
        if (isset($map['operationUserId'])) {
            $model->operationUserId = $map['operationUserId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
