<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryIntegratedTodoTaskResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example act_0001
     *
     * @var string
     */
    public $activityId;

    /**
     * @example 2022-10-17T15:12Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 2022-10-17T15:12Z
     *
     * @var string
     */
    public $finishTime;

    /**
     * @example Siw2WNVZS4KiUt3tTmaNKg04*****809950
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example agree
     *
     * @var string
     */
    public $result;

    /**
     * @example RUNNING
     *
     * @var string
     */
    public $status;

    /**
     * @example 1234567
     *
     * @var int
     */
    public $taskId;

    /**
     * @example manager001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'activityId' => 'activityId',
        'createTime' => 'createTime',
        'finishTime' => 'finishTime',
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
