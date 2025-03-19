<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskStageResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $accomplishTime;

    /**
     * @example false
     *
     * @var bool
     */
    public $isDone;

    /**
     * @example 64a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $projectId;

    /**
     * @example 63a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 66a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $taskListId;

    /**
     * @example 69a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $taskStageId;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'accomplishTime' => 'accomplishTime',
        'isDone' => 'isDone',
        'projectId' => 'projectId',
        'taskId' => 'taskId',
        'taskListId' => 'taskListId',
        'taskStageId' => 'taskStageId',
        'updated' => 'updated',
    ];

    public function validate() {}

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
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
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
        if (isset($map['accomplishTime'])) {
            $model->accomplishTime = $map['accomplishTime'];
        }
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }
        if (isset($map['projectId'])) {
            $model->projectId = $map['projectId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
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
