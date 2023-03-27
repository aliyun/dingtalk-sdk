<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SeachTaskStageRequest extends Model
{
    /**
     * @description 每页返回最大数量。默认10，最大300。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页标，从上一次请求结果中获取。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 任务列表名字。
     *
     * @var string
     */
    public $query;

    /**
     * @description 任务列表 ID 集合，逗号组合。
     *
     * @var string
     */
    public $stageIds;

    /**
     * @description 项目分组ID。
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
