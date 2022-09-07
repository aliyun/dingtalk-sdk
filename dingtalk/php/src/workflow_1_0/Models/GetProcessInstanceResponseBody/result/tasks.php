<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result;

use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @description 任务节点ID。
     *
     * @var string
     */
    public $activityId;

    /**
     * @description 开始时间。
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 结束时间。
     *
     * @var string
     */
    public $finishTime;

    /**
     * @description 移动端任务URL。
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @description PC端任务URL。
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @description 实例ID。
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 结果：  AGREE：同意  REFUSE：拒绝  REDIRECTED：转交
     *
     * @var string
     */
    public $result;

    /**
     * @description 任务状态：  NEW：未启动  RUNNING：处理中  PAUSED：暂停  CANCELED：取消  COMPLETED：完成  TERMINATED：终止
     *
     * @var string
     */
    public $status;

    /**
     * @description 任务ID。
     *
     * @var int
     */
    public $taskId;

    /**
     * @description 任务处理人。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'activityId'        => 'activityId',
        'createTime'        => 'createTime',
        'finishTime'        => 'finishTime',
        'mobileUrl'         => 'mobileUrl',
        'pcUrl'             => 'pcUrl',
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
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
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
     * @return tasks
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
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
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
