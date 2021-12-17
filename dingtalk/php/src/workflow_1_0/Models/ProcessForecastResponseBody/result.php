<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActors;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowForecastNodes;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 是否预测成功
     *
     * @var bool
     */
    public $isForecastSuccess;

    /**
     * @description 流程 code
     *
     * @var string
     */
    public $processCode;

    /**
     * @description 用户 id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 流程 id
     *
     * @var int
     */
    public $processId;

    /**
     * @description 是否静态流程
     *
     * @var bool
     */
    public $isStaticWorkflow;

    /**
     * @var workflowActors[]
     */
    public $workflowActors;

    /**
     * @var workflowForecastNodes[]
     */
    public $workflowForecastNodes;
    protected $_name = [
        'isForecastSuccess'     => 'isForecastSuccess',
        'processCode'           => 'processCode',
        'userId'                => 'userId',
        'processId'             => 'processId',
        'isStaticWorkflow'      => 'isStaticWorkflow',
        'workflowActors'        => 'workflowActors',
        'workflowForecastNodes' => 'workflowForecastNodes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isForecastSuccess) {
            $res['isForecastSuccess'] = $this->isForecastSuccess;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->processId) {
            $res['processId'] = $this->processId;
        }
        if (null !== $this->isStaticWorkflow) {
            $res['isStaticWorkflow'] = $this->isStaticWorkflow;
        }
        if (null !== $this->workflowActors) {
            $res['workflowActors'] = [];
            if (null !== $this->workflowActors && \is_array($this->workflowActors)) {
                $n = 0;
                foreach ($this->workflowActors as $item) {
                    $res['workflowActors'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->workflowForecastNodes) {
            $res['workflowForecastNodes'] = [];
            if (null !== $this->workflowForecastNodes && \is_array($this->workflowForecastNodes)) {
                $n = 0;
                foreach ($this->workflowForecastNodes as $item) {
                    $res['workflowForecastNodes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['isForecastSuccess'])) {
            $model->isForecastSuccess = $map['isForecastSuccess'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['processId'])) {
            $model->processId = $map['processId'];
        }
        if (isset($map['isStaticWorkflow'])) {
            $model->isStaticWorkflow = $map['isStaticWorkflow'];
        }
        if (isset($map['workflowActors'])) {
            if (!empty($map['workflowActors'])) {
                $model->workflowActors = [];
                $n                     = 0;
                foreach ($map['workflowActors'] as $item) {
                    $model->workflowActors[$n++] = null !== $item ? workflowActors::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['workflowForecastNodes'])) {
            if (!empty($map['workflowForecastNodes'])) {
                $model->workflowForecastNodes = [];
                $n                            = 0;
                foreach ($map['workflowForecastNodes'] as $item) {
                    $model->workflowForecastNodes[$n++] = null !== $item ? workflowForecastNodes::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
