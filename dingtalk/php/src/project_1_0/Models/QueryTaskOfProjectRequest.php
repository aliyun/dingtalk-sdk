<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTaskOfProjectRequest extends Model
{
    /**
     * @description 每页返回最大数量。默认10，最大500。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 供分页使用，下一页token，从当前页结果中获取。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 查询条件。如：“content ~ 标题1” 表示查询任务标题包含“标题1”的任务；“executor=05178xxxxx” 表示执行者是05178xxxx的任务；”involveMembers NOT IN["061xx","06112xx"] AND executorId=0673xxx AND content~标题2“ 表示查询参与者不是”061xx“和”06112xx“ 并且 执行者是0673xxx 并且 标题类似 ”标题2“的所有任务。
     *
     * @var string
     */
    public $query;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'query'      => 'query',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTaskOfProjectRequest
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

        return $model;
    }
}
