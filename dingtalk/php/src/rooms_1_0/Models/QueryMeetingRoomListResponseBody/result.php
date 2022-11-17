<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListResponseBody\result\roomGroup;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListResponseBody\result\roomLabels;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomListResponseBody\result\roomLocation;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $corpId;

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
     * @description 会议室分组
     *
     * @var roomGroup
     */
    public $roomGroup;

    /**
     * @description 会议室id
     *
     * @var string
     */
    public $roomId;

    /**
     * @var roomLabels[]
     */
    public $roomLabels;

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
     * @description 会议室staffId
     *
     * @var string
     */
    public $roomStaffId;

    /**
     * @description 会议室状态
     *
     * @var int
     */
    public $roomStatus;
    protected $_name = [
        'corpId'       => 'corpId',
        'isvRoomId'    => 'isvRoomId',
        'roomCapacity' => 'roomCapacity',
        'roomGroup'    => 'roomGroup',
        'roomId'       => 'roomId',
        'roomLabels'   => 'roomLabels',
        'roomLocation' => 'roomLocation',
        'roomName'     => 'roomName',
        'roomPicture'  => 'roomPicture',
        'roomStaffId'  => 'roomStaffId',
        'roomStatus'   => 'roomStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->isvRoomId) {
            $res['isvRoomId'] = $this->isvRoomId;
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
        if (isset($map['isvRoomId'])) {
            $model->isvRoomId = $map['isvRoomId'];
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
                $n                 = 0;
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

        return $model;
    }
}
