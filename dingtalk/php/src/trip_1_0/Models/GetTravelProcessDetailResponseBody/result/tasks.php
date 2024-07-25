<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @example 1918_5cd3
     *
     * @var string
     */
    public $activityId;

    /**
     * @example 2024-07-01 00:00:00
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 2024-07-01 01:00:00
     *
     * @var string
     */
    public $finishTime;

    /**
     * @example 12374
     *
     * @var string
     */
    public $originUserId;

    /**
     * @example e7fh112WTTawy6dLtiIlqQ10051721014983
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example AGREE
     *
     * @var string
     */
    public $result;

    /**
     * @example COMPLETED
     *
     * @var string
     */
    public $status;

    /**
     * @example 87882310449
     *
     * @var int
     */
    public $taskId;

    /**
     * @example aflow.dingtalk.com?procInsId=xxx&taskId=yyy&businessId=zzz
     *
     * @var string
     */
    public $url;

    /**
     * @example 2220314
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'activityId'        => 'activityId',
        'createTime'        => 'createTime',
        'finishTime'        => 'finishTime',
        'originUserId'      => 'originUserId',
        'processInstanceId' => 'processInstanceId',
        'result'            => 'result',
        'status'            => 'status',
        'taskId'            => 'taskId',
        'url'               => 'url',
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
        if (null !== $this->originUserId) {
            $res['originUserId'] = $this->originUserId;
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
        if (null !== $this->url) {
            $res['url'] = $this->url;
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
        if (isset($map['originUserId'])) {
            $model->originUserId = $map['originUserId'];
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
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
