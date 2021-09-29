<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetTaskCopiesResponseBody\data;

use AlibabaCloud\Tea\Model;

class currentActivityInstances extends Model
{
    /**
     * @description 节点名称
     *
     * @var string
     */
    public $activityName;

    /**
     * @description 节点英文名称
     *
     * @var string
     */
    public $activityNameInEnglish;

    /**
     * @description 节点id
     *
     * @var string
     */
    public $activityId;

    /**
     * @description 数据id
     *
     * @var int
     */
    public $id;

    /**
     * @description 节点实例状态
     *
     * @var string
     */
    public $activityInstanceStatus;
    protected $_name = [
        'activityName'           => 'activityName',
        'activityNameInEnglish'  => 'activityNameInEnglish',
        'activityId'             => 'activityId',
        'id'                     => 'id',
        'activityInstanceStatus' => 'activityInstanceStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityName) {
            $res['activityName'] = $this->activityName;
        }
        if (null !== $this->activityNameInEnglish) {
            $res['activityNameInEnglish'] = $this->activityNameInEnglish;
        }
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->activityInstanceStatus) {
            $res['activityInstanceStatus'] = $this->activityInstanceStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return currentActivityInstances
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityName'])) {
            $model->activityName = $map['activityName'];
        }
        if (isset($map['activityNameInEnglish'])) {
            $model->activityNameInEnglish = $map['activityNameInEnglish'];
        }
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['activityInstanceStatus'])) {
            $model->activityInstanceStatus = $map['activityInstanceStatus'];
        }

        return $model;
    }
}
