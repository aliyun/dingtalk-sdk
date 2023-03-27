<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryProjectRequest extends Model
{
    /**
     * @description 分页大小。每页返回最大数量。默认10，最大300。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 项目名字(模糊匹配)。
     *
     * @var string
     */
    public $name;

    /**
     * @description 分页标。供分页使用，下一页token，从当前页结果中获取。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 项目ID集合，逗号分隔。
     *
     * @var string
     */
    public $projectIds;

    /**
     * @description 原始项目ID。
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
