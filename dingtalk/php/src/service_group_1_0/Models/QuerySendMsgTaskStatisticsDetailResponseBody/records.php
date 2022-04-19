<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QuerySendMsgTaskStatisticsDetailResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @var string
     */
    public $openBatchTaskId;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var int
     */
    public $readStatus;

    /**
     * @var string
     */
    public $readTimeStr;

    /**
     * @var string
     */
    public $receiverName;

    /**
     * @var string
     */
    public $receiverUnionId;
    protected $_name = [
        'openBatchTaskId'    => 'openBatchTaskId',
        'openConversationId' => 'openConversationId',
        'readStatus'         => 'readStatus',
        'readTimeStr'        => 'readTimeStr',
        'receiverName'       => 'receiverName',
        'receiverUnionId'    => 'receiverUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openBatchTaskId) {
            $res['openBatchTaskId'] = $this->openBatchTaskId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->readStatus) {
            $res['readStatus'] = $this->readStatus;
        }
        if (null !== $this->readTimeStr) {
            $res['readTimeStr'] = $this->readTimeStr;
        }
        if (null !== $this->receiverName) {
            $res['receiverName'] = $this->receiverName;
        }
        if (null !== $this->receiverUnionId) {
            $res['receiverUnionId'] = $this->receiverUnionId;
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
        if (isset($map['openBatchTaskId'])) {
            $model->openBatchTaskId = $map['openBatchTaskId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['readStatus'])) {
            $model->readStatus = $map['readStatus'];
        }
        if (isset($map['readTimeStr'])) {
            $model->readTimeStr = $map['readTimeStr'];
        }
        if (isset($map['receiverName'])) {
            $model->receiverName = $map['receiverName'];
        }
        if (isset($map['receiverUnionId'])) {
            $model->receiverUnionId = $map['receiverUnionId'];
        }

        return $model;
    }
}
