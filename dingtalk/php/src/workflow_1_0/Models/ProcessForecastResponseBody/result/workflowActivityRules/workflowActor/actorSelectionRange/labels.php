<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules\workflowActor\actorSelectionRange;

use AlibabaCloud\Tea\Model;

class labels extends Model
{
    /**
     * @description 角色 id
     *
     * @var string
     */
    public $labels;

    /**
     * @description 角色名字
     *
     * @var string
     */
    public $labelNames;
    protected $_name = [
        'labels'     => 'labels',
        'labelNames' => 'labelNames',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->labels) {
            $res['labels'] = $this->labels;
        }
        if (null !== $this->labelNames) {
            $res['labelNames'] = $this->labelNames;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return labels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labels'])) {
            $model->labels = $map['labels'];
        }
        if (isset($map['labelNames'])) {
            $model->labelNames = $map['labelNames'];
        }

        return $model;
    }
}
