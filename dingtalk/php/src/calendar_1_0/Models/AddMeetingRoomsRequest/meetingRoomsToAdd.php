<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\AddMeetingRoomsRequest;

use AlibabaCloud\Tea\Model;

class meetingRoomsToAdd extends Model
{
    /**
     * @var string
     */
    public $roomId;
    protected $_name = [
        'roomId' => 'roomId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roomId) {
            $res['roomId'] = $this->roomId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return meetingRoomsToAdd
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roomId'])) {
            $model->roomId = $map['roomId'];
        }

        return $model;
    }
}
