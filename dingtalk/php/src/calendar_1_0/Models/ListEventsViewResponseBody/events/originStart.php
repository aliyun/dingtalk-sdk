<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsViewResponseBody\events;

use AlibabaCloud\Tea\Model;

class originStart extends Model
{
    /**
     * @var string
     */
    public $dateTime;
    protected $_name = [
        'dateTime' => 'dateTime',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return originStart
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dateTime'])) {
            $model->dateTime = $map['dateTime'];
        }

        return $model;
    }
}
