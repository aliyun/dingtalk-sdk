<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListInstancesResponseBody\events;

use AlibabaCloud\Tea\Model;

class meetingRooms extends Model
{
    /**
     * @var string
     */
    public $displayName;

    /**
     * @var string
     */
    public $responseStatus;

    /**
     * @var string
     */
    public $roomId;
    protected $_name = [
        'displayName'    => 'displayName',
        'responseStatus' => 'responseStatus',
        'roomId'         => 'roomId',
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
        if (null !== $this->responseStatus) {
            $res['responseStatus'] = $this->responseStatus;
        }
        if (null !== $this->roomId) {
            $res['roomId'] = $this->roomId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return meetingRooms
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['responseStatus'])) {
            $model->responseStatus = $map['responseStatus'];
        }
        if (isset($map['roomId'])) {
            $model->roomId = $map['roomId'];
        }

        return $model;
    }
}
