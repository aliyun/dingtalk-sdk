<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchUserTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchUserTaskResponseBody\result\customFields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2023-04-12T03:39:54.918Z
     *
     * @var string
     */
    public $accomplishTime;

    /**
     * @var string[]
     */
    public $ancestorIds;

    /**
     * @example 任务内容
     *
     * @var string
     */
    public $content;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $created;

    /**
     * @example 63a9207a042f7c254f60519c
     *
     * @var string
     */
    public $creatorId;

    /**
     * @var customFields[]
     */
    public $customFields;

    /**
     * @example 2022-07-05T03:29:34.770Z
     *
     * @var string
     */
    public $dueDate;

    /**
     * @example 63a9207a042f7c254f60519c
     *
     * @var string
     */
    public $executorId;

    /**
     * @var string[]
     */
    public $involveMembers;

    /**
     * @var bool
     */
    public $isArchived;

    /**
     * @var bool
     */
    public $isDone;

    /**
     * @example 备注内容
     *
     * @var string
     */
    public $note;

    /**
     * @example 644b6f4cca369863fbc8abbb
     *
     * @var string
     */
    public $parentTaskId;

    /**
     * @var int
     */
    public $priority;

    /**
     * @example 643394f81502a928dbd5ba37
     *
     * @var string
     */
    public $projectId;

    /**
     * @var string[]
     */
    public $recurrence;

    /**
     * @example 64099d5b2f404400174d7fc1
     *
     * @var string
     */
    public $scenarioFieldConfigId;

    /**
     * @example 64099d5b2f404400174d7fc1
     *
     * @var string
     */
    public $sprintId;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $startDate;

    /**
     * @example 0
     *
     * @var string
     */
    public $storyPoint;

    /**
     * @var string[]
     */
    public $tagIds;

    /**
     * @example 642befe827feb683f91bd529
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 6436278ea14fe435351668a2
     *
     * @var string
     */
    public $taskListId;

    /**
     * @example 6436278ea14fe435351668a4
     *
     * @var string
     */
    public $taskStageId;

    /**
     * @example 64099d5b2f404400174d7fbb
     *
     * @var string
     */
    public $taskflowStatusId;

    /**
     * @example 3
     *
     * @var string
     */
    public $uniqueId;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $updated;

    /**
     * @example projectMembers
     *
     * @var string
     */
    public $visible;
    protected $_name = [
        'accomplishTime' => 'accomplishTime',
        'ancestorIds' => 'ancestorIds',
        'content' => 'content',
        'created' => 'created',
        'creatorId' => 'creatorId',
        'customFields' => 'customFields',
        'dueDate' => 'dueDate',
        'executorId' => 'executorId',
        'involveMembers' => 'involveMembers',
        'isArchived' => 'isArchived',
        'isDone' => 'isDone',
        'note' => 'note',
        'parentTaskId' => 'parentTaskId',
        'priority' => 'priority',
        'projectId' => 'projectId',
        'recurrence' => 'recurrence',
        'scenarioFieldConfigId' => 'scenarioFieldConfigId',
        'sprintId' => 'sprintId',
        'startDate' => 'startDate',
        'storyPoint' => 'storyPoint',
        'tagIds' => 'tagIds',
        'taskId' => 'taskId',
        'taskListId' => 'taskListId',
        'taskStageId' => 'taskStageId',
        'taskflowStatusId' => 'taskflowStatusId',
        'uniqueId' => 'uniqueId',
        'updated' => 'updated',
        'visible' => 'visible',
    ];

    public function validate() {}

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
        if (null !== $this->customFields) {
            $res['customFields'] = [];
            if (null !== $this->customFields && \is_array($this->customFields)) {
                $n = 0;
                foreach ($this->customFields as $item) {
                    $res['customFields'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (null !== $this->scenarioFieldConfigId) {
            $res['scenarioFieldConfigId'] = $this->scenarioFieldConfigId;
        }
        if (null !== $this->sprintId) {
            $res['sprintId'] = $this->sprintId;
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
        if (null !== $this->taskStageId) {
            $res['taskStageId'] = $this->taskStageId;
        }
        if (null !== $this->taskflowStatusId) {
            $res['taskflowStatusId'] = $this->taskflowStatusId;
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
        if (isset($map['customFields'])) {
            if (!empty($map['customFields'])) {
                $model->customFields = [];
                $n = 0;
                foreach ($map['customFields'] as $item) {
                    $model->customFields[$n++] = null !== $item ? customFields::fromMap($item) : $item;
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
        if (isset($map['scenarioFieldConfigId'])) {
            $model->scenarioFieldConfigId = $map['scenarioFieldConfigId'];
        }
        if (isset($map['sprintId'])) {
            $model->sprintId = $map['sprintId'];
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
        if (isset($map['taskStageId'])) {
            $model->taskStageId = $map['taskStageId'];
        }
        if (isset($map['taskflowStatusId'])) {
            $model->taskflowStatusId = $map['taskflowStatusId'];
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
