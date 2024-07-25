<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest\attr;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest\backlogDTO;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest\cardDTO;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest\detailUrl;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest\taskExecutePersonDTOS;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest\taskGroupDTOList;
use AlibabaCloud\Tea\Model;

class TaskInfoCreateAndStartTaskRequest extends Model
{
    /**
     * @var attr
     */
    public $attr;

    /**
     * @var backlogDTO
     */
    public $backlogDTO;

    /**
     * @var int
     */
    public $backlogGenerateFlag;

    /**
     * @var string
     */
    public $businessCode;

    /**
     * @var string
     */
    public $canceldelTaskCardId;

    /**
     * @var cardDTO
     */
    public $cardDTO;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $customFlag;

    /**
     * @var detailUrl
     */
    public $detailUrl;

    /**
     * @var string
     */
    public $finishTaskCardId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorAccount;

    /**
     * @description This parameter is required.
     *
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
     * @var string
     */
    public $robotCode;

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
     * @var int
     */
    public $sort;

    /**
     * @var string
     */
    public $startTaskCardId;

    /**
     * @var int
     */
    public $state;

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
     * @var taskGroupDTOList[]
     */
    public $taskGroupDTOList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $taskSystem;

    /**
     * @var string
     */
    public $taskTemplCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $taskTitle;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $taskType;

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
        'attr'                  => 'attr',
        'backlogDTO'            => 'backlogDTO',
        'backlogGenerateFlag'   => 'backlogGenerateFlag',
        'businessCode'          => 'businessCode',
        'canceldelTaskCardId'   => 'canceldelTaskCardId',
        'cardDTO'               => 'cardDTO',
        'customFlag'            => 'customFlag',
        'detailUrl'             => 'detailUrl',
        'finishTaskCardId'      => 'finishTaskCardId',
        'operatorAccount'       => 'operatorAccount',
        'outTaskId'             => 'outTaskId',
        'projId'                => 'projId',
        'robotCode'             => 'robotCode',
        'secretKey'             => 'secretKey',
        'sendMsgFlag'           => 'sendMsgFlag',
        'sort'                  => 'sort',
        'startTaskCardId'       => 'startTaskCardId',
        'state'                 => 'state',
        'taskContent'           => 'taskContent',
        'taskEndTime'           => 'taskEndTime',
        'taskExecutePersonDTOS' => 'taskExecutePersonDTOS',
        'taskGroupDTOList'      => 'taskGroupDTOList',
        'taskSystem'            => 'taskSystem',
        'taskTemplCode'         => 'taskTemplCode',
        'taskTitle'             => 'taskTitle',
        'taskType'              => 'taskType',
        'taskUrlMobile'         => 'taskUrlMobile',
        'taskUrlPc'             => 'taskUrlPc',
        'updateTaskCardId'      => 'updateTaskCardId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attr) {
            $res['attr'] = null !== $this->attr ? $this->attr->toMap() : null;
        }
        if (null !== $this->backlogDTO) {
            $res['backlogDTO'] = null !== $this->backlogDTO ? $this->backlogDTO->toMap() : null;
        }
        if (null !== $this->backlogGenerateFlag) {
            $res['backlogGenerateFlag'] = $this->backlogGenerateFlag;
        }
        if (null !== $this->businessCode) {
            $res['businessCode'] = $this->businessCode;
        }
        if (null !== $this->canceldelTaskCardId) {
            $res['canceldelTaskCardId'] = $this->canceldelTaskCardId;
        }
        if (null !== $this->cardDTO) {
            $res['cardDTO'] = null !== $this->cardDTO ? $this->cardDTO->toMap() : null;
        }
        if (null !== $this->customFlag) {
            $res['customFlag'] = $this->customFlag;
        }
        if (null !== $this->detailUrl) {
            $res['detailUrl'] = null !== $this->detailUrl ? $this->detailUrl->toMap() : null;
        }
        if (null !== $this->finishTaskCardId) {
            $res['finishTaskCardId'] = $this->finishTaskCardId;
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
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->secretKey) {
            $res['secretKey'] = $this->secretKey;
        }
        if (null !== $this->sendMsgFlag) {
            $res['sendMsgFlag'] = $this->sendMsgFlag;
        }
        if (null !== $this->sort) {
            $res['sort'] = $this->sort;
        }
        if (null !== $this->startTaskCardId) {
            $res['startTaskCardId'] = $this->startTaskCardId;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
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
        if (null !== $this->taskGroupDTOList) {
            $res['taskGroupDTOList'] = [];
            if (null !== $this->taskGroupDTOList && \is_array($this->taskGroupDTOList)) {
                $n = 0;
                foreach ($this->taskGroupDTOList as $item) {
                    $res['taskGroupDTOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->taskSystem) {
            $res['taskSystem'] = $this->taskSystem;
        }
        if (null !== $this->taskTemplCode) {
            $res['taskTemplCode'] = $this->taskTemplCode;
        }
        if (null !== $this->taskTitle) {
            $res['taskTitle'] = $this->taskTitle;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
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
     * @return TaskInfoCreateAndStartTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attr'])) {
            $model->attr = attr::fromMap($map['attr']);
        }
        if (isset($map['backlogDTO'])) {
            $model->backlogDTO = backlogDTO::fromMap($map['backlogDTO']);
        }
        if (isset($map['backlogGenerateFlag'])) {
            $model->backlogGenerateFlag = $map['backlogGenerateFlag'];
        }
        if (isset($map['businessCode'])) {
            $model->businessCode = $map['businessCode'];
        }
        if (isset($map['canceldelTaskCardId'])) {
            $model->canceldelTaskCardId = $map['canceldelTaskCardId'];
        }
        if (isset($map['cardDTO'])) {
            $model->cardDTO = cardDTO::fromMap($map['cardDTO']);
        }
        if (isset($map['customFlag'])) {
            $model->customFlag = $map['customFlag'];
        }
        if (isset($map['detailUrl'])) {
            $model->detailUrl = detailUrl::fromMap($map['detailUrl']);
        }
        if (isset($map['finishTaskCardId'])) {
            $model->finishTaskCardId = $map['finishTaskCardId'];
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
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['secretKey'])) {
            $model->secretKey = $map['secretKey'];
        }
        if (isset($map['sendMsgFlag'])) {
            $model->sendMsgFlag = $map['sendMsgFlag'];
        }
        if (isset($map['sort'])) {
            $model->sort = $map['sort'];
        }
        if (isset($map['startTaskCardId'])) {
            $model->startTaskCardId = $map['startTaskCardId'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
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
                $n                            = 0;
                foreach ($map['taskExecutePersonDTOS'] as $item) {
                    $model->taskExecutePersonDTOS[$n++] = null !== $item ? taskExecutePersonDTOS::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['taskGroupDTOList'])) {
            if (!empty($map['taskGroupDTOList'])) {
                $model->taskGroupDTOList = [];
                $n                       = 0;
                foreach ($map['taskGroupDTOList'] as $item) {
                    $model->taskGroupDTOList[$n++] = null !== $item ? taskGroupDTOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['taskSystem'])) {
            $model->taskSystem = $map['taskSystem'];
        }
        if (isset($map['taskTemplCode'])) {
            $model->taskTemplCode = $map['taskTemplCode'];
        }
        if (isset($map['taskTitle'])) {
            $model->taskTitle = $map['taskTitle'];
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
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
