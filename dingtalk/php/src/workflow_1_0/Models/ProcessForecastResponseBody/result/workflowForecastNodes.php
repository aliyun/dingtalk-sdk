<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result;

use AlibabaCloud\Tea\Model;

class workflowForecastNodes extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1cc3_959a
     *
     * @var string
     */
    public $activityId;

    /**
     * @description This parameter is required.
     *
     * @example line-random-1cc3_959a-831a_607b
     *
     * @var string
     */
    public $outId;
    protected $_name = [
        'activityId' => 'activityId',
        'outId' => 'outId',
    ];

    public function validate() {}

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
