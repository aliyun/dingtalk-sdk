<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class CountTodoTasksRequest extends Model
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
        'category'    => 'category',
        'fromDueTime' => 'fromDueTime',
        'isDone'      => 'isDone',
        'isRecycled'  => 'isRecycled',
        'roleTypes'   => 'roleTypes',
        'toDueTime'   => 'toDueTime',
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
     * @return CountTodoTasksRequest
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
