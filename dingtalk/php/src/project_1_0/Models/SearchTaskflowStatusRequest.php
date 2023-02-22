<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchTaskflowStatusRequest extends Model
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
     * @description 模糊查询工作流状态名字。
     *
     * @var string
     */
    public $query;

    /**
     * @description 工作流ID集合，多个以逗号隔开。
     *
     * @var string
     */
    public $tfIds;

    /**
     * @description 工作流状态ID集合，多个以逗号隔开。
     *
     * @var string
     */
    public $tfsIds;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'query'      => 'query',
        'tfIds'      => 'tfIds',
        'tfsIds'     => 'tfsIds',
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
        if (null !== $this->tfIds) {
            $res['tfIds'] = $this->tfIds;
        }
        if (null !== $this->tfsIds) {
            $res['tfsIds'] = $this->tfsIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchTaskflowStatusRequest
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
        if (isset($map['tfIds'])) {
            $model->tfIds = $map['tfIds'];
        }
        if (isset($map['tfsIds'])) {
            $model->tfsIds = $map['tfsIds'];
        }

        return $model;
    }
}
