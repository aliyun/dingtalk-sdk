<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateDeviceChatRoomRequest extends Model
{
    /**
     * @example REPAIR_GROUP
     *
     * @var string
     */
    public $chatType;

    /**
     * @var string[]
     */
    public $deviceCodes;

    /**
     * @var string[]
     */
    public $deviceUuids;

    /**
     * @description This parameter is required.
     *
     * @example xxxxxxx
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @example 设备维修群
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'chatType' => 'chatType',
        'deviceCodes' => 'deviceCodes',
        'deviceUuids' => 'deviceUuids',
        'ownerUserId' => 'ownerUserId',
        'title' => 'title',
        'userIds' => 'userIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatType) {
            $res['chatType'] = $this->chatType;
        }
        if (null !== $this->deviceCodes) {
            $res['deviceCodes'] = $this->deviceCodes;
        }
        if (null !== $this->deviceUuids) {
            $res['deviceUuids'] = $this->deviceUuids;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateDeviceChatRoomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatType'])) {
            $model->chatType = $map['chatType'];
        }
        if (isset($map['deviceCodes'])) {
            if (!empty($map['deviceCodes'])) {
                $model->deviceCodes = $map['deviceCodes'];
            }
        }
        if (isset($map['deviceUuids'])) {
            if (!empty($map['deviceUuids'])) {
                $model->deviceUuids = $map['deviceUuids'];
            }
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
