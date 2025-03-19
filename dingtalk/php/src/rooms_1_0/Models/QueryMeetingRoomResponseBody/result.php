<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\extensionConfig;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\reservationAuthority;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\roomGroup;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\roomLabels;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomResponseBody\result\roomLocation;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example ding994a046bca84545935c2f4657eb6378f
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $deviceUnionIds;

    /**
     * @var bool
     */
    public $enableCycleReservation;

    /**
     * @var extensionConfig
     */
    public $extensionConfig;

    /**
     * @example xxxIsvRoomId
     *
     * @var string
     */
    public $isvRoomId;

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
     * @var roomGroup
     */
    public $roomGroup;

    /**
     * @example 0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed
     *
     * @var string
     */
    public $roomId;

    /**
     * @var roomLabels[]
     */
    public $roomLabels;

    /**
     * @var roomLocation
     */
    public $roomLocation;

    /**
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
     * @example 01224148194623278976
     *
     * @var string
     */
    public $roomStaffId;

    /**
     * @example 0.全员可用 1.仅管理员可用
     *
     * @var int
     */
    public $roomStatus;

    /**
     * @example DtB8VDzXXXXXX41rgiE
     *
     * @var string
     */
    public $roomUnionId;
    protected $_name = [
        'corpId' => 'corpId',
        'deviceUnionIds' => 'deviceUnionIds',
        'enableCycleReservation' => 'enableCycleReservation',
        'extensionConfig' => 'extensionConfig',
        'isvRoomId' => 'isvRoomId',
        'reservationAuthority' => 'reservationAuthority',
        'roomCapacity' => 'roomCapacity',
        'roomGroup' => 'roomGroup',
        'roomId' => 'roomId',
        'roomLabels' => 'roomLabels',
        'roomLocation' => 'roomLocation',
        'roomName' => 'roomName',
        'roomPicture' => 'roomPicture',
        'roomStaffId' => 'roomStaffId',
        'roomStatus' => 'roomStatus',
        'roomUnionId' => 'roomUnionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deviceUnionIds) {
            $res['deviceUnionIds'] = $this->deviceUnionIds;
        }
        if (null !== $this->enableCycleReservation) {
            $res['enableCycleReservation'] = $this->enableCycleReservation;
        }
        if (null !== $this->extensionConfig) {
            $res['extensionConfig'] = null !== $this->extensionConfig ? $this->extensionConfig->toMap() : null;
        }
        if (null !== $this->isvRoomId) {
            $res['isvRoomId'] = $this->isvRoomId;
        }
        if (null !== $this->reservationAuthority) {
            $res['reservationAuthority'] = null !== $this->reservationAuthority ? $this->reservationAuthority->toMap() : null;
        }
        if (null !== $this->roomCapacity) {
            $res['roomCapacity'] = $this->roomCapacity;
        }
        if (null !== $this->roomGroup) {
            $res['roomGroup'] = null !== $this->roomGroup ? $this->roomGroup->toMap() : null;
        }
        if (null !== $this->roomId) {
            $res['roomId'] = $this->roomId;
        }
        if (null !== $this->roomLabels) {
            $res['roomLabels'] = [];
            if (null !== $this->roomLabels && \is_array($this->roomLabels)) {
                $n = 0;
                foreach ($this->roomLabels as $item) {
                    $res['roomLabels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->roomStaffId) {
            $res['roomStaffId'] = $this->roomStaffId;
        }
        if (null !== $this->roomStatus) {
            $res['roomStatus'] = $this->roomStatus;
        }
        if (null !== $this->roomUnionId) {
            $res['roomUnionId'] = $this->roomUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deviceUnionIds'])) {
            if (!empty($map['deviceUnionIds'])) {
                $model->deviceUnionIds = $map['deviceUnionIds'];
            }
        }
        if (isset($map['enableCycleReservation'])) {
            $model->enableCycleReservation = $map['enableCycleReservation'];
        }
        if (isset($map['extensionConfig'])) {
            $model->extensionConfig = extensionConfig::fromMap($map['extensionConfig']);
        }
        if (isset($map['isvRoomId'])) {
            $model->isvRoomId = $map['isvRoomId'];
        }
        if (isset($map['reservationAuthority'])) {
            $model->reservationAuthority = reservationAuthority::fromMap($map['reservationAuthority']);
        }
        if (isset($map['roomCapacity'])) {
            $model->roomCapacity = $map['roomCapacity'];
        }
        if (isset($map['roomGroup'])) {
            $model->roomGroup = roomGroup::fromMap($map['roomGroup']);
        }
        if (isset($map['roomId'])) {
            $model->roomId = $map['roomId'];
        }
        if (isset($map['roomLabels'])) {
            if (!empty($map['roomLabels'])) {
                $model->roomLabels = [];
                $n = 0;
                foreach ($map['roomLabels'] as $item) {
                    $model->roomLabels[$n++] = null !== $item ? roomLabels::fromMap($item) : $item;
                }
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
        if (isset($map['roomStaffId'])) {
            $model->roomStaffId = $map['roomStaffId'];
        }
        if (isset($map['roomStatus'])) {
            $model->roomStatus = $map['roomStatus'];
        }
        if (isset($map['roomUnionId'])) {
            $model->roomUnionId = $map['roomUnionId'];
        }

        return $model;
    }
}
