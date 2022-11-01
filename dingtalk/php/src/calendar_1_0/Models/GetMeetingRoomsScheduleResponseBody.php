<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetMeetingRoomsScheduleResponseBody\scheduleInformation;
use AlibabaCloud\Tea\Model;

class GetMeetingRoomsScheduleResponseBody extends Model
{
    /**
     * @description 闲忙信息
     *
     * @var scheduleInformation[]
     */
    public $scheduleInformation;
    protected $_name = [
        'scheduleInformation' => 'scheduleInformation',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scheduleInformation) {
            $res['scheduleInformation'] = [];
            if (null !== $this->scheduleInformation && \is_array($this->scheduleInformation)) {
                $n = 0;
                foreach ($this->scheduleInformation as $item) {
                    $res['scheduleInformation'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMeetingRoomsScheduleResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scheduleInformation'])) {
            if (!empty($map['scheduleInformation'])) {
                $model->scheduleInformation = [];
                $n                          = 0;
                foreach ($map['scheduleInformation'] as $item) {
                    $model->scheduleInformation[$n++] = null !== $item ? scheduleInformation::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
