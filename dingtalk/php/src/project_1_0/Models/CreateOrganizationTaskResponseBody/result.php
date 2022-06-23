<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskResponseBody\result\creator;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskResponseBody\result\executor;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskResponseBody\result\involvers;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 父任务Id
     *
     * @var string[]
     */
    public $ancestorIds;

    /**
     * @description 附件数量
     *
     * @var int
     */
    public $attachmentsCount;

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
     * @description 创建者
     *
     * @var creator
     */
    public $creator;

    /**
     * @description 创建者id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 任务截止日期
     *
     * @var string
     */
    public $dueDate;

    /**
     * @description 执行者
     *
     * @var executor
     */
    public $executor;

    /**
     * @description 执行者id
     *
     * @var string
     */
    public $executorId;

    /**
     * @description 是否有提醒
     *
     * @var bool
     */
    public $hasReminder;

    /**
     * @description 任务id
     *
     * @var string
     */
    public $id;

    /**
     * @description 参与者id列表
     *
     * @var string[]
     */
    public $involveMembers;

    /**
     * @description 参与者列表
     *
     * @var involvers[]
     */
    public $involvers;

    /**
     * @description 是否删除
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 是否完成
     *
     * @var string
     */
    public $isDone;

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
        'ancestorIds'      => 'ancestorIds',
        'attachmentsCount' => 'attachmentsCount',
        'content'          => 'content',
        'created'          => 'created',
        'creator'          => 'creator',
        'creatorId'        => 'creatorId',
        'dueDate'          => 'dueDate',
        'executor'         => 'executor',
        'executorId'       => 'executorId',
        'hasReminder'      => 'hasReminder',
        'id'               => 'id',
        'involveMembers'   => 'involveMembers',
        'involvers'        => 'involvers',
        'isDeleted'        => 'isDeleted',
        'isDone'           => 'isDone',
        'note'             => 'note',
        'priority'         => 'priority',
        'updated'          => 'updated',
        'visible'          => 'visible',
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
        if (null !== $this->attachmentsCount) {
            $res['attachmentsCount'] = $this->attachmentsCount;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->dueDate) {
            $res['dueDate'] = $this->dueDate;
        }
        if (null !== $this->executor) {
            $res['executor'] = null !== $this->executor ? $this->executor->toMap() : null;
        }
        if (null !== $this->executorId) {
            $res['executorId'] = $this->executorId;
        }
        if (null !== $this->hasReminder) {
            $res['hasReminder'] = $this->hasReminder;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->involveMembers) {
            $res['involveMembers'] = $this->involveMembers;
        }
        if (null !== $this->involvers) {
            $res['involvers'] = [];
            if (null !== $this->involvers && \is_array($this->involvers)) {
                $n = 0;
                foreach ($this->involvers as $item) {
                    $res['involvers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
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
        if (isset($map['attachmentsCount'])) {
            $model->attachmentsCount = $map['attachmentsCount'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creator'])) {
            $model->creator = creator::fromMap($map['creator']);
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['dueDate'])) {
            $model->dueDate = $map['dueDate'];
        }
        if (isset($map['executor'])) {
            $model->executor = executor::fromMap($map['executor']);
        }
        if (isset($map['executorId'])) {
            $model->executorId = $map['executorId'];
        }
        if (isset($map['hasReminder'])) {
            $model->hasReminder = $map['hasReminder'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['involveMembers'])) {
            if (!empty($map['involveMembers'])) {
                $model->involveMembers = $map['involveMembers'];
            }
        }
        if (isset($map['involvers'])) {
            if (!empty($map['involvers'])) {
                $model->involvers = [];
                $n                = 0;
                foreach ($map['involvers'] as $item) {
                    $model->involvers[$n++] = null !== $item ? involvers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
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
