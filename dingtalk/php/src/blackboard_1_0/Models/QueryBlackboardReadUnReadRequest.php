<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBlackboardReadUnReadRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 49dc87dc1b30cd099b13a
     *
     * @var string
     */
    public $blackboardId;

    /**
     * @description This parameter is required.
     *
     * @example 200
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example xb1dc
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example manager01
     *
     * @var string
     */
    public $operationUserId;
    protected $_name = [
        'blackboardId' => 'blackboardId',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'operationUserId' => 'operationUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->blackboardId) {
            $res['blackboardId'] = $this->blackboardId;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBlackboardReadUnReadRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blackboardId'])) {
            $model->blackboardId = $map['blackboardId'];
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

        return $model;
    }
}
