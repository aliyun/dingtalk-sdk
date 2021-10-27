<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllProcessInstancesResponseBody\result\list_\formComponentValues;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 流程实例ID
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 主单实例Id
     *
     * @var string
     */
    public $mainProcessInstanceId;

    /**
     * @description 审批结束时间
     *
     * @var int
     */
    public $finishTime;

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
     * @description 审批单标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 发起人部门id
     *
     * @var string
     */
    public $originatorDeptId;

    /**
     * @description 审批结果
     *
     * @var string
     */
    public $result;

    /**
     * @description 审批单创建时间
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 发起者userId
     *
     * @var string
     */
    public $originatorUserid;

    /**
     * @description 审批单状态
     *
     * @var string
     */
    public $status;

    /**
     * @var formComponentValues[]
     */
    public $formComponentValues;
    protected $_name = [
        'processInstanceId'          => 'processInstanceId',
        'mainProcessInstanceId'      => 'mainProcessInstanceId',
        'finishTime'                 => 'finishTime',
        'attachedProcessInstanceIds' => 'attachedProcessInstanceIds',
        'businessId'                 => 'businessId',
        'title'                      => 'title',
        'originatorDeptId'           => 'originatorDeptId',
        'result'                     => 'result',
        'createTime'                 => 'createTime',
        'originatorUserid'           => 'originatorUserid',
        'status'                     => 'status',
        'formComponentValues'        => 'formComponentValues',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->mainProcessInstanceId) {
            $res['mainProcessInstanceId'] = $this->mainProcessInstanceId;
        }
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->attachedProcessInstanceIds) {
            $res['attachedProcessInstanceIds'] = $this->attachedProcessInstanceIds;
        }
        if (null !== $this->businessId) {
            $res['businessId'] = $this->businessId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->originatorDeptId) {
            $res['originatorDeptId'] = $this->originatorDeptId;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->originatorUserid) {
            $res['originatorUserid'] = $this->originatorUserid;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['mainProcessInstanceId'])) {
            $model->mainProcessInstanceId = $map['mainProcessInstanceId'];
        }
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['attachedProcessInstanceIds'])) {
            $model->attachedProcessInstanceIds = $map['attachedProcessInstanceIds'];
        }
        if (isset($map['businessId'])) {
            $model->businessId = $map['businessId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['originatorDeptId'])) {
            $model->originatorDeptId = $map['originatorDeptId'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['originatorUserid'])) {
            $model->originatorUserid = $map['originatorUserid'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
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

        return $model;
    }
}
