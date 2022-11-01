<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveMeetingRoomsRequest\meetingRoomsToRemove;
use AlibabaCloud\Tea\Model;

class RemoveMeetingRoomsRequest extends Model
{
    /**
     * @var meetingRoomsToRemove[]
     */
    public $meetingRoomsToRemove;
    protected $_name = [
        'meetingRoomsToRemove' => 'meetingRoomsToRemove',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->meetingRoomsToRemove) {
            $res['meetingRoomsToRemove'] = [];
            if (null !== $this->meetingRoomsToRemove && \is_array($this->meetingRoomsToRemove)) {
                $n = 0;
                foreach ($this->meetingRoomsToRemove as $item) {
                    $res['meetingRoomsToRemove'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveMeetingRoomsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['meetingRoomsToRemove'])) {
            if (!empty($map['meetingRoomsToRemove'])) {
                $model->meetingRoomsToRemove = [];
                $n                           = 0;
                foreach ($map['meetingRoomsToRemove'] as $item) {
                    $model->meetingRoomsToRemove[$n++] = null !== $item ? meetingRoomsToRemove::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
