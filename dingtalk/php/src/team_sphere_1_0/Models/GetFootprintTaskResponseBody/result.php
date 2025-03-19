<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFootprintTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFootprintTaskResponseBody\result\customfields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2024-09-19T11:07:51.468Z
     *
     * @var string
     */
    public $accomplished;

    /**
     * @var string
     */
    public $basicPos;

    /**
     * @var string
     */
    public $content;

    /**
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
     * @example 2024-09-13T10:00:00.000Z
     *
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
     * @example false
     *
     * @var bool
     */
    public $isArchived;

    /**
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
     * @example test123
     *
     * @var string
     */
    public $note;

    /**
     * @var string
     */
    public $organizationId;

    /**
     * @example 0
     *
     * @var int
     */
    public $pos;

    /**
     * @example 0
     *
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
     * @example 6639f974916cdb178e7d***
     *
     * @var string
     */
    public $stageId;

    /**
     * @example 2024-09-13T10:00:00.000Z
     *
     * @var string
     */
    public $startDate;

    /**
     * @example 6639f974916cdb178e7d***
     *
     * @var string
     */
    public $tasklistId;

    /**
     * @example 6639f974916cdb178e7****
     *
     * @var string
     */
    public $tfsId;

    /**
     * @example 540
     *
     * @var int
     */
    public $uniqueId;

    /**
     * @var string
     */
    public $updated;

    /**
     * @example members
     *
     * @var string
     */
    public $visible;
    protected $_name = [
        'accomplished' => 'accomplished',
        'basicPos' => 'basicPos',
        'content' => 'content',
        'created' => 'created',
        'creatorId' => 'creatorId',
        'customfields' => 'customfields',
        'dueDate' => 'dueDate',
        'executorId' => 'executorId',
        'id' => 'id',
        'involveMembers' => 'involveMembers',
        'isArchived' => 'isArchived',
        'isDeleted' => 'isDeleted',
        'isDone' => 'isDone',
        'note' => 'note',
        'organizationId' => 'organizationId',
        'pos' => 'pos',
        'priority' => 'priority',
        'projectId' => 'projectId',
        'sfcId' => 'sfcId',
        'stageId' => 'stageId',
        'startDate' => 'startDate',
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
        if (null !== $this->accomplished) {
            $res['accomplished'] = $this->accomplished;
        }
        if (null !== $this->basicPos) {
            $res['basicPos'] = $this->basicPos;
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
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->organizationId) {
            $res['organizationId'] = $this->organizationId;
        }
        if (null !== $this->pos) {
            $res['pos'] = $this->pos;
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
        if (isset($map['accomplished'])) {
            $model->accomplished = $map['accomplished'];
        }
        if (isset($map['basicPos'])) {
            $model->basicPos = $map['basicPos'];
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
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['organizationId'])) {
            $model->organizationId = $map['organizationId'];
        }
        if (isset($map['pos'])) {
            $model->pos = $map['pos'];
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
