<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsInstancesResponseBody\events;

use AlibabaCloud\Tea\Model;

class reminders extends Model
{
    /**
     * @example dingtalk
     *
     * @var string
     */
    public $method;

    /**
     * @example 0
     *
     * @var string
     */
    public $minutes;
    protected $_name = [
        'method'  => 'method',
        'minutes' => 'minutes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->method) {
            $res['method'] = $this->method;
        }
        if (null !== $this->minutes) {
            $res['minutes'] = $this->minutes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reminders
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['method'])) {
            $model->method = $map['method'];
        }
        if (isset($map['minutes'])) {
            $model->minutes = $map['minutes'];
        }

        return $model;
    }
}
