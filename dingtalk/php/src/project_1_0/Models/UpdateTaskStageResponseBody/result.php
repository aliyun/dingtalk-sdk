<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskStageResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 任务完成时间(UTC)。
     *
     * @var string
     */
    public $accomplishTime;

    /**
     * @description 是否任务已完成。
     *
     * @var bool
     */
    public $isDone;

    /**
     * @description 项目ID。
     *
     * @var string
     */
    public $projectId;

    /**
     * @description 任务列ID。
     *
     * @var string
     */
    public $stageId;

    /**
     * @description 任务ID。
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 任务分组ID。
     *
     * @var string
     */
    public $taskListId;

    /**
     * @description 更新时间(UTC)。
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'accomplishTime' => 'accomplishTime',
        'isDone'         => 'isDone',
        'projectId'      => 'projectId',
        'stageId'        => 'stageId',
        'taskId'         => 'taskId',
        'taskListId'     => 'taskListId',
        'updated'        => 'updated',
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
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }
        if (null !== $this->projectId) {
            $res['projectId'] = $this->projectId;
        }
        if (null !== $this->stageId) {
            $res['stageId'] = $this->stageId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->taskListId) {
            $res['taskListId'] = $this->taskListId;
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
        if (isset($map['accomplishTime'])) {
            $model->accomplishTime = $map['accomplishTime'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['stageId'])) {
            $model->stageId = $map['stageId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['taskListId'])) {
            $model->taskListId = $map['taskListId'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
