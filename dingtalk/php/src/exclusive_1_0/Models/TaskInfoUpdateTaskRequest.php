<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoUpdateTaskRequest\attr;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoUpdateTaskRequest\cardDTO;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoUpdateTaskRequest\detailUrl;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoUpdateTaskRequest\taskExecutePersonDTOS;
use AlibabaCloud\Tea\Model;

class TaskInfoUpdateTaskRequest extends Model
{
    /**
     * @var attr
     */
    public $attr;

    /**
     * @var string
     */
    public $canceldelTaskCardId;

    /**
     * @var cardDTO
     */
    public $cardDTO;

    /**
     * @var detailUrl
     */
    public $detailUrl;

    /**
     * @var string
     */
    public $finishTaskCardId;

    /**
     * @var string[]
     */
    public $listOpenConversationId;

    /**
     * @var int
     */
    public $operateType;

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
     * @var string
     */
    public $startTaskCardId;

    /**
     * @var string
     */
    public $taskContent;

    /**
     * @var int
     */
    public $taskEndTime;

    /**
     * @var taskExecutePersonDTOS[]
     */
    public $taskExecutePersonDTOS;

    /**
     * @var string
     */
    public $taskTitle;

    /**
     * @var string
     */
    public $taskUrlMobile;

    /**
     * @var string
     */
    public $taskUrlPc;

    /**
     * @var string
     */
    public $updateTaskCardId;
    protected $_name = [
        'attr' => 'attr',
        'canceldelTaskCardId' => 'canceldelTaskCardId',
        'cardDTO' => 'cardDTO',
        'detailUrl' => 'detailUrl',
        'finishTaskCardId' => 'finishTaskCardId',
        'listOpenConversationId' => 'listOpenConversationId',
        'operateType' => 'operateType',
        'operatorAccount' => 'operatorAccount',
        'outTaskId' => 'outTaskId',
        'projId' => 'projId',
        'secretKey' => 'secretKey',
        'sendMsgFlag' => 'sendMsgFlag',
        'startTaskCardId' => 'startTaskCardId',
        'taskContent' => 'taskContent',
        'taskEndTime' => 'taskEndTime',
        'taskExecutePersonDTOS' => 'taskExecutePersonDTOS',
        'taskTitle' => 'taskTitle',
        'taskUrlMobile' => 'taskUrlMobile',
        'taskUrlPc' => 'taskUrlPc',
        'updateTaskCardId' => 'updateTaskCardId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attr) {
            $res['attr'] = null !== $this->attr ? $this->attr->toMap() : null;
        }
        if (null !== $this->canceldelTaskCardId) {
            $res['canceldelTaskCardId'] = $this->canceldelTaskCardId;
        }
        if (null !== $this->cardDTO) {
            $res['cardDTO'] = null !== $this->cardDTO ? $this->cardDTO->toMap() : null;
        }
        if (null !== $this->detailUrl) {
            $res['detailUrl'] = null !== $this->detailUrl ? $this->detailUrl->toMap() : null;
        }
        if (null !== $this->finishTaskCardId) {
            $res['finishTaskCardId'] = $this->finishTaskCardId;
        }
        if (null !== $this->listOpenConversationId) {
            $res['listOpenConversationId'] = $this->listOpenConversationId;
        }
        if (null !== $this->operateType) {
            $res['operateType'] = $this->operateType;
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
        if (null !== $this->startTaskCardId) {
            $res['startTaskCardId'] = $this->startTaskCardId;
        }
        if (null !== $this->taskContent) {
            $res['taskContent'] = $this->taskContent;
        }
        if (null !== $this->taskEndTime) {
            $res['taskEndTime'] = $this->taskEndTime;
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
        if (null !== $this->taskTitle) {
            $res['taskTitle'] = $this->taskTitle;
        }
        if (null !== $this->taskUrlMobile) {
            $res['taskUrlMobile'] = $this->taskUrlMobile;
        }
        if (null !== $this->taskUrlPc) {
            $res['taskUrlPc'] = $this->taskUrlPc;
        }
        if (null !== $this->updateTaskCardId) {
            $res['updateTaskCardId'] = $this->updateTaskCardId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TaskInfoUpdateTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attr'])) {
            $model->attr = attr::fromMap($map['attr']);
        }
        if (isset($map['canceldelTaskCardId'])) {
            $model->canceldelTaskCardId = $map['canceldelTaskCardId'];
        }
        if (isset($map['cardDTO'])) {
            $model->cardDTO = cardDTO::fromMap($map['cardDTO']);
        }
        if (isset($map['detailUrl'])) {
            $model->detailUrl = detailUrl::fromMap($map['detailUrl']);
        }
        if (isset($map['finishTaskCardId'])) {
            $model->finishTaskCardId = $map['finishTaskCardId'];
        }
        if (isset($map['listOpenConversationId'])) {
            if (!empty($map['listOpenConversationId'])) {
                $model->listOpenConversationId = $map['listOpenConversationId'];
            }
        }
        if (isset($map['operateType'])) {
            $model->operateType = $map['operateType'];
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
        if (isset($map['startTaskCardId'])) {
            $model->startTaskCardId = $map['startTaskCardId'];
        }
        if (isset($map['taskContent'])) {
            $model->taskContent = $map['taskContent'];
        }
        if (isset($map['taskEndTime'])) {
            $model->taskEndTime = $map['taskEndTime'];
        }
        if (isset($map['taskExecutePersonDTOS'])) {
            if (!empty($map['taskExecutePersonDTOS'])) {
                $model->taskExecutePersonDTOS = [];
                $n = 0;
                foreach ($map['taskExecutePersonDTOS'] as $item) {
                    $model->taskExecutePersonDTOS[$n++] = null !== $item ? taskExecutePersonDTOS::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['taskTitle'])) {
            $model->taskTitle = $map['taskTitle'];
        }
        if (isset($map['taskUrlMobile'])) {
            $model->taskUrlMobile = $map['taskUrlMobile'];
        }
        if (isset($map['taskUrlPc'])) {
            $model->taskUrlPc = $map['taskUrlPc'];
        }
        if (isset($map['updateTaskCardId'])) {
            $model->updateTaskCardId = $map['updateTaskCardId'];
        }

        return $model;
    }
}
