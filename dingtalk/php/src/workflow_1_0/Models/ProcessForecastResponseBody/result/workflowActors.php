<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActors\activityActors;
use AlibabaCloud\Tea\Model;

class workflowActors extends Model
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
     * @var activityActors[]
     */
    public $activityActors;

    /**
     * @description 是否联系人控件审批人节点
     *
     * @var bool
     */
    public $isTargetFormComponent;

    /**
     * @description 节点规则，当前是一个 JSONObject
     *
     * @var string
     */
    public $node;
    protected $_name = [
        'activityId'            => 'activityId',
        'activityName'          => 'activityName',
        'activityType'          => 'activityType',
        'isTargetSelect'        => 'isTargetSelect',
        'activityActors'        => 'activityActors',
        'isTargetFormComponent' => 'isTargetFormComponent',
        'node'                  => 'node',
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
        if (null !== $this->activityActors) {
            $res['activityActors'] = [];
            if (null !== $this->activityActors && \is_array($this->activityActors)) {
                $n = 0;
                foreach ($this->activityActors as $item) {
                    $res['activityActors'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isTargetFormComponent) {
            $res['isTargetFormComponent'] = $this->isTargetFormComponent;
        }
        if (null !== $this->node) {
            $res['node'] = $this->node;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workflowActors
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
        if (isset($map['activityActors'])) {
            if (!empty($map['activityActors'])) {
                $model->activityActors = [];
                $n                     = 0;
                foreach ($map['activityActors'] as $item) {
                    $model->activityActors[$n++] = null !== $item ? activityActors::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isTargetFormComponent'])) {
            $model->isTargetFormComponent = $map['isTargetFormComponent'];
        }
        if (isset($map['node'])) {
            $model->node = $map['node'];
        }

        return $model;
    }
}
