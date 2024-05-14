<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_;

use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @example 1234_abcd
     *
     * @var string
     */
    public $activityId;

    /**
     * @example 1657522271000
     *
     * @var int
     */
    public $createTimestamp;

    /**
     * @example 1657522271000
     *
     * @var int
     */
    public $finishTimestamp;

    /**
     * @example 分为AGREE（同意），REFUSE（拒绝），REDIRECTED（转交）
     *
     * @var string
     */
    public $result;

    /**
     * @description This parameter is required.
     *
     * @example NEW（未启动），RUNNING（处理中），PAUSED（暂停），CANCELED（取消），COMPLETED（完成），TERMINATED（终止）
     *
     * @var string
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var int
     */
    public $taskId;

    /**
     * @example staff1234
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
