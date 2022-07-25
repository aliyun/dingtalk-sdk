<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_;

use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @description 节点id
     *
     * @var string
     */
    public $activityId;

    /**
     * @description 任务创建时间戳
     *
     * @var int
     */
    public $createTimestamp;

    /**
     * @description 任务结束时间戳
     *
     * @var int
     */
    public $finishTimestamp;

    /**
     * @description 任务结果
     *
     * @var string
     */
    public $result;

    /**
     * @description 任务状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 任务Id
     *
     * @var int
     */
    public $taskId;

    /**
     * @description 任务处理人
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'activityId'      => 'activityId',
        'createTimestamp' => 'createTimestamp',
        'finishTimestamp' => 'finishTimestamp',
        'result'          => 'result',
        'status'          => 'status',
        'taskId'          => 'taskId',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->createTimestamp) {
            $res['createTimestamp'] = $this->createTimestamp;
        }
        if (null !== $this->finishTimestamp) {
            $res['finishTimestamp'] = $this->finishTimestamp;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tasks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['createTimestamp'])) {
            $model->createTimestamp = $map['createTimestamp'];
        }
        if (isset($map['finishTimestamp'])) {
            $model->finishTimestamp = $map['finishTimestamp'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
