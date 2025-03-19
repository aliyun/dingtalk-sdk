<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQueryCustomerSendTaskResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @example 张三
     *
     * @var string
     */
    public $createName;

    /**
     * @example 2023-07-14 10:00:00
     *
     * @var string
     */
    public $createTimeStr;

    /**
     * @example 88888
     *
     * @var string
     */
    public $createUnionId;

    /**
     * @example 88888
     *
     * @var string
     */
    public $openBatchTaskId;

    /**
     * @example 90
     *
     * @var int
     */
    public $readCustomerInc;

    /**
     * @example 100
     *
     * @var int
     */
    public $readUserInc;

    /**
     * @example 100
     *
     * @var int
     */
    public $sendCustomerInc;

    /**
     * @example UNFINISH 未完成 FINISHED 已发送 CANCELED 已取消 CREATE_TASK_FAILED 创建任务失败  SENDING 发送中
     *
     * @var string
     */
    public $sendMessageStatus;

    /**
     * @example 2023-07-14 11:00:00
     *
     * @var string
     */
    public $sendTaskTimeStr;

    /**
     * @example 200
     *
     * @var int
     */
    public $sendUserInc;

    /**
     * @example 任务名称
     *
     * @var string
     */
    public $taskName;
    protected $_name = [
        'createName' => 'createName',
        'createTimeStr' => 'createTimeStr',
        'createUnionId' => 'createUnionId',
        'openBatchTaskId' => 'openBatchTaskId',
        'readCustomerInc' => 'readCustomerInc',
        'readUserInc' => 'readUserInc',
        'sendCustomerInc' => 'sendCustomerInc',
        'sendMessageStatus' => 'sendMessageStatus',
        'sendTaskTimeStr' => 'sendTaskTimeStr',
        'sendUserInc' => 'sendUserInc',
        'taskName' => 'taskName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createName) {
            $res['createName'] = $this->createName;
        }
        if (null !== $this->createTimeStr) {
            $res['createTimeStr'] = $this->createTimeStr;
        }
        if (null !== $this->createUnionId) {
            $res['createUnionId'] = $this->createUnionId;
        }
        if (null !== $this->openBatchTaskId) {
            $res['openBatchTaskId'] = $this->openBatchTaskId;
        }
        if (null !== $this->readCustomerInc) {
            $res['readCustomerInc'] = $this->readCustomerInc;
        }
        if (null !== $this->readUserInc) {
            $res['readUserInc'] = $this->readUserInc;
        }
        if (null !== $this->sendCustomerInc) {
            $res['sendCustomerInc'] = $this->sendCustomerInc;
        }
        if (null !== $this->sendMessageStatus) {
            $res['sendMessageStatus'] = $this->sendMessageStatus;
        }
        if (null !== $this->sendTaskTimeStr) {
            $res['sendTaskTimeStr'] = $this->sendTaskTimeStr;
        }
        if (null !== $this->sendUserInc) {
            $res['sendUserInc'] = $this->sendUserInc;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createName'])) {
            $model->createName = $map['createName'];
        }
        if (isset($map['createTimeStr'])) {
            $model->createTimeStr = $map['createTimeStr'];
        }
        if (isset($map['createUnionId'])) {
            $model->createUnionId = $map['createUnionId'];
        }
        if (isset($map['openBatchTaskId'])) {
            $model->openBatchTaskId = $map['openBatchTaskId'];
        }
        if (isset($map['readCustomerInc'])) {
            $model->readCustomerInc = $map['readCustomerInc'];
        }
        if (isset($map['readUserInc'])) {
            $model->readUserInc = $map['readUserInc'];
        }
        if (isset($map['sendCustomerInc'])) {
            $model->sendCustomerInc = $map['sendCustomerInc'];
        }
        if (isset($map['sendMessageStatus'])) {
            $model->sendMessageStatus = $map['sendMessageStatus'];
        }
        if (isset($map['sendTaskTimeStr'])) {
            $model->sendTaskTimeStr = $map['sendTaskTimeStr'];
        }
        if (isset($map['sendUserInc'])) {
            $model->sendUserInc = $map['sendUserInc'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }

        return $model;
    }
}
