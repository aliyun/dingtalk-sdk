<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTaskByIdsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTaskByIdsResponseBody\result\customfields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $accomplishTime;

    /**
     * @var string[]
     */
    public $ancestorIds;

    /**
     * @example 任务标题
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
     * @example 0517xxxxxxx
     *
     * @var string
     */
    public $creatorId;

    /**
     * @var customfields[]
     */
    public $customfields;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $dueDate;

    /**
     * @example 0517xxxxxxx
     *
     * @var string
     */
    public $executorId;

    /**
     * @var string[]
     */
    public $involveMembers;

    /**
     * @example false
     *
     * @var bool
     */
    public $isArchived;

    /**
     * @example true
     *
     * @var bool
     */
    public $isDone;

    /**
     * @example 任务备注
     *
     * @var string
     */
    public $note;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $parentTaskId;

    /**
     * @example 0
     *
     * @var int
     */
    public $priority;

    /**
     * @example 62c25e3b376ecxxxxxxx
     *
     * @var string
     */
    public $projectId;

    /**
     * @var string[]
     */
    public $recurrence;

    /**
     * @example 6922xxxxxxxx
     *
     * @var string
     */
    public $scenariofieldconfigId;

    /**
     * @example 61922xxxxxxxx
     *
     * @var string
     */
    public $sprintId;

    /**
     * @example 6622134xxxxxx
     *
     * @var string
     */
    public $stageId;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $startDate;

    /**
     * @example 1
     *
     * @var string
     */
    public $storyPoint;

    /**
     * @var string[]
     */
    public $tagIds;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 6922xxxxxxxx
     *
     * @var string
     */
    public $taskListId;

    /**
     * @example 6722xxxxxxxx
     *
     * @var string
     */
    public $taskflowstatusId;

    /**
     * @example 0
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
     * @example member
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
