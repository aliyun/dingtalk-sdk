<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\Tea\Model;

class ListNodesRequest extends Model
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
     * @example parent_node_id
     *
     * @var string
     */
    public $parentNodeId;

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
        'parentNodeId'       => 'parentNodeId',
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
        if (null !== $this->parentNodeId) {
            $res['parentNodeId'] = $this->parentNodeId;
        }
        if (null !== $this->withPermissionRole) {
            $res['withPermissionRole'] = $this->withPermissionRole;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListNodesRequest
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
        if (isset($map['parentNodeId'])) {
            $model->parentNodeId = $map['parentNodeId'];
        }
        if (isset($map['withPermissionRole'])) {
            $model->withPermissionRole = $map['withPermissionRole'];
        }

        return $model;
    }
}
