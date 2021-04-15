<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventRequest;

use AlibabaCloud\Tea\Model;

class start extends Model
{
    /**
     * @description 日程开始日期，如果是全天日程必须有值，非全天日程必须留空，格式：yyyy-MM-dd
     *
     * @var string
     */
    public $date;

    /**
     * @description 日程开始时间，非全天日程必须有值，全天日程必须留空，格式为ISO-8601的date-time格式
     *
     * @var string
     */
    public $dateTime;

    /**
     * @description 日程开始时间所属时区，非全天日程必须有值，全天日程必须留空，tz database name格式，参考：https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
     *
     * @var string
     */
    public $timeZone;
    protected $_name = [
        'date'     => 'date',
        'dateTime' => 'dateTime',
        'timeZone' => 'timeZone',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
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
     * @return start
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['dateTime'])) {
            $model->dateTime = $map['dateTime'];
        }
        if (isset($map['timeZone'])) {
            $model->timeZone = $map['timeZone'];
        }

        return $model;
    }
}
