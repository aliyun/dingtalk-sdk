<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vactivity_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateActivityResponseBody extends Model
{
    /**
     * @var string
     */
    public $activityId;
    protected $_name = [
        'activityId' => 'activityId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateActivityResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }

        return $model;
    }
}
