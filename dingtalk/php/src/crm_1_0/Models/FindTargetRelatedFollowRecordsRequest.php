<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class FindTargetRelatedFollowRecordsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example customerId
     *
     * @var string
     */
    public $followTargetDataId;

    /**
     * @description This parameter is required.
     *
     * @example customer
     *
     * @var string
     */
    public $followTargetType;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 1
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'followTargetDataId' => 'followTargetDataId',
        'followTargetType'   => 'followTargetType',
        'maxResults'         => 'maxResults',
        'nextToken'          => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->followTargetDataId) {
            $res['followTargetDataId'] = $this->followTargetDataId;
        }
        if (null !== $this->followTargetType) {
            $res['followTargetType'] = $this->followTargetType;
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
     * @return FindTargetRelatedFollowRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['followTargetDataId'])) {
            $model->followTargetDataId = $map['followTargetDataId'];
        }
        if (isset($map['followTargetType'])) {
            $model->followTargetType = $map['followTargetType'];
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
