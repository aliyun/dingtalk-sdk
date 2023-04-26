<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryTaskOfProjectResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryTaskOfProjectResponseBody\result\customfields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $accomplished;

    /**
     * @var string[]
     */
    public $ancestorIds;

    /**
     * @example 标题2
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
     * @example 62c25e3bba7ce40xxx
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
     * @example 62cxxxxxxx
     *
     * @var string
     */
    public $executorId;

    /**
     * @var string[]
     */
    public $involveMembers;

    /**
     * @example true
     *
     * @var bool
     */
    public $isArchived;

    /**
     * @example true
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @example true
     *
     * @var bool
     */
    public $isDone;

    /**
     * @var string[]
     */
    public $labels;

    /**
     * @example 备注
     *
     * @var string
     */
    public $note;

    /**
     * @example 0
     *
     * @var int
     */
    public $priority;

    /**
     * @example 0
     *
     * @var int
     */
    public $progress;

    /**
     * @example 62c25e3bbaxxxxx
     *
     * @var string
     */
    public $projectId;

    /**
     * @example 62c25e3bbxx0xxx
     *
     * @var string
     */
    public $scenariofieldconfigId;

    /**
     * @example 62c25e3bbxx0xxx
     *
     * @var string
     */
    public $sprintId;

    /**
     * @example 62c25e3bbxx0xxx
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
     * @example 2
     *
     * @var int
     */
    public $storyPoint;

    /**
     * @example 62c25e3bbxx0xxx
     *
     * @var string[]
     */
    public $tagIds;

    /**
     * @example 62c25e3bbaxxx
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 62c25e3bbxx0xxx
     *
     * @var string
     */
    public $taskflowstatusId;

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
        'accomplished'          => 'accomplished',
        'ancestorIds'           => 'ancestorIds',
        'content'               => 'content',
        'created'               => 'created',
        'creatorId'             => 'creatorId',
        'customfields'          => 'customfields',
        'dueDate'               => 'dueDate',
        'executorId'            => 'executorId',
        'involveMembers'        => 'involveMembers',
        'isArchived'            => 'isArchived',
        'isDeleted'             => 'isDeleted',
        'isDone'                => 'isDone',
        'labels'                => 'labels',
        'note'                  => 'note',
        'priority'              => 'priority',
        'progress'              => 'progress',
        'projectId'             => 'projectId',
        'scenariofieldconfigId' => 'scenariofieldconfigId',
        'sprintId'              => 'sprintId',
        'stageId'               => 'stageId',
        'startDate'             => 'startDate',
        'storyPoint'            => 'storyPoint',
        'tagIds'                => 'tagIds',
        'taskId'                => 'taskId',
        'taskflowstatusId'      => 'taskflowstatusId',
        'updated'               => 'updated',
        'visible'               => 'visible',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accomplished) {
            $res['accomplished'] = $this->accomplished;
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
        if (null !== $this->progress) {
            $res['progress'] = $this->progress;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
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
        if (null !== $this->taskflowstatusId) {
            $res['taskflowstatusId'] = $this->taskflowstatusId;
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
        if (isset($map['accomplished'])) {
            $model->accomplished = $map['accomplished'];
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
        if (isset($map['progress'])) {
            $model->progress = $map['progress'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
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
        if (isset($map['taskflowstatusId'])) {
            $model->taskflowstatusId = $map['taskflowstatusId'];
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
