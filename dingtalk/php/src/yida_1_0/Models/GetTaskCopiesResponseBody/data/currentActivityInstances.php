<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetTaskCopiesResponseBody\data;

use AlibabaCloud\Tea\Model;

class currentActivityInstances extends Model
{
    /**
     * @example act-xxaanfaf
     *
     * @var string
     */
    public $activityId;

    /**
     * @example running
     *
     * @var string
     */
    public $activityInstanceStatus;

    /**
     * @example activity-124
     *
     * @var string
     */
    public $activityName;

    /**
     * @example redirect task
     *
     * @var string
     */
    public $activityNameInEnglish;

    /**
     * @example 12345
     *
     * @var int
     */
    public $id;
    protected $_name = [
        'activityId'             => 'activityId',
        'activityInstanceStatus' => 'activityInstanceStatus',
        'activityName'           => 'activityName',
        'activityNameInEnglish'  => 'activityNameInEnglish',
        'id'                     => 'id',
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
        if (null !== $this->activityInstanceStatus) {
            $res['activityInstanceStatus'] = $this->activityInstanceStatus;
        }
        if (null !== $this->activityName) {
            $res['activityName'] = $this->activityName;
        }
        if (null !== $this->activityNameInEnglish) {
            $res['activityNameInEnglish'] = $this->activityNameInEnglish;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['activityInstanceStatus'])) {
            $model->activityInstanceStatus = $map['activityInstanceStatus'];
        }
        if (isset($map['activityName'])) {
            $model->activityName = $map['activityName'];
        }
        if (isset($map['activityNameInEnglish'])) {
            $model->activityNameInEnglish = $map['activityNameInEnglish'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }

        return $model;
    }
}
