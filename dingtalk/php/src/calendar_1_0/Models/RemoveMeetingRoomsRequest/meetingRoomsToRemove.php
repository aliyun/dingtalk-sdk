<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\RemoveMeetingRoomsRequest;

use AlibabaCloud\Tea\Model;

class meetingRoomsToRemove extends Model
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
     * @return meetingRoomsToRemove
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
