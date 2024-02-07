<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result\formComponentValues;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result\operationRecords;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result\tasks;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string[]
     */
    public $approverUserIds;

    /**
     * @example ["instance1","instance2"]
     *
     * @var string[]
     */
    public $attachedProcessInstanceIds;

    /**
     * @example MODIFY
     *
     * @var string
     */
    public $bizAction;

    /**
     * @example {"mykey": "myData"}
     *
     * @var string
     */
    public $bizData;

    /**
     * @example 111
     *
     * @var string
     */
    public $businessId;

    /**
     * @var string[]
     */
    public $ccUserIds;

    /**
     * @example 2022-08-31T11:52Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 2022-08-31T11:52Z
     *
     * @var string
     */
    public $finishTime;

    /**
     * @var formComponentValues[]
     */
    public $formComponentValues;

    /**
     * @example AG3U12xWRFex63h6bCPUWw10221698052827
     *
     * @var string
     */
    public $mainProcessInstanceId;

    /**
     * @var operationRecords[]
     */
    public $operationRecords;

    /**
     * @example -1
     *
     * @var string
     */
    public $originatorDeptId;

    /**
     * @example 测试
     *
     * @var string
     */
    public $originatorDeptName;

    /**
     * @example manager1
     *
     * @var string
     */
    public $originatorUserId;

    /**
     * @example agree
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
     * @var tasks[]
     */
    public $tasks;

    /**
     * @example xx提交的请假申请
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'approverUserIds'            => 'approverUserIds',
        'attachedProcessInstanceIds' => 'attachedProcessInstanceIds',
        'bizAction'                  => 'bizAction',
        'bizData'                    => 'bizData',
        'businessId'                 => 'businessId',
        'ccUserIds'                  => 'ccUserIds',
        'createTime'                 => 'createTime',
        'finishTime'                 => 'finishTime',
        'formComponentValues'        => 'formComponentValues',
        'mainProcessInstanceId'      => 'mainProcessInstanceId',
        'operationRecords'           => 'operationRecords',
        'originatorDeptId'           => 'originatorDeptId',
        'originatorDeptName'         => 'originatorDeptName',
        'originatorUserId'           => 'originatorUserId',
        'result'                     => 'result',
        'status'                     => 'status',
        'tasks'                      => 'tasks',
        'title'                      => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approverUserIds) {
            $res['approverUserIds'] = $this->approverUserIds;
        }
        if (null !== $this->attachedProcessInstanceIds) {
            $res['attachedProcessInstanceIds'] = $this->attachedProcessInstanceIds;
        }
        if (null !== $this->bizAction) {
            $res['bizAction'] = $this->bizAction;
        }
        if (null !== $this->bizData) {
            $res['bizData'] = $this->bizData;
        }
        if (null !== $this->businessId) {
            $res['businessId'] = $this->businessId;
        }
        if (null !== $this->ccUserIds) {
            $res['ccUserIds'] = $this->ccUserIds;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->formComponentValues) {
            $res['formComponentValues'] = [];
            if (null !== $this->formComponentValues && \is_array($this->formComponentValues)) {
                $n = 0;
                foreach ($this->formComponentValues as $item) {
                    $res['formComponentValues'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->mainProcessInstanceId) {
            $res['mainProcessInstanceId'] = $this->mainProcessInstanceId;
        }
        if (null !== $this->operationRecords) {
            $res['operationRecords'] = [];
            if (null !== $this->operationRecords && \is_array($this->operationRecords)) {
                $n = 0;
                foreach ($this->operationRecords as $item) {
                    $res['operationRecords'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->originatorDeptId) {
            $res['originatorDeptId'] = $this->originatorDeptId;
        }
        if (null !== $this->originatorDeptName) {
            $res['originatorDeptName'] = $this->originatorDeptName;
        }
        if (null !== $this->originatorUserId) {
            $res['originatorUserId'] = $this->originatorUserId;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->tasks) {
            $res['tasks'] = [];
            if (null !== $this->tasks && \is_array($this->tasks)) {
                $n = 0;
                foreach ($this->tasks as $item) {
                    $res['tasks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approverUserIds'])) {
            if (!empty($map['approverUserIds'])) {
                $model->approverUserIds = $map['approverUserIds'];
            }
        }
        if (isset($map['attachedProcessInstanceIds'])) {
            if (!empty($map['attachedProcessInstanceIds'])) {
                $model->attachedProcessInstanceIds = $map['attachedProcessInstanceIds'];
            }
        }
        if (isset($map['bizAction'])) {
            $model->bizAction = $map['bizAction'];
        }
        if (isset($map['bizData'])) {
            $model->bizData = $map['bizData'];
        }
        if (isset($map['businessId'])) {
            $model->businessId = $map['businessId'];
        }
        if (isset($map['ccUserIds'])) {
            if (!empty($map['ccUserIds'])) {
                $model->ccUserIds = $map['ccUserIds'];
            }
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['formComponentValues'])) {
            if (!empty($map['formComponentValues'])) {
                $model->formComponentValues = [];
                $n                          = 0;
                foreach ($map['formComponentValues'] as $item) {
                    $model->formComponentValues[$n++] = null !== $item ? formComponentValues::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['mainProcessInstanceId'])) {
            $model->mainProcessInstanceId = $map['mainProcessInstanceId'];
        }
        if (isset($map['operationRecords'])) {
            if (!empty($map['operationRecords'])) {
                $model->operationRecords = [];
                $n                       = 0;
                foreach ($map['operationRecords'] as $item) {
                    $model->operationRecords[$n++] = null !== $item ? operationRecords::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['originatorDeptId'])) {
            $model->originatorDeptId = $map['originatorDeptId'];
        }
        if (isset($map['originatorDeptName'])) {
            $model->originatorDeptName = $map['originatorDeptName'];
        }
        if (isset($map['originatorUserId'])) {
            $model->originatorUserId = $map['originatorUserId'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['tasks'])) {
            if (!empty($map['tasks'])) {
                $model->tasks = [];
                $n            = 0;
                foreach ($map['tasks'] as $item) {
                    $model->tasks[$n++] = null !== $item ? tasks::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
