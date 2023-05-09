<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\Tea\Model;

class ListWorkspacesRequest extends Model
{
    /**
     * @example 30
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example next_token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example VIEW_TIME_DESC
     *
     * @var string
     */
    public $orderBy;

    /**
     * @example team_id
     *
     * @var string
     */
    public $teamId;

    /**
     * @example false
     *
     * @var bool
     */
    public $withPermissionRole;
    protected $_name = [
        'maxResults'         => 'maxResults',
        'nextToken'          => 'nextToken',
        'operatorId'         => 'operatorId',
        'orderBy'            => 'orderBy',
        'teamId'             => 'teamId',
        'withPermissionRole' => 'withPermissionRole',
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
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->orderBy) {
            $res['orderBy'] = $this->orderBy;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }
        if (null !== $this->withPermissionRole) {
            $res['withPermissionRole'] = $this->withPermissionRole;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListWorkspacesRequest
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
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['orderBy'])) {
            $model->orderBy = $map['orderBy'];
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }
        if (isset($map['withPermissionRole'])) {
            $model->withPermissionRole = $map['withPermissionRole'];
        }

        return $model;
    }
}
