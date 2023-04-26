<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRecognizeRecordsRequest extends Model
{
    /**
     * @example 123333
     *
     * @var int
     */
    public $agentId;

    /**
     * @example 1
     *
     * @var int
     */
    public $faceCompareResult;

    /**
     * @example 1667000000
     *
     * @var int
     */
    public $fromTime;

    /**
     * @example 10
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
     * @example 1669000000
     *
     * @var int
     */
    public $toTime;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'agentId'           => 'agentId',
        'faceCompareResult' => 'faceCompareResult',
        'fromTime'          => 'fromTime',
        'maxResults'        => 'maxResults',
        'nextToken'         => 'nextToken',
        'toTime'            => 'toTime',
        'userIds'           => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->faceCompareResult) {
            $res['faceCompareResult'] = $this->faceCompareResult;
        }
        if (null !== $this->fromTime) {
            $res['fromTime'] = $this->fromTime;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->toTime) {
            $res['toTime'] = $this->toTime;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRecognizeRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['faceCompareResult'])) {
            $model->faceCompareResult = $map['faceCompareResult'];
        }
        if (isset($map['fromTime'])) {
            $model->fromTime = $map['fromTime'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['toTime'])) {
            $model->toTime = $map['toTime'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
