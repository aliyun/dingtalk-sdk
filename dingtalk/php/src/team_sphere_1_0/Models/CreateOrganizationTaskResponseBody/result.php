<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskResponseBody\result\creator;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskResponseBody\result\executor;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskResponseBody\result\involvers;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string[]
     */
    public $ancestorIds;

    /**
     * @example 0
     *
     * @var int
     */
    public $attachmentsCount;

    /**
     * @example 明天12点前写好周报
     *
     * @var string
     */
    public $content;

    /**
     * @example 2021-08-13T07:36:50.318Z
     *
     * @var string
     */
    public $created;

    /**
     * @var creator
     */
    public $creator;

    /**
     * @example 173xxxx
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example 2021-08-13T07:36:50.318Z
     *
     * @var string
     */
    public $dueDate;

    /**
     * @var executor
     */
    public $executor;

    /**
     * @example 173xxxx
     *
     * @var string
     */
    public $executorId;

    /**
     * @example false
     *
     * @var bool
     */
    public $hasReminder;

    /**
     * @example 62a697c053c2ef5xxxxxx
     *
     * @var string
     */
    public $id;

    /**
     * @var string[]
     */
    public $involveMembers;

    /**
     * @var involvers[]
     */
    public $involvers;

    /**
     * @example false
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @example false
     *
     * @var string
     */
    public $isDone;

    /**
     * @example 我是一条备注哦
     *
     * @var string
     */
    public $note;

    /**
     * @example 2021-08-13T07:36:50.318Z
     *
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
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }
        if (isset($map['visible'])) {
            $model->visible = $map['visible'];
        }

        return $model;
    }
}
