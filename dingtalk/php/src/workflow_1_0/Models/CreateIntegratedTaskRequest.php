<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CreateIntegratedTaskRequest\tasks;
use AlibabaCloud\Tea\Model;

class CreateIntegratedTaskRequest extends Model
{
    /**
     * @description 待办组ID，调用方提供自定义唯一分组标识
     *
     * @var string
     */
    public $activityId;

    /**
     * @description OA审批实例ID，通过创建实例接口获取。
     *
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 任务列表
     *
     * @var tasks[]
     */
    public $tasks;
    protected $_name = [
        'activityId'        => 'activityId',
        'processInstanceId' => 'processInstanceId',
        'tasks'             => 'tasks',
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
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateIntegratedTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
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

        return $model;
    }
}
