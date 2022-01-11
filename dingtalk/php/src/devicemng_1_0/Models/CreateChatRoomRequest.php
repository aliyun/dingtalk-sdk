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
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string[]
     */
    public $deviceCodes;

    /**
     * @var string
     */
    public $deviceTypeId;

    /**
     * @var string[]
     */
    public $roleList;

    /**
     * @var string
     */
    public $ownerUserId;
    protected $_name = [
        'chatGroupName' => 'chatGroupName',
        'dingCorpId'    => 'dingCorpId',
        'deviceCodes'   => 'deviceCodes',
        'deviceTypeId'  => 'deviceTypeId',
        'roleList'      => 'roleList',
        'ownerUserId'   => 'ownerUserId',
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
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->deviceCodes) {
            $res['deviceCodes'] = $this->deviceCodes;
        }
        if (null !== $this->deviceTypeId) {
            $res['deviceTypeId'] = $this->deviceTypeId;
        }
        if (null !== $this->roleList) {
            $res['roleList'] = $this->roleList;
        }
        if (null !== $this->ownerUserId) {
            $res['ownerUserId'] = $this->ownerUserId;
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
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['deviceCodes'])) {
            if (!empty($map['deviceCodes'])) {
                $model->deviceCodes = $map['deviceCodes'];
            }
        }
        if (isset($map['deviceTypeId'])) {
            $model->deviceTypeId = $map['deviceTypeId'];
        }
        if (isset($map['roleList'])) {
            if (!empty($map['roleList'])) {
                $model->roleList = $map['roleList'];
            }
        }
        if (isset($map['ownerUserId'])) {
            $model->ownerUserId = $map['ownerUserId'];
        }

        return $model;
    }
}
