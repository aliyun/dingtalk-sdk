<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskflowStatusResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $created;

    /**
     * @example 601fdeb17f86xxxxxxxx
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example false
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @example false
     *
     * @var bool
     */
    public $isTaskflowstatusruleexector;

    /**
     * @example start
     *
     * @var string
     */
    public $kind;

    /**
     * @example 未开始
     *
     * @var string
     */
    public $name;

    /**
     * @example 0
     *
     * @var int
     */
    public $pos;

    /**
     * @var string[]
     */
    public $rejectStatusIds;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $taskflowId;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $taskflowStatusId;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'created'                     => 'created',
        'creatorId'                   => 'creatorId',
        'isDeleted'                   => 'isDeleted',
        'isTaskflowstatusruleexector' => 'isTaskflowstatusruleexector',
        'kind'                        => 'kind',
        'name'                        => 'name',
        'pos'                         => 'pos',
        'rejectStatusIds'             => 'rejectStatusIds',
        'taskflowId'                  => 'taskflowId',
        'taskflowStatusId'            => 'taskflowStatusId',
        'updated'                     => 'updated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->isTaskflowstatusruleexector) {
            $res['isTaskflowstatusruleexector'] = $this->isTaskflowstatusruleexector;
        }
        if (null !== $this->kind) {
            $res['kind'] = $this->kind;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pos) {
            $res['pos'] = $this->pos;
        }
        if (null !== $this->rejectStatusIds) {
            $res['rejectStatusIds'] = $this->rejectStatusIds;
        }
        if (null !== $this->taskflowId) {
            $res['taskflowId'] = $this->taskflowId;
        }
        if (null !== $this->taskflowStatusId) {
            $res['taskflowStatusId'] = $this->taskflowStatusId;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
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
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['isTaskflowstatusruleexector'])) {
            $model->isTaskflowstatusruleexector = $map['isTaskflowstatusruleexector'];
        }
        if (isset($map['kind'])) {
            $model->kind = $map['kind'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pos'])) {
            $model->pos = $map['pos'];
        }
        if (isset($map['rejectStatusIds'])) {
            if (!empty($map['rejectStatusIds'])) {
                $model->rejectStatusIds = $map['rejectStatusIds'];
            }
        }
        if (isset($map['taskflowId'])) {
            $model->taskflowId = $map['taskflowId'];
        }
        if (isset($map['taskflowStatusId'])) {
            $model->taskflowStatusId = $map['taskflowStatusId'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
