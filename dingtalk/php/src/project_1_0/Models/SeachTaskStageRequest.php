<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SeachTaskStageRequest extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example f279e812xxxxxx
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example 自定义列1
     *
     * @var string
     */
    public $query;

    /**
     * @example 60a2187eb72xxxxxxx,60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $stageIds;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $taskListId;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'query'      => 'query',
        'stageIds'   => 'stageIds',
        'taskListId' => 'taskListId',
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
        if (null !== $this->query) {
            $res['query'] = $this->query;
        }
        if (null !== $this->stageIds) {
            $res['stageIds'] = $this->stageIds;
        }
        if (null !== $this->taskListId) {
            $res['taskListId'] = $this->taskListId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SeachTaskStageRequest
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
        if (isset($map['query'])) {
            $model->query = $map['query'];
        }
        if (isset($map['stageIds'])) {
            $model->stageIds = $map['stageIds'];
        }
        if (isset($map['taskListId'])) {
            $model->taskListId = $map['taskListId'];
        }

        return $model;
    }
}
