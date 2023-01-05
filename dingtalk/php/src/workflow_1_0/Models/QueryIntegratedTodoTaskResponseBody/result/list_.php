<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryIntegratedTodoTaskResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 待办组ID，需要在调用创建流程中心集成任务接口时，主动设置该值。
     *
     * @var string
     */
    public $activityId;

    /**
     * @description OA审批任务创建时间。
     *
     * @var string
     */
    public $createTime;

    /**
     * @description OA审批任务完成时间。
     *
     * @var string
     */
    public $finishTime;

    /**
     * @description 流程实例ID
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 任务处理结果：agree 或 refuse
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
     * @description OA审批任务ID
     *
     * @var int
     */
    public $taskId;

    /**
     * @description OA审批任务执行人的用户ID
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'activityId'        => 'activityId',
        'createTime'        => 'createTime',
        'finishTime'        => 'finishTime',
        'processInstanceId' => 'processInstanceId',
        'result'            => 'result',
        'status'            => 'status',
        'taskId'            => 'taskId',
        'userId'            => 'userId',
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
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
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
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
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
