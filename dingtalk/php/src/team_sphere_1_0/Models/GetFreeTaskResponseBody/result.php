<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetFreeTaskResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $accomplished;

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
    public $isArchive;

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
    public $organizationId;

    /**
     * @var int
     */
    public $priority;

    /**
     * @var string[]
     */
    public $recurrence;

    /**
     * @var string
     */
    public $sourceId;

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
     * @var int
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
        'accomplished' => 'accomplished',
        'ancestorIds' => 'ancestorIds',
        'content' => 'content',
        'created' => 'created',
        'creatorId' => 'creatorId',
        'dueDate' => 'dueDate',
        'executorId' => 'executorId',
        'id' => 'id',
        'involveMembers' => 'involveMembers',
        'isArchive' => 'isArchive',
        'isDone' => 'isDone',
        'note' => 'note',
        'organizationId' => 'organizationId',
        'priority' => 'priority',
        'recurrence' => 'recurrence',
        'sourceId' => 'sourceId',
        'startDate' => 'startDate',
        'tagIds' => 'tagIds',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->involveMembers) {
            $res['involveMembers'] = $this->involveMembers;
        }
        if (null !== $this->isArchive) {
            $res['isArchive'] = $this->isArchive;
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
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->recurrence) {
            $res['recurrence'] = $this->recurrence;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->tagIds) {
            $res['tagIds'] = $this->tagIds;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['involveMembers'])) {
            if (!empty($map['involveMembers'])) {
                $model->involveMembers = $map['involveMembers'];
            }
        }
        if (isset($map['isArchive'])) {
            $model->isArchive = $map['isArchive'];
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
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['recurrence'])) {
            if (!empty($map['recurrence'])) {
                $model->recurrence = $map['recurrence'];
            }
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['tagIds'])) {
            if (!empty($map['tagIds'])) {
                $model->tagIds = $map['tagIds'];
            }
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
