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
     * @description 审批人userid列表。
     *
     * @var string[]
     */
    public $approverUserIds;

    /**
     * @description 审批附属实例列表，当已经通过的审批实例被修改或撤销，会生成一个新的实例，作为原有审批实例的附属。  如果想知道当前已经通过的审批实例的状态，可以依次遍历它的附属列表，查询里面每个实例的biz_action。
     *
     * @var string[]
     */
    public $attachedProcessInstanceIds;

    /**
     * @description 审批实例业务动作：  MODIFY：表示该审批实例是基于原来的实例修改而来  REVOKE：表示该审批实例是由原来的实例撤销后重新发起的  NONE表示正常发起
     *
     * @var string
     */
    public $bizAction;

    /**
     * @description 审批实例业务编号。
     *
     * @var string
     */
    public $businessId;

    /**
     * @description 抄送人userid列表。
     *
     * @var string[]
     */
    public $ccUserIds;

    /**
     * @description 创建时间。
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 结束时间。
     *
     * @var string
     */
    public $finishTime;

    /**
     * @description 表单详情列表。
     *
     * @var formComponentValues[]
     */
    public $formComponentValues;

    /**
     * @description 主流程实例标识。
     *
     * @var string
     */
    public $mainProcessInstanceId;

    /**
     * @description 操作记录列表。
     *
     * @var operationRecords[]
     */
    public $operationRecords;

    /**
     * @description 发起人的部门。-1表示根部门。
     *
     * @var string
     */
    public $originatorDeptId;

    /**
     * @description 发起人的部门名。
     *
     * @var string
     */
    public $originatorDeptName;

    /**
     * @description 发起人的userid。
     *
     * @var string
     */
    public $originatorUserId;

    /**
     * @description 审批结果：  agree：同意  refuse：拒绝。 说明 status为COMPLETED且result为同意时，表示审批单完结并审批通过。
     *
     * @var string
     */
    public $result;

    /**
     * @description 审批状态：  NEW：新创建  RUNNING：审批中  TERMINATED：被终止  COMPLETED：完成  CANCELED：取消
     *
     * @var string
     */
    public $status;

    /**
     * @description 任务列表。
     *
     * @var tasks[]
     */
    public $tasks;

    /**
     * @description 审批实例标题。
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'approverUserIds'            => 'approverUserIds',
        'attachedProcessInstanceIds' => 'attachedProcessInstanceIds',
        'bizAction'                  => 'bizAction',
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
