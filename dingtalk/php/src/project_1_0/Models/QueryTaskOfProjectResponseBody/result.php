<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryTaskOfProjectResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\QueryTaskOfProjectResponseBody\result\customfields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 任务完成时间。
     *
     * @var string
     */
    public $accomplished;

    /**
     * @description 父任务id列表。
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
     * @description 创建时间。
     *
     * @var string
     */
    public $created;

    /**
     * @description 创建者id。
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 自定义字段id列表。
     *
     * @var customfields[]
     */
    public $customfields;

    /**
     * @description 任务截止时间。
     *
     * @var string
     */
    public $dueDate;

    /**
     * @description 执行者id。
     *
     * @var string
     */
    public $executorId;

    /**
     * @description 参与者列表。
     *
     * @var string[]
     */
    public $involveMembers;

    /**
     * @description 是否归档。
     *
     * @var bool
     */
    public $isArchived;

    /**
     * @description 是否已删除。
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 任务是否已完成。
     *
     * @var bool
     */
    public $isDone;

    /**
     * @description 任务标签集合。
     *
     * @var string[]
     */
    public $labels;

    /**
     * @description 备注。
     *
     * @var string
     */
    public $note;

    /**
     * @description 任务优先级。
     *
     * @var int
     */
    public $priority;

    /**
     * @description 任务进度。
     *
     * @var int
     */
    public $progress;

    /**
     * @description 项目id。
     *
     * @var string
     */
    public $projectId;

    /**
     * @description 任务类型id。
     *
     * @var string
     */
    public $scenariofieldconfigId;

    /**
     * @description 任务迭代id。
     *
     * @var string
     */
    public $sprintId;

    /**
     * @description 任务列表Id。
     *
     * @var string
     */
    public $stageId;

    /**
     * @description 任务开始时间。
     *
     * @var string
     */
    public $startDate;

    /**
     * @description 故事点数。
     *
     * @var int
     */
    public $storyPoint;

    /**
     * @description 标签id集合。
     *
     * @var string[]
     */
    public $tagIds;

    /**
     * @description 任务id。
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 任务状态id。
     *
     * @var string
     */
    public $taskflowstatusId;

    /**
     * @description 更新时间。
     *
     * @var string
     */
    public $updated;

    /**
     * @description 任务的可见性规则 involves | members。
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
