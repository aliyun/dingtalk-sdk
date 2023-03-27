<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SeachTaskStageResponseBody;

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
     * @description 创建者用户 ID。
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 任务列表名称。
     *
     * @var string
     */
    public $description;

    /**
     * @description 任务列表名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 项目 ID。
     *
     * @var string
     */
    public $projectId;

    /**
     * @description 任务分组 ID。
     *
     * @var string
     */
    public $taskListId;

    /**
     * @description 任务列表 ID。
     *
     * @var string
     */
    public $taskStageId;

    /**
     * @description 更新时间。
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'created'     => 'created',
        'creatorId'   => 'creatorId',
        'description' => 'description',
        'name'        => 'name',
        'projectId'   => 'projectId',
        'taskListId'  => 'taskListId',
        'taskStageId' => 'taskStageId',
        'updated'     => 'updated',
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
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->taskListId) {
            $res['taskListId'] = $this->taskListId;
        }
        if (null !== $this->taskStageId) {
            $res['taskStageId'] = $this->taskStageId;
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
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['taskListId'])) {
            $model->taskListId = $map['taskListId'];
        }
        if (isset($map['taskStageId'])) {
            $model->taskStageId = $map['taskStageId'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
