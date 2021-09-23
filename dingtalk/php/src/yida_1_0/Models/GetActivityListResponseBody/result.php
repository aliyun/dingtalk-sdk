<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetActivityListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
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

    /**
     * @description activityId
     *
     * @var string
     */
    public $activityId;
    protected $_name = [
        'activityName'          => 'activityName',
        'activityNameInEnglish' => 'activityNameInEnglish',
        'activityId'            => 'activityId',
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
        if (isset($map['activityName'])) {
            $model->activityName = $map['activityName'];
        }
        if (isset($map['activityNameInEnglish'])) {
            $model->activityNameInEnglish = $map['activityNameInEnglish'];
        }
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }

        return $model;
    }
}
