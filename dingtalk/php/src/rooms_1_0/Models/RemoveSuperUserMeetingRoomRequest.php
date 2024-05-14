<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveSuperUserMeetingRoomRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed
     *
     * @var string
     */
    public $roomId;

    /**
     * @description This parameter is required.
     *
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'roomId'  => 'roomId',
        'unionId' => 'unionId',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveSuperUserMeetingRoomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roomId'])) {
            $model->roomId = $map['roomId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
