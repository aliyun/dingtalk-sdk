<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class CancelIntegratedTaskRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example act_xxxx
     *
     * @var string
     */
    public $activityId;

    /**
     * @var string[]
     */
    public $activityIds;

    /**
     * @description This parameter is required.
     *
     * @example tPr_FB_mT_xxxxxxxxx2hQ05201655306463
     *
     * @var string
     */
    public $processInstanceId;
    protected $_name = [
        'activityId'        => 'activityId',
        'activityIds'       => 'activityIds',
        'processInstanceId' => 'processInstanceId',
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
        if (null !== $this->activityIds) {
            $res['activityIds'] = $this->activityIds;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CancelIntegratedTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['activityIds'])) {
            if (!empty($map['activityIds'])) {
                $model->activityIds = $map['activityIds'];
            }
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }

        return $model;
    }
}
