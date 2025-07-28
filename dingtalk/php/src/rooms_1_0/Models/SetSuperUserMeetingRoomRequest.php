<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetSuperUserMeetingRoomRequest extends Model
{
    /**
     * @var int[]
     */
    public $deptIdWhiteList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $roomId;

    /**
     * @description This parameter is required.
     *
     * @example OcMXXXXXM2eRogiEiE
     *
     * @var string
     */
    public $unionId;

    /**
     * @var string[]
     */
    public $userIdWhiteList;
    protected $_name = [
        'deptIdWhiteList' => 'deptIdWhiteList',
        'roomId' => 'roomId',
        'unionId' => 'unionId',
        'userIdWhiteList' => 'userIdWhiteList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIdWhiteList) {
            $res['deptIdWhiteList'] = $this->deptIdWhiteList;
        }
        if (null !== $this->roomId) {
            $res['roomId'] = $this->roomId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userIdWhiteList) {
            $res['userIdWhiteList'] = $this->userIdWhiteList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetSuperUserMeetingRoomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIdWhiteList'])) {
            if (!empty($map['deptIdWhiteList'])) {
                $model->deptIdWhiteList = $map['deptIdWhiteList'];
            }
        }
        if (isset($map['roomId'])) {
            $model->roomId = $map['roomId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userIdWhiteList'])) {
            if (!empty($map['userIdWhiteList'])) {
                $model->userIdWhiteList = $map['userIdWhiteList'];
            }
        }

        return $model;
    }
}
