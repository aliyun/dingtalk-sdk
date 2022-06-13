<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody;

use AlibabaCloud\Tea\Model;

class location extends Model
{
    /**
     * @var string
     */
    public $displayName;

    /**
     * @var string[]
     */
    public $meetingRooms;
    protected $_name = [
        'displayName'  => 'displayName',
        'meetingRooms' => 'meetingRooms',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->meetingRooms) {
            $res['meetingRooms'] = $this->meetingRooms;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return location
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['meetingRooms'])) {
            if (!empty($map['meetingRooms'])) {
                $model->meetingRooms = $map['meetingRooms'];
            }
        }

        return $model;
    }
}
