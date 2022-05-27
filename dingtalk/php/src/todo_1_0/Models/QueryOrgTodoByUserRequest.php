<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrgTodoByUserRequest extends Model
{
    /**
     * @description 查询从计划完成时间开始
     *
     * @var int
     */
    public $fromDueTime;

    /**
     * @description 待办完成状态。
     *
     * @var bool
     */
    public $isDone;

    /**
     * @description 每页数量。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标。如果一个查询条件一次无法全部返回结果，会返回分页token，下次查询带上该token后会返回后续数据，直到分页token为null表示数据已经全部查询完毕。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 查询目标用户角色类型，执行人 | 创建人 | 参与人，可以同时传多个值。如：[["executor"], ["creator"],["participant"]] 或 [["executor", "creator"]]
     *
     * @var string[][]
     */
    public $roleTypes;

    /**
     * @description 待办标题
     *
     * @var string
     */
    public $subject;

    /**
     * @description 查询到计划完成时间结束
     *
     * @var int
     */
    public $toDueTime;
    protected $_name = [
        'fromDueTime' => 'fromDueTime',
        'isDone'      => 'isDone',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'roleTypes'   => 'roleTypes',
        'subject'     => 'subject',
        'toDueTime'   => 'toDueTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fromDueTime) {
            $res['fromDueTime'] = $this->fromDueTime;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->roleTypes) {
            $res['roleTypes'] = $this->roleTypes;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->toDueTime) {
            $res['toDueTime'] = $this->toDueTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgTodoByUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fromDueTime'])) {
            $model->fromDueTime = $map['fromDueTime'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['roleTypes'])) {
            if (!empty($map['roleTypes'])) {
                $model->roleTypes = $map['roleTypes'];
            }
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['toDueTime'])) {
            $model->toDueTime = $map['toDueTime'];
        }

        return $model;
    }
}
