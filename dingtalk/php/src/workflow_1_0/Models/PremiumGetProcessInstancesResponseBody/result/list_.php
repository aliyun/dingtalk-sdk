<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetProcessInstancesResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetProcessInstancesResponseBody\result\list_\formComponentValues;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetProcessInstancesResponseBody\result\list_\operationRecords;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetProcessInstancesResponseBody\result\list_\tasks;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cdef-dae2fd2-example
     *
     * @var string
     */
    public $attachedProcessInstanceIds;

    /**
     * @description This parameter is required.
     *
     * @example 202110111558000355024
     *
     * @var string
     */
    public $businessId;

    /**
     * @description This parameter is required.
     *
     * @example 1635165470201
     *
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @example 1633795200000
     *
     * @var int
     */
    public $finishTime;

    /**
     * @description This parameter is required.
     *
     * @var formComponentValues[]
     */
    public $formComponentValues;

    /**
     * @description This parameter is required.
     *
     * @example dcdse-dae2fd2-example
     *
     * @var string
     */
    public $mainProcessInstanceId;

    /**
     * @var operationRecords[]
     */
    public $operationRecords;

    /**
     * @description This parameter is required.
     *
     * @example 默认-1，企业根部门
     *
     * @var string
     */
    public $originatorDeptId;

    /**
     * @description This parameter is required.
     *
     * @example staff1234
     *
     * @var string
     */
    public $originatorUserid;

    /**
     * @description This parameter is required.
     *
     * @example abcdse-dse-example
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description This parameter is required.
     *
     * @example AGREE同意，REFUSE拒绝
     *
     * @var string
     */
    public $result;

    /**
     * @description This parameter is required.
     *
     * @example RUNNING审批中、TERMINATED撤销、COMPLETED审批完成、CANCELED取消
     *
     * @var string
     */
    public $status;

    /**
     * @var tasks[]
     */
    public $tasks;

    /**
     * @description This parameter is required.
     *
     * @example 员工A提交的小肖审批单
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'attachedProcessInstanceIds' => 'attachedProcessInstanceIds',
        'businessId'                 => 'businessId',
        'createTime'                 => 'createTime',
        'finishTime'                 => 'finishTime',
        'formComponentValues'        => 'formComponentValues',
        'mainProcessInstanceId'      => 'mainProcessInstanceId',
        'operationRecords'           => 'operationRecords',
        'originatorDeptId'           => 'originatorDeptId',
        'originatorUserid'           => 'originatorUserid',
        'processInstanceId'          => 'processInstanceId',
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
        if (null !== $this->attachedProcessInstanceIds) {
            $res['attachedProcessInstanceIds'] = $this->attachedProcessInstanceIds;
        }
        if (null !== $this->businessId) {
            $res['businessId'] = $this->businessId;
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
        if (null !== $this->originatorUserid) {
            $res['originatorUserid'] = $this->originatorUserid;
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
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachedProcessInstanceIds'])) {
            $model->attachedProcessInstanceIds = $map['attachedProcessInstanceIds'];
        }
        if (isset($map['businessId'])) {
            $model->businessId = $map['businessId'];
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
        if (isset($map['originatorUserid'])) {
            $model->originatorUserid = $map['originatorUserid'];
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
