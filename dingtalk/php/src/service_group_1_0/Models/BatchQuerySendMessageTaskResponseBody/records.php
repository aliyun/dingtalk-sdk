<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchQuerySendMessageTaskResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @var string
     */
    public $createName;

    /**
     * @var string
     */
    public $createTimeStr;

    /**
     * @var string
     */
    public $createUnionId;

    /**
     * @var string
     */
    public $openBatchTaskId;

    /**
     * @var int
     */
    public $readGroupInc;

    /**
     * @var int
     */
    public $sendGroupInc;

    /**
     * @var string
     */
    public $sendMessageStatus;

    /**
     * @var string
     */
    public $sendTaskTimeStr;

    /**
     * @var string
     */
    public $taskName;
    protected $_name = [
        'createName'        => 'createName',
        'createTimeStr'     => 'createTimeStr',
        'createUnionId'     => 'createUnionId',
        'openBatchTaskId'   => 'openBatchTaskId',
        'readGroupInc'      => 'readGroupInc',
        'sendGroupInc'      => 'sendGroupInc',
        'sendMessageStatus' => 'sendMessageStatus',
        'sendTaskTimeStr'   => 'sendTaskTimeStr',
        'taskName'          => 'taskName',
    ];

    public function validate()
    {
    }

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
        if (null !== $this->readGroupInc) {
            $res['readGroupInc'] = $this->readGroupInc;
        }
        if (null !== $this->sendGroupInc) {
            $res['sendGroupInc'] = $this->sendGroupInc;
        }
        if (null !== $this->sendMessageStatus) {
            $res['sendMessageStatus'] = $this->sendMessageStatus;
        }
        if (null !== $this->sendTaskTimeStr) {
            $res['sendTaskTimeStr'] = $this->sendTaskTimeStr;
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
        if (isset($map['readGroupInc'])) {
            $model->readGroupInc = $map['readGroupInc'];
        }
        if (isset($map['sendGroupInc'])) {
            $model->sendGroupInc = $map['sendGroupInc'];
        }
        if (isset($map['sendMessageStatus'])) {
            $model->sendMessageStatus = $map['sendMessageStatus'];
        }
        if (isset($map['sendTaskTimeStr'])) {
            $model->sendTaskTimeStr = $map['sendTaskTimeStr'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }

        return $model;
    }
}
