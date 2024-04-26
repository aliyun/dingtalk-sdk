<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryScheduleConfSettingsRequest extends Model
{
    /**
     * @var string
     */
    public $scheduleConferenceId;
    protected $_name = [
        'scheduleConferenceId' => 'scheduleConferenceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scheduleConferenceId) {
            $res['scheduleConferenceId'] = $this->scheduleConferenceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryScheduleConfSettingsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scheduleConferenceId'])) {
            $model->scheduleConferenceId = $map['scheduleConferenceId'];
        }

        return $model;
    }
}
