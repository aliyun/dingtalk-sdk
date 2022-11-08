<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleResponseBody\scheduleInformation\scheduleItems;

use AlibabaCloud\Tea\Model;

class end extends Model
{
    /**
     * @description 结束时间戳，按照ISO 8601格式
     *
     * @var string
     */
    public $dateTime;

    /**
     * @description 时间戳所属时区
     *
     * @var string
     */
    public $timeZone;
    protected $_name = [
        'dateTime' => 'dateTime',
        'timeZone' => 'timeZone',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dateTime) {
            $res['dateTime'] = $this->dateTime;
        }
        if (null !== $this->timeZone) {
            $res['timeZone'] = $this->timeZone;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return end
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dateTime'])) {
            $model->dateTime = $map['dateTime'];
        }
        if (isset($map['timeZone'])) {
            $model->timeZone = $map['timeZone'];
        }

        return $model;
    }
}
