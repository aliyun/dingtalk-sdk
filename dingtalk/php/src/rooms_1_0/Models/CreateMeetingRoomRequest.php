<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomRequest\reservationAuthority;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomRequest\roomLocation;
use AlibabaCloud\Tea\Model;

class CreateMeetingRoomRequest extends Model
{
    /**
     * @var bool
     */
    public $enableCycleReservation;

    /**
     * @example 0
     *
     * @var int
     */
    public $groupId;

    /**
     * @description This parameter is required.
     *
     * @example xxxIsvRoomId
     *
     * @var string
     */
    public $isvRoomId;

    /**
     * @var bool
     */
    public $openReservation;

    /**
     * @var reservationAuthority
     */
    public $reservationAuthority;

    /**
     * @example 10
     *
     * @var int
     */
    public $roomCapacity;

    /**
     * @var int[]
     */
    public $roomLabelIds;

    /**
     * @var roomLocation
     */
    public $roomLocation;

    /**
     * @description This parameter is required.
     *
     * @example 测试会议室
     *
     * @var string
     */
    public $roomName;

    /**
     * @example https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg
     *
     * @var string
     */
    public $roomPicture;

    /**
     * @description This parameter is required.
     *
     * @example 0.全员可用 1.仅管理员可用
     *
     * @var int
     */
    public $roomStatus;

    /**
     * @description This parameter is required.
     *
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'enableCycleReservation' => 'enableCycleReservation',
        'groupId' => 'groupId',
        'isvRoomId' => 'isvRoomId',
        'openReservation' => 'openReservation',
        'reservationAuthority' => 'reservationAuthority',
        'roomCapacity' => 'roomCapacity',
        'roomLabelIds' => 'roomLabelIds',
        'roomLocation' => 'roomLocation',
        'roomName' => 'roomName',
        'roomPicture' => 'roomPicture',
        'roomStatus' => 'roomStatus',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enableCycleReservation) {
            $res['enableCycleReservation'] = $this->enableCycleReservation;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->isvRoomId) {
            $res['isvRoomId'] = $this->isvRoomId;
        }
        if (null !== $this->openReservation) {
            $res['openReservation'] = $this->openReservation;
        }
        if (null !== $this->reservationAuthority) {
            $res['reservationAuthority'] = null !== $this->reservationAuthority ? $this->reservationAuthority->toMap() : null;
        }
        if (null !== $this->roomCapacity) {
            $res['roomCapacity'] = $this->roomCapacity;
        }
        if (null !== $this->roomLabelIds) {
            $res['roomLabelIds'] = $this->roomLabelIds;
        }
        if (null !== $this->roomLocation) {
            $res['roomLocation'] = null !== $this->roomLocation ? $this->roomLocation->toMap() : null;
        }
        if (null !== $this->roomName) {
            $res['roomName'] = $this->roomName;
        }
        if (null !== $this->roomPicture) {
            $res['roomPicture'] = $this->roomPicture;
        }
        if (null !== $this->roomStatus) {
            $res['roomStatus'] = $this->roomStatus;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateMeetingRoomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enableCycleReservation'])) {
            $model->enableCycleReservation = $map['enableCycleReservation'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['isvRoomId'])) {
            $model->isvRoomId = $map['isvRoomId'];
        }
        if (isset($map['openReservation'])) {
            $model->openReservation = $map['openReservation'];
        }
        if (isset($map['reservationAuthority'])) {
            $model->reservationAuthority = reservationAuthority::fromMap($map['reservationAuthority']);
        }
        if (isset($map['roomCapacity'])) {
            $model->roomCapacity = $map['roomCapacity'];
        }
        if (isset($map['roomLabelIds'])) {
            if (!empty($map['roomLabelIds'])) {
                $model->roomLabelIds = $map['roomLabelIds'];
            }
        }
        if (isset($map['roomLocation'])) {
            $model->roomLocation = roomLocation::fromMap($map['roomLocation']);
        }
        if (isset($map['roomName'])) {
            $model->roomName = $map['roomName'];
        }
        if (isset($map['roomPicture'])) {
            $model->roomPicture = $map['roomPicture'];
        }
        if (isset($map['roomStatus'])) {
            $model->roomStatus = $map['roomStatus'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
