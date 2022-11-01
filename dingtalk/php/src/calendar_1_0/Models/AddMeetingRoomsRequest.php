<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddMeetingRoomsRequest\meetingRoomsToAdd;
use AlibabaCloud\Tea\Model;

class AddMeetingRoomsRequest extends Model
{
    /**
     * @var meetingRoomsToAdd[]
     */
    public $meetingRoomsToAdd;
    protected $_name = [
        'meetingRoomsToAdd' => 'meetingRoomsToAdd',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->meetingRoomsToAdd) {
            $res['meetingRoomsToAdd'] = [];
            if (null !== $this->meetingRoomsToAdd && \is_array($this->meetingRoomsToAdd)) {
                $n = 0;
                foreach ($this->meetingRoomsToAdd as $item) {
                    $res['meetingRoomsToAdd'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddMeetingRoomsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['meetingRoomsToAdd'])) {
            if (!empty($map['meetingRoomsToAdd'])) {
                $model->meetingRoomsToAdd = [];
                $n                        = 0;
                foreach ($map['meetingRoomsToAdd'] as $item) {
                    $model->meetingRoomsToAdd[$n++] = null !== $item ? meetingRoomsToAdd::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
