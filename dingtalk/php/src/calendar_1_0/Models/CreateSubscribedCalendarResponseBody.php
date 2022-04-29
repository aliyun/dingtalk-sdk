<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSubscribedCalendarResponseBody extends Model
{
    /**
     * @description 日历id
     *
     * @var string
     */
    public $calendarId;
    protected $_name = [
        'calendarId' => 'calendarId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->calendarId) {
            $res['calendarId'] = $this->calendarId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSubscribedCalendarResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['calendarId'])) {
            $model->calendarId = $map['calendarId'];
        }

        return $model;
    }
}
