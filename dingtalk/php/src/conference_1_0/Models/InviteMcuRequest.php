<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class InviteMcuRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $mcuRoomCode;

    /**
     * @description This parameter is required.
     *
     * @example 1234567890
     *
     * @var string
     */
    public $roomCode;

    /**
     * @description This parameter is required.
     *
     * @example qzR1iSMDvzR9iPXXXXXXXXXXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'mcuRoomCode' => 'mcuRoomCode',
        'roomCode' => 'roomCode',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mcuRoomCode) {
            $res['mcuRoomCode'] = $this->mcuRoomCode;
        }
        if (null !== $this->roomCode) {
            $res['roomCode'] = $this->roomCode;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InviteMcuRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mcuRoomCode'])) {
            $model->mcuRoomCode = $map['mcuRoomCode'];
        }
        if (isset($map['roomCode'])) {
            $model->roomCode = $map['roomCode'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
