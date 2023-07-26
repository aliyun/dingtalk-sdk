<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCustomerTaskUserDetailRequest extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 8888
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example 8888
     *
     * @var string
     */
    public $openBatchTaskId;

    /**
     * @example 8888
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @var string[]
     */
    public $receiverUnionIds;
    protected $_name = [
        'maxResults'       => 'maxResults',
        'nextToken'        => 'nextToken',
        'openBatchTaskId'  => 'openBatchTaskId',
        'openTeamId'       => 'openTeamId',
        'receiverUnionIds' => 'receiverUnionIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openBatchTaskId) {
            $res['openBatchTaskId'] = $this->openBatchTaskId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->receiverUnionIds) {
            $res['receiverUnionIds'] = $this->receiverUnionIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCustomerTaskUserDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openBatchTaskId'])) {
            $model->openBatchTaskId = $map['openBatchTaskId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['receiverUnionIds'])) {
            if (!empty($map['receiverUnionIds'])) {
                $model->receiverUnionIds = $map['receiverUnionIds'];
            }
        }

        return $model;
    }
}
