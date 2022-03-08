<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description activityId
     *
     * @var string
     */
    public $activityId;

    /**
     * @description activityName
     *
     * @var string
     */
    public $activityName;

    /**
     * @description activityNameEn
     *
     * @var string
     */
    public $activityNameInEnglish;
    protected $_name = [
        'activityId'            => 'activityId',
        'activityName'          => 'activityName',
        'activityNameInEnglish' => 'activityNameInEnglish',
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
        if (null !== $this->activityName) {
            $res['activityName'] = $this->activityName;
        }
        if (null !== $this->activityNameInEnglish) {
            $res['activityNameInEnglish'] = $this->activityNameInEnglish;
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
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['activityName'])) {
            $model->activityName = $map['activityName'];
        }
        if (isset($map['activityNameInEnglish'])) {
            $model->activityNameInEnglish = $map['activityNameInEnglish'];
        }

        return $model;
    }
}
