<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\SendLiveActivityRequest\activityEventData;
use AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\SendLiveActivityRequest\activityEventOption;
use AlibabaCloud\Tea\Model;

class SendLiveActivityRequest extends Model
{
    /**
     * @var activityEventData
     */
    public $activityEventData;

    /**
     * @var activityEventOption
     */
    public $activityEventOption;

    /**
     * @example bizUniqueId
     *
     * @var string
     */
    public $activityId;
    protected $_name = [
        'activityEventData' => 'activityEventData',
        'activityEventOption' => 'activityEventOption',
        'activityId' => 'activityId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityEventData) {
            $res['activityEventData'] = null !== $this->activityEventData ? $this->activityEventData->toMap() : null;
        }
        if (null !== $this->activityEventOption) {
            $res['activityEventOption'] = null !== $this->activityEventOption ? $this->activityEventOption->toMap() : null;
        }
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendLiveActivityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityEventData'])) {
            $model->activityEventData = activityEventData::fromMap($map['activityEventData']);
        }
        if (isset($map['activityEventOption'])) {
            $model->activityEventOption = activityEventOption::fromMap($map['activityEventOption']);
        }
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }

        return $model;
    }
}
