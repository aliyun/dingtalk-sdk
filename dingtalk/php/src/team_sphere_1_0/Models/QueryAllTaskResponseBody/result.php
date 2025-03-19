<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryAllTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryAllTaskResponseBody\result\customfields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $accomplishTime;

    /**
     * @var string[]
     */
    public $ancestorIds;

    /**
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
     * @var string
     */
    public $creatorId;

    /**
     * @var customfields[]
     */
    public $customfields;

    /**
     * @var string
     */
    public $dueDate;

    /**
     * @var string
     */
    public $executorId;

    /**
     * @var string
     */
    public $id;

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
     * @var string
     */
    public $note;

    /**
     * @var string
     */
    public $parentTaskId;

    /**
     * @var int
     */
    public $priority;

    /**
     * @var string
     */
    public $projectId;

    /**
     * @var string
     */
    public $sfcId;

    /**
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
     * @var string[]
     */
    public $tagIds;

    /**
     * @deprecated
     *
     * @var string
     */
    public $taskId;

    /**
     * @var string
     */
    public $tasklistId;

    /**
     * @var string
     */
    public $tfsId;

    /**
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
     * @var string
     */
    public $visible;
    protected $_name = [
        'accomplishTime' => 'accomplishTime',
        'ancestorIds' => 'ancestorIds',
        'content' => 'content',
        'created' => 'created',
        'creatorId' => 'creatorId',
        'customfields' => 'customfields',
        'dueDate' => 'dueDate',
        'executorId' => 'executorId',
        'id' => 'id',
        'involveMembers' => 'involveMembers',
        'isArchived' => 'isArchived',
        'isDone' => 'isDone',
        'note' => 'note',
        'parentTaskId' => 'parentTaskId',
        'priority' => 'priority',
        'projectId' => 'projectId',
        'sfcId' => 'sfcId',
        'stageId' => 'stageId',
        'startDate' => 'startDate',
        'tagIds' => 'tagIds',
        'taskId' => 'taskId',
        'tasklistId' => 'tasklistId',
        'tfsId' => 'tfsId',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (null !== $this->sfcId) {
            $res['sfcId'] = $this->sfcId;
        }
        if (null !== $this->stageId) {
            $res['stageId'] = $this->stageId;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->tagIds) {
            $res['tagIds'] = $this->tagIds;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->tasklistId) {
            $res['tasklistId'] = $this->tasklistId;
        }
        if (null !== $this->tfsId) {
            $res['tfsId'] = $this->tfsId;
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
                $n = 0;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
        if (isset($map['sfcId'])) {
            $model->sfcId = $map['sfcId'];
        }
        if (isset($map['stageId'])) {
            $model->stageId = $map['stageId'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['tagIds'])) {
            if (!empty($map['tagIds'])) {
                $model->tagIds = $map['tagIds'];
            }
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['tasklistId'])) {
            $model->tasklistId = $map['tasklistId'];
        }
        if (isset($map['tfsId'])) {
            $model->tfsId = $map['tfsId'];
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
