<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListTicketOperateRecordResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListTicketOperateRecordResponseBody\records\operator;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListTicketOperateRecordResponseBody\records\ticketMemo;
use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @description 工单开放ID
     *
     * @var string
     */
    public $openTicketId;

    /**
     * @var string
     */
    public $operateData;

    /**
     * @description 操作时间
     *
     * @var string
     */
    public $operateTime;

    /**
     * @description 动作
     *
     * @var string
     */
    public $operation;

    /**
     * @description 动作展示名
     *
     * @var string
     */
    public $operationDisplayName;

    /**
     * @var operator
     */
    public $operator;

    /**
     * @var ticketMemo
     */
    public $ticketMemo;
    protected $_name = [
        'openTicketId'         => 'openTicketId',
        'operateData'          => 'operateData',
        'operateTime'          => 'operateTime',
        'operation'            => 'operation',
        'operationDisplayName' => 'operationDisplayName',
        'operator'             => 'operator',
        'ticketMemo'           => 'ticketMemo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openTicketId) {
            $res['openTicketId'] = $this->openTicketId;
        }
        if (null !== $this->operateData) {
            $res['operateData'] = $this->operateData;
        }
        if (null !== $this->operateTime) {
            $res['operateTime'] = $this->operateTime;
        }
        if (null !== $this->operation) {
            $res['operation'] = $this->operation;
        }
        if (null !== $this->operationDisplayName) {
            $res['operationDisplayName'] = $this->operationDisplayName;
        }
        if (null !== $this->operator) {
            $res['operator'] = null !== $this->operator ? $this->operator->toMap() : null;
        }
        if (null !== $this->ticketMemo) {
            $res['ticketMemo'] = null !== $this->ticketMemo ? $this->ticketMemo->toMap() : null;
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
        if (isset($map['openTicketId'])) {
            $model->openTicketId = $map['openTicketId'];
        }
        if (isset($map['operateData'])) {
            $model->operateData = $map['operateData'];
        }
        if (isset($map['operateTime'])) {
            $model->operateTime = $map['operateTime'];
        }
        if (isset($map['operation'])) {
            $model->operation = $map['operation'];
        }
        if (isset($map['operationDisplayName'])) {
            $model->operationDisplayName = $map['operationDisplayName'];
        }
        if (isset($map['operator'])) {
            $model->operator = operator::fromMap($map['operator']);
        }
        if (isset($map['ticketMemo'])) {
            $model->ticketMemo = ticketMemo::fromMap($map['ticketMemo']);
        }

        return $model;
    }
}
