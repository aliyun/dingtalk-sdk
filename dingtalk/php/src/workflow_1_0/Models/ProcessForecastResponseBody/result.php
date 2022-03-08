<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules;
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
     * @description 是否静态流程
     *
     * @var bool
     */
    public $isStaticWorkflow;

    /**
     * @description 流程 code
     *
     * @var string
     */
    public $processCode;

    /**
     * @description 流程 id
     *
     * @var int
     */
    public $processId;

    /**
     * @description 用户 id
     *
     * @var string
     */
    public $userId;

    /**
     * @var workflowActivityRules[]
     */
    public $workflowActivityRules;

    /**
     * @var workflowForecastNodes[]
     */
    public $workflowForecastNodes;
    protected $_name = [
        'isForecastSuccess'     => 'isForecastSuccess',
        'isStaticWorkflow'      => 'isStaticWorkflow',
        'processCode'           => 'processCode',
        'processId'             => 'processId',
        'userId'                => 'userId',
        'workflowActivityRules' => 'workflowActivityRules',
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
        if (null !== $this->isStaticWorkflow) {
            $res['isStaticWorkflow'] = $this->isStaticWorkflow;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processId) {
            $res['processId'] = $this->processId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->workflowActivityRules) {
            $res['workflowActivityRules'] = [];
            if (null !== $this->workflowActivityRules && \is_array($this->workflowActivityRules)) {
                $n = 0;
                foreach ($this->workflowActivityRules as $item) {
                    $res['workflowActivityRules'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['isStaticWorkflow'])) {
            $model->isStaticWorkflow = $map['isStaticWorkflow'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processId'])) {
            $model->processId = $map['processId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['workflowActivityRules'])) {
            if (!empty($map['workflowActivityRules'])) {
                $model->workflowActivityRules = [];
                $n                            = 0;
                foreach ($map['workflowActivityRules'] as $item) {
                    $model->workflowActivityRules[$n++] = null !== $item ? workflowActivityRules::fromMap($item) : $item;
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
