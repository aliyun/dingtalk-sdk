<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateChatRoomRequest extends Model
{
    /**
     * @var string
     */
    public $chatGroupName;

    /**
     * @var string[]
     */
    public $deviceCodes;

    /**
     * @var string
     */
    public $deviceTypeId;

    /**
     * @var string
     */
    public $ownerUserId;

    /**
     * @var string[]
     */
    public $roleList;
    protected $_name = [
        'chatGroupName' => 'chatGroupName',
        'deviceCodes'   => 'deviceCodes',
        'deviceTypeId'  => 'deviceTypeId',
        'ownerUserId'   => 'ownerUserId',
        'roleList'      => 'roleList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatGroupName) {
            $res['chatGroupName'] = $this->chatGroupName;
        }
        if (null !== $this->deviceCodes) {
            $res['deviceCodes'] = $this->deviceCodes;
        }
        if (null !== $this->deviceTypeId) {
            $res['deviceTypeId'] = $this->deviceTypeId;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
        }
        if (null !== $this->roleList) {
            $res['roleList'] = $this->roleList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateChatRoomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatGroupName'])) {
            $model->chatGroupName = $map['chatGroupName'];
        }
        if (isset($map['deviceCodes'])) {
            if (!empty($map['deviceCodes'])) {
                $model->deviceCodes = $map['deviceCodes'];
            }
        }
        if (isset($map['deviceTypeId'])) {
            $model->deviceTypeId = $map['deviceTypeId'];
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }
        if (isset($map['roleList'])) {
            if (!empty($map['roleList'])) {
                $model->roleList = $map['roleList'];
            }
        }

        return $model;
    }
}
