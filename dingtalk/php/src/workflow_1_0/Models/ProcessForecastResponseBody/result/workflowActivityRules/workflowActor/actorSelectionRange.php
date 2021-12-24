<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules\workflowActor;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules\workflowActor\actorSelectionRange\approvals;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules\workflowActor\actorSelectionRange\labels;
use AlibabaCloud\Tea\Model;

class actorSelectionRange extends Model
{
    /**
     * @description 审批指定成员
     *
     * @var approvals[]
     */
    public $approvals;

    /**
     * @description 审批指定角色
     *
     * @var labels[]
     */
    public $labels;
    protected $_name = [
        'approvals' => 'approvals',
        'labels'    => 'labels',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approvals) {
            $res['approvals'] = [];
            if (null !== $this->approvals && \is_array($this->approvals)) {
                $n = 0;
                foreach ($this->approvals as $item) {
                    $res['approvals'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->labels) {
            $res['labels'] = [];
            if (null !== $this->labels && \is_array($this->labels)) {
                $n = 0;
                foreach ($this->labels as $item) {
                    $res['labels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actorSelectionRange
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approvals'])) {
            if (!empty($map['approvals'])) {
                $model->approvals = [];
                $n                = 0;
                foreach ($map['approvals'] as $item) {
                    $model->approvals[$n++] = null !== $item ? approvals::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['labels'])) {
            if (!empty($map['labels'])) {
                $model->labels = [];
                $n             = 0;
                foreach ($map['labels'] as $item) {
                    $model->labels[$n++] = null !== $item ? labels::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
