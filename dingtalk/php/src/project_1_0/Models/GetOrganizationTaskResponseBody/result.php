<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationTaskResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 父任务id
     *
     * @var string[]
     */
    public $ancestorIds;

    /**
     * @description 任务标题
     *
     * @var string
     */
    public $content;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $created;

    /**
     * @description 创建者id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 任务截止时间
     *
     * @var string
     */
    public $dueDate;

    /**
     * @description 执行者id
     *
     * @var string
     */
    public $executorId;

    /**
     * @description 参与者列表
     *
     * @var string[]
     */
    public $involveMembers;

    /**
     * @description 任务是否已删除
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 任务是否已完成
     *
     * @var bool
     */
    public $isDone;

    /**
     * @description 任务自定义标记
     *
     * @var string[]
     */
    public $labels;

    /**
     * @description 任务备注
     *
     * @var string
     */
    public $note;

    /**
     * @description 优先级【-10,0,1,2】中选一个
     *
     * @var int
     */
    public $priority;

    /**
     * @description 任务开始时间
     *
     * @var string
     */
    public $startDate;

    /**
     * @description 任务id
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 更新时间
     *
     * @var string
     */
    public $updated;

    /**
     * @description 任务可见性。involves：仅参与者可见。members:所有人可见
     *
     * @var string
     */
    public $visible;
    protected $_name = [
        'ancestorIds'    => 'ancestorIds',
        'content'        => 'content',
        'created'        => 'created',
        'creatorId'      => 'creatorId',
        'dueDate'        => 'dueDate',
        'executorId'     => 'executorId',
        'involveMembers' => 'involveMembers',
        'isDeleted'      => 'isDeleted',
        'isDone'         => 'isDone',
        'labels'         => 'labels',
        'note'           => 'note',
        'priority'       => 'priority',
        'startDate'      => 'startDate',
        'taskId'         => 'taskId',
        'updated'        => 'updated',
        'visible'        => 'visible',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ancestorIds) {
            $res['ancestorIds'] = $this->ancestorIds;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->dueDate) {
            $res['dueDate'] = $this->dueDate;
        }
        if (null !== $this->executorId) {
            $res['executorId'] = $this->executorId;
        }
        if (null !== $this->involveMembers) {
            $res['involveMembers'] = $this->involveMembers;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->labels) {
            $res['labels'] = $this->labels;
        }
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }
        if (null !== $this->visible) {
            $res['visible'] = $this->visible;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ancestorIds'])) {
            if (!empty($map['ancestorIds'])) {
                $model->ancestorIds = $map['ancestorIds'];
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['dueDate'])) {
            $model->dueDate = $map['dueDate'];
        }
        if (isset($map['executorId'])) {
            $model->executorId = $map['executorId'];
        }
        if (isset($map['involveMembers'])) {
            if (!empty($map['involveMembers'])) {
                $model->involveMembers = $map['involveMembers'];
            }
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['labels'])) {
            if (!empty($map['labels'])) {
                $model->labels = $map['labels'];
            }
        }
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }
        if (isset($map['visible'])) {
            $model->visible = $map['visible'];
        }

        return $model;
    }
}
