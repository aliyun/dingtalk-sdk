<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCancelOrDelTaskRequest\cardDTO;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCancelOrDelTaskRequest\taskExecutePersonDTOS;
use AlibabaCloud\Tea\Model;

class TaskInfoCancelOrDelTaskRequest extends Model
{
    /**
     * @var cardDTO
     */
    public $cardDTO;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorAccount;

    /**
     * @var string
     */
    public $outTaskId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $projId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $secretKey;

    /**
     * @var int
     */
    public $sendMsgFlag;

    /**
     * @var taskExecutePersonDTOS[]
     */
    public $taskExecutePersonDTOS;
    protected $_name = [
        'cardDTO'               => 'cardDTO',
        'operatorAccount'       => 'operatorAccount',
        'outTaskId'             => 'outTaskId',
        'projId'                => 'projId',
        'secretKey'             => 'secretKey',
        'sendMsgFlag'           => 'sendMsgFlag',
        'taskExecutePersonDTOS' => 'taskExecutePersonDTOS',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardDTO) {
            $res['cardDTO'] = null !== $this->cardDTO ? $this->cardDTO->toMap() : null;
        }
        if (null !== $this->operatorAccount) {
            $res['operatorAccount'] = $this->operatorAccount;
        }
        if (null !== $this->outTaskId) {
            $res['outTaskId'] = $this->outTaskId;
        }
        if (null !== $this->projId) {
            $res['projId'] = $this->projId;
        }
        if (null !== $this->secretKey) {
            $res['secretKey'] = $this->secretKey;
        }
        if (null !== $this->sendMsgFlag) {
            $res['sendMsgFlag'] = $this->sendMsgFlag;
        }
        if (null !== $this->taskExecutePersonDTOS) {
            $res['taskExecutePersonDTOS'] = [];
            if (null !== $this->taskExecutePersonDTOS && \is_array($this->taskExecutePersonDTOS)) {
                $n = 0;
                foreach ($this->taskExecutePersonDTOS as $item) {
                    $res['taskExecutePersonDTOS'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TaskInfoCancelOrDelTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardDTO'])) {
            $model->cardDTO = cardDTO::fromMap($map['cardDTO']);
        }
        if (isset($map['operatorAccount'])) {
            $model->operatorAccount = $map['operatorAccount'];
        }
        if (isset($map['outTaskId'])) {
            $model->outTaskId = $map['outTaskId'];
        }
        if (isset($map['projId'])) {
            $model->projId = $map['projId'];
        }
        if (isset($map['secretKey'])) {
            $model->secretKey = $map['secretKey'];
        }
        if (isset($map['sendMsgFlag'])) {
            $model->sendMsgFlag = $map['sendMsgFlag'];
        }
        if (isset($map['taskExecutePersonDTOS'])) {
            if (!empty($map['taskExecutePersonDTOS'])) {
                $model->taskExecutePersonDTOS = [];
                $n                            = 0;
                foreach ($map['taskExecutePersonDTOS'] as $item) {
                    $model->taskExecutePersonDTOS[$n++] = null !== $item ? taskExecutePersonDTOS::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
