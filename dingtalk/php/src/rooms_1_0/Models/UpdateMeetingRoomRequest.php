<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomRequest\roomLocation;
use AlibabaCloud\Tea\Model;

class UpdateMeetingRoomRequest extends Model
{
    /**
     * @description 会议室所属分组id
     *
     * @var int
     */
    public $groupId;

    /**
     * @description isv外部会议室id
     *
     * @var string
     */
    public $isvRoomId;

    /**
     * @description 会议室容量
     *
     * @var int
     */
    public $roomCapacity;

    /**
     * @description 会议室id
     *
     * @var string
     */
    public $roomId;

    /**
     * @description 会议室标签
     *
     * @var int[]
     */
    public $roomLabelIds;

    /**
     * @description 会议室位置
     *
     * @var roomLocation
     */
    public $roomLocation;

    /**
     * @description 会议室名称
     *
     * @var string
     */
    public $roomName;

    /**
     * @description 会议室图片
     *
     * @var string
     */
    public $roomPicture;

    /**
     * @description 会议室状态
     *
     * @var int
     */
    public $roomStatus;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'groupId'      => 'groupId',
        'isvRoomId'    => 'isvRoomId',
        'roomCapacity' => 'roomCapacity',
        'roomId'       => 'roomId',
        'roomLabelIds' => 'roomLabelIds',
        'roomLocation' => 'roomLocation',
        'roomName'     => 'roomName',
        'roomPicture'  => 'roomPicture',
        'roomStatus'   => 'roomStatus',
        'unionId'      => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->isvRoomId) {
            $res['isvRoomId'] = $this->isvRoomId;
        }
        if (null !== $this->roomCapacity) {
            $res['roomCapacity'] = $this->roomCapacity;
        }
        if (null !== $this->roomId) {
            $res['roomId'] = $this->roomId;
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
     * @return UpdateMeetingRoomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['isvRoomId'])) {
            $model->isvRoomId = $map['isvRoomId'];
        }
        if (isset($map['roomCapacity'])) {
            $model->roomCapacity = $map['roomCapacity'];
        }
        if (isset($map['roomId'])) {
            $model->roomId = $map['roomId'];
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
