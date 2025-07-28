<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result;

use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @example 111
     *
     * @var string
     */
    public $activityId;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2022-08-31T11:52Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2022-08-31T11:52Z
     *
     * @var string
     */
    public $finishTime;

    /**
     * @example https://www.xxxx.com
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @example https://www.xxxx.com
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @example 111
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example REDIRECTED
     *
     * @var string
     */
    public $result;

    /**
     * @example NEW
     *
     * @var string
     */
    public $status;

    /**
     * @example 111
     *
     * @var int
     */
    public $taskId;

    /**
     * @example manager1
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'activityId' => 'activityId',
        'createTime' => 'createTime',
        'finishTime' => 'finishTime',
        'mobileUrl' => 'mobileUrl',
        'pcUrl' => 'pcUrl',
        'processInstanceId' => 'processInstanceId',
        'result' => 'result',
        'status' => 'status',
        'taskId' => 'taskId',
        'userId' => 'userId',
    ];

    public function validate() {}

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
