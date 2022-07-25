<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_\formComponentValues;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_\operationRecords;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_\tasks;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 附属单信息
     *
     * @var string
     */
    public $attachedProcessInstanceIds;

    /**
     * @description 审批单编号
     *
     * @var string
     */
    public $businessId;

    /**
     * @description 审批单创建时间
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 审批结束时间
     *
     * @var int
     */
    public $finishTime;

    /**
     * @var formComponentValues[]
     */
    public $formComponentValues;

    /**
     * @description 主单实例Id
     *
     * @var string
     */
    public $mainProcessInstanceId;

    /**
     * @description 审批单操作记录
     *
     * @var operationRecords[]
     */
    public $operationRecords;

    /**
     * @description 发起人部门id
     *
     * @var string
     */
    public $originatorDeptId;

    /**
     * @description 发起者userId
     *
     * @var string
     */
    public $originatorUserid;

    /**
     * @description 流程实例ID
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 审批结果
     *
     * @var string
     */
    public $result;

    /**
     * @description 审批单状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 任务列表
     *
     * @var tasks[]
     */
    public $tasks;

    /**
     * @description 审批单标题
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
