<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryProjectRequest extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 测试项目
     *
     * @var string
     */
    public $name;

    /**
     * @example f279e812xxxxxx
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $projectIds;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $sourceId;
    protected $_name = [
        'maxResults' => 'maxResults',
        'name'       => 'name',
        'nextToken'  => 'nextToken',
        'projectIds' => 'projectIds',
        'sourceId'   => 'sourceId',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->projectIds) {
            $res['projectIds'] = $this->projectIds;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryProjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['projectIds'])) {
            $model->projectIds = $map['projectIds'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }

        return $model;
    }
}
