<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result;

use AlibabaCloud\Tea\Model;

class workflowForecastNodes extends Model
{
    /**
     * @description 节点 id
     *
     * @var string
     */
    public $activityId;

    /**
     * @description 节点出线 id
     *
     * @var string
     */
    public $outId;
    protected $_name = [
        'activityId' => 'activityId',
        'outId'      => 'outId',
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
        if (null !== $this->outId) {
            $res['outId'] = $this->outId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workflowForecastNodes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['outId'])) {
            $model->outId = $map['outId'];
        }

        return $model;
    }
}
