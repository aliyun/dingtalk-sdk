<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTaskByIdsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTaskByIdsResponseBody\result\customfields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 任务完成时间(UTC)。
     *
     * @var string
     */
    public $accomplishTime;

    /**
     * @description 祖先任务ID列表。
     *
     * @var string[]
     */
    public $ancestorIds;

    /**
     * @description 任务标题。
     *
     * @var string
     */
    public $content;

    /**
     * @description 创建时间(UTC)。
     *
     * @var string
     */
    public $created;

    /**
     * @description 创建人ID。
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 自定义字段值集合。
     *
     * @var customfields[]
     */
    public $customfields;

    /**
     * @description 任务截止时间(UTC)。
     *
     * @var string
     */
    public $dueDate;

    /**
     * @description 执行人ID。
     *
     * @var string
     */
    public $executorId;

    /**
     * @description 参与者ID集合。
     *
     * @var string[]
     */
    public $involveMembers;

    /**
     * @description 是否任务放入回收站。
     *
     * @var bool
     */
    public $isArchived;

    /**
     * @description 是否任务已完成。
     *
     * @var bool
     */
    public $isDone;

    /**
     * @description 任务备注。
     *
     * @var string
     */
    public $note;

    /**
     * @description 父任务ID。
     *
     * @var string
     */
    public $parentTaskId;

    /**
     * @description 任务优先级。
     *
     * @var int
     */
    public $priority;

    /**
     * @description 项目ID。
     *
     * @var string
     */
    public $projectId;

    /**
     * @description 重复规则列表。
     *
     * @var string[]
     */
    public $recurrence;

    /**
     * @description 任务类型ID。
     *
     * @var string
     */
    public $scenariofieldconfigId;

    /**
     * @description 迭代ID。
     *
     * @var string
     */
    public $sprintId;

    /**
     * @description 任务列ID。
     *
     * @var string
     */
    public $stageId;

    /**
     * @description 任务开始时间(UTC)。
     *
     * @var string
     */
    public $startDate;

    /**
     * @description StoryPoint。
     *
     * @var string
     */
    public $storyPoint;

    /**
     * @description 标签ID集合。
     *
     * @var string[]
     */
    public $tagIds;

    /**
     * @description 任务ID。
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 任务分组ID。
     *
     * @var string
     */
    public $taskListId;

    /**
     * @description 任务状态ID。
     *
     * @var string
     */
    public $taskflowstatusId;

    /**
     * @description 任务数字ID。
     *
     * @var string
     */
    public $uniqueId;

    /**
     * @description 更新时间(UTC)。
     *
     * @var string
     */
    public $updated;

    /**
     * @description 任务隐私性，'involves'表达仅参与者可见; 'members'表达项目成员可见。
     *
     * @var string
     */
    public $visible;
    protected $_name = [
        'accomplishTime'        => 'accomplishTime',
        'ancestorIds'           => 'ancestorIds',
        'content'               => 'content',
        'created'               => 'created',
        'creatorId'             => 'creatorId',
        'customfields'          => 'customfields',
        'dueDate'               => 'dueDate',
        'executorId'            => 'executorId',
        'involveMembers'        => 'involveMembers',
        'isArchived'            => 'isArchived',
        'isDone'                => 'isDone',
        'note'                  => 'note',
        'parentTaskId'          => 'parentTaskId',
        'priority'              => 'priority',
        'projectId'             => 'projectId',
        'recurrence'            => 'recurrence',
        'scenariofieldconfigId' => 'scenariofieldconfigId',
        'sprintId'              => 'sprintId',
        'stageId'               => 'stageId',
        'startDate'             => 'startDate',
        'storyPoint'            => 'storyPoint',
        'tagIds'                => 'tagIds',
        'taskId'                => 'taskId',
        'taskListId'            => 'taskListId',
        'taskflowstatusId'      => 'taskflowstatusId',
        'uniqueId'              => 'uniqueId',
        'updated'               => 'updated',
        'visible'               => 'visible',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accomplishTime) {
            $res['accomplishTime'] = $this->accomplishTime;
        }
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
        if (null !== $this->customfields) {
            $res['customfields'] = [];
            if (null !== $this->customfields && \is_array($this->customfields)) {
                $n = 0;
                foreach ($this->customfields as $item) {
                    $res['customfields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->isArchived) {
            $res['isArchived'] = $this->isArchived;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->parentTaskId) {
            $res['parentTaskId'] = $this->parentTaskId;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->recurrence) {
            $res['recurrence'] = $this->recurrence;
        }
        if (null !== $this->scenariofieldconfigId) {
            $res['scenariofieldconfigId'] = $this->scenariofieldconfigId;
        }
        if (null !== $this->sprintId) {
            $res['sprintId'] = $this->sprintId;
        }
        if (null !== $this->stageId) {
            $res['stageId'] = $this->stageId;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->storyPoint) {
            $res['storyPoint'] = $this->storyPoint;
        }
        if (null !== $this->tagIds) {
            $res['tagIds'] = $this->tagIds;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskListId) {
            $res['taskListId'] = $this->taskListId;
        }
        if (null !== $this->taskflowstatusId) {
            $res['taskflowstatusId'] = $this->taskflowstatusId;
        }
        if (null !== $this->uniqueId) {
            $res['uniqueId'] = $this->uniqueId;
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
        if (isset($map['accomplishTime'])) {
            $model->accomplishTime = $map['accomplishTime'];
        }
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
        if (isset($map['customfields'])) {
            if (!empty($map['customfields'])) {
                $model->customfields = [];
                $n                   = 0;
                foreach ($map['customfields'] as $item) {
                    $model->customfields[$n++] = null !== $item ? customfields::fromMap($item) : $item;
                }
            }
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
        if (isset($map['isArchived'])) {
            $model->isArchived = $map['isArchived'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['parentTaskId'])) {
            $model->parentTaskId = $map['parentTaskId'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['recurrence'])) {
            if (!empty($map['recurrence'])) {
                $model->recurrence = $map['recurrence'];
            }
        }
        if (isset($map['scenariofieldconfigId'])) {
            $model->scenariofieldconfigId = $map['scenariofieldconfigId'];
        }
        if (isset($map['sprintId'])) {
            $model->sprintId = $map['sprintId'];
        }
        if (isset($map['stageId'])) {
            $model->stageId = $map['stageId'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['storyPoint'])) {
            $model->storyPoint = $map['storyPoint'];
        }
        if (isset($map['tagIds'])) {
            if (!empty($map['tagIds'])) {
                $model->tagIds = $map['tagIds'];
            }
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskListId'])) {
            $model->taskListId = $map['taskListId'];
        }
        if (isset($map['taskflowstatusId'])) {
            $model->taskflowstatusId = $map['taskflowstatusId'];
        }
        if (isset($map['uniqueId'])) {
            $model->uniqueId = $map['uniqueId'];
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
