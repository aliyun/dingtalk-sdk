<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules\workflowActor;
use AlibabaCloud\Tea\Model;

class workflowActivityRules extends Model
{
    /**
     * @description 节点 id
     *
     * @var string
     */
    public $activityId;

    /**
     * @description 节点名称
     *
     * @var string
     */
    public $activityName;

    /**
     * @description 规则类型
     *
     * @var string
     */
    public $activityType;

    /**
     * @description 是否自选审批节点
     *
     * @var bool
     */
    public $isTargetSelect;

    /**
     * @description 流程中前一个节点的 id
     *
     * @var string
     */
    public $prevActivityId;

    /**
     * @description 节点操作人信息
     *
     * @var workflowActor
     */
    public $workflowActor;
    protected $_name = [
        'activityId'     => 'activityId',
        'activityName'   => 'activityName',
        'activityType'   => 'activityType',
        'isTargetSelect' => 'isTargetSelect',
        'prevActivityId' => 'prevActivityId',
        'workflowActor'  => 'workflowActor',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->activityName) {
            $res['activityName'] = $this->activityName;
        }
        if (null !== $this->activityType) {
            $res['activityType'] = $this->activityType;
        }
        if (null !== $this->isTargetSelect) {
            $res['isTargetSelect'] = $this->isTargetSelect;
        }
        if (null !== $this->prevActivityId) {
            $res['prevActivityId'] = $this->prevActivityId;
        }
        if (null !== $this->workflowActor) {
            $res['workflowActor'] = null !== $this->workflowActor ? $this->workflowActor->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workflowActivityRules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['activityName'])) {
            $model->activityName = $map['activityName'];
        }
        if (isset($map['activityType'])) {
            $model->activityType = $map['activityType'];
        }
        if (isset($map['isTargetSelect'])) {
            $model->isTargetSelect = $map['isTargetSelect'];
        }
        if (isset($map['prevActivityId'])) {
            $model->prevActivityId = $map['prevActivityId'];
        }
        if (isset($map['workflowActor'])) {
            $model->workflowActor = workflowActor::fromMap($map['workflowActor']);
        }

        return $model;
    }
}
