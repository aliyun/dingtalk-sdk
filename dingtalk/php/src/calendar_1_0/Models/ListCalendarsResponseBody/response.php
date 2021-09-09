<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListCalendarsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListCalendarsResponseBody\response\calendars;
use AlibabaCloud\Tea\Model;

class response extends Model
{
    /**
     * @var calendars[]
     */
    public $calendars;
    protected $_name = [
        'calendars' => 'calendars',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->calendars) {
            $res['calendars'] = [];
            if (null !== $this->calendars && \is_array($this->calendars)) {
                $n = 0;
                foreach ($this->calendars as $item) {
                    $res['calendars'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return response
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['calendars'])) {
            if (!empty($map['calendars'])) {
                $model->calendars = [];
                $n                = 0;
                foreach ($map['calendars'] as $item) {
                    $model->calendars[$n++] = null !== $item ? calendars::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
