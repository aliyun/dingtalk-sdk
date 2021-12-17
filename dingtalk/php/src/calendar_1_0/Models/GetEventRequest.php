<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetEventRequest extends Model
{
    /**
     * @description 返回参与人，上限500人，默认为0
     *
     * @var int
     */
    public $maxAttendees;
    protected $_name = [
        'maxAttendees' => 'maxAttendees',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxAttendees) {
            $res['maxAttendees'] = $this->maxAttendees;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetEventRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxAttendees'])) {
            $model->maxAttendees = $map['maxAttendees'];
        }

        return $model;
    }
}
