<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchUserTaskRequest extends Model
{
    /**
     * @description 每页返回最大数量。默认10，最大100。
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
     * @description 用户的任务角色, creator,executor,involveMember 中的一个或多个,以 ','拼接。例如：creator,executor。
     *
     * @var string
     */
    public $roleTypes;

    /**
     * @description tql，参考项目内的tql使用说明。
     *
     * @var string
     */
    public $tql;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'roleTypes'  => 'roleTypes',
        'tql'        => 'tql',
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
        if (null !== $this->roleTypes) {
            $res['roleTypes'] = $this->roleTypes;
        }
        if (null !== $this->tql) {
            $res['tql'] = $this->tql;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchUserTaskRequest
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
        if (isset($map['roleTypes'])) {
            $model->roleTypes = $map['roleTypes'];
        }
        if (isset($map['tql'])) {
            $model->tql = $map['tql'];
        }

        return $model;
    }
}
