<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTodoTasksRequest extends Model
{
    /**
     * @description 所属分类
     *
     * @var string
     */
    public $category;

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
     * @description 待办回收状态
     *
     * @var bool
     */
    public $isRecycled;

    /**
     * @description 分页游标。如果一个查询条件一次无法全部返回结果，会返回分页token，下次查询带上该token后会返回后续数据，直到分页token为null表示数据已经全部查询完毕。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 排序字段。枚举值 默认为截止时间 dueTime。created | modified | finished | startTime | dueTime 创建时间 | 更新时间 | 完成时间 | 开始时间 | 截止时间
     *
     * @var string
     */
    public $orderBy;

    /**
     * @description 排序方向。枚举值asc | desc 默认 asc
     *
     * @var string
     */
    public $orderDirection;

    /**
     * @description 查询目标用户角色类型，执行人 | 创建人 | 参与人，可以同时传多个值。如：[["executor"], ["creator"],["participant"]] 或 [["executor", "creator"]]
     *
     * @var string[][]
     */
    public $roleTypes;

    /**
     * @description 查询到计划完成时间结束
     *
     * @var int
     */
    public $toDueTime;
    protected $_name = [
        'category'       => 'category',
        'fromDueTime'    => 'fromDueTime',
        'isDone'         => 'isDone',
        'isRecycled'     => 'isRecycled',
        'nextToken'      => 'nextToken',
        'orderBy'        => 'orderBy',
        'orderDirection' => 'orderDirection',
        'roleTypes'      => 'roleTypes',
        'toDueTime'      => 'toDueTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->fromDueTime) {
            $res['fromDueTime'] = $this->fromDueTime;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->isRecycled) {
            $res['isRecycled'] = $this->isRecycled;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->orderBy) {
            $res['orderBy'] = $this->orderBy;
        }
        if (null !== $this->orderDirection) {
            $res['orderDirection'] = $this->orderDirection;
        }
        if (null !== $this->roleTypes) {
            $res['roleTypes'] = $this->roleTypes;
        }
        if (null !== $this->toDueTime) {
            $res['toDueTime'] = $this->toDueTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTodoTasksRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['fromDueTime'])) {
            $model->fromDueTime = $map['fromDueTime'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['isRecycled'])) {
            $model->isRecycled = $map['isRecycled'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['orderBy'])) {
            $model->orderBy = $map['orderBy'];
        }
        if (isset($map['orderDirection'])) {
            $model->orderDirection = $map['orderDirection'];
        }
        if (isset($map['roleTypes'])) {
            if (!empty($map['roleTypes'])) {
                $model->roleTypes = $map['roleTypes'];
            }
        }
        if (isset($map['toDueTime'])) {
            $model->toDueTime = $map['toDueTime'];
        }

        return $model;
    }
}
