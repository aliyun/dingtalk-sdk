<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class CancelIntegratedTaskRequest extends Model
{
    /**
     * @description 待办组ID，需要在调用创建待办接口时，主动设置该值。
     *
     * @var string
     */
    public $activityId;

    /**
     * @description 待办组ID列表，用于批量取消。
     *
     * @var string[]
     */
    public $activityIds;

    /**
     * @description OA审批流程实例ID
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
