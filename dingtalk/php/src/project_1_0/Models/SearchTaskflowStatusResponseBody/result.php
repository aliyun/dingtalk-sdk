<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchTaskflowStatusResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 创建时间。
     *
     * @var string
     */
    public $created;

    /**
     * @description 创建者ID。
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 工作流状态ID。
     *
     * @var string
     */
    public $id;

    /**
     * @description 是否已删除。
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 是否特定任务角色才能流转该工作流状态。
     *
     * @var bool
     */
    public $isTaskflowstatusruleexector;

    /**
     * @description start,end,unset
     *
     * @var string
     */
    public $kind;

    /**
     * @description 工作流状态名字。
     *
     * @var string
     */
    public $name;

    /**
     * @description 工作流状态位置。
     *
     * @var int
     */
    public $pos;

    /**
     * @description 该工作流状态不能流转到其他工作流状态。
     *
     * @var string[]
     */
    public $rejectStatusIds;

    /**
     * @description 工作流状态ID。
     *
     * @var string
     */
    public $taskflowId;

    /**
     * @description 更新时间。
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'created'                     => 'created',
        'creatorId'                   => 'creatorId',
        'id'                          => 'id',
        'isDeleted'                   => 'isDeleted',
        'isTaskflowstatusruleexector' => 'isTaskflowstatusruleexector',
        'kind'                        => 'kind',
        'name'                        => 'name',
        'pos'                         => 'pos',
        'rejectStatusIds'             => 'rejectStatusIds',
        'taskflowId'                  => 'taskflowId',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
