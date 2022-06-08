<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateDeviceChatRoomRequest extends Model
{
    /**
     * @description 场景群类型，不填，为默认普通设备群，示例值--维修群：REPAIR_GROUP，点检群:INSPECT_GROUP,保养群：MAINTAIN_GROUP。
     *
     * @var string
     */
    public $chatType;

    /**
     * @description 设备编码，客户侧生成的设备标识，能够唯一标识一个设备，该字段与deviceUuids字段需要二选一，并且不能都填充。
     *
     * @var string[]
     */
    public $deviceCodes;

    /**
     * @description 设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCodes字段需要二选一，并且不能都填充。
     *
     * @var string[]
     */
    public $deviceUuids;

    /**
     * @description 群主钉钉账户。
     *
     * @var string
     */
    public $ownerUserId;

    /**
     * @description 设备场景群名称。
     *
     * @var string
     */
    public $title;

    /**
     * @description 需要被拉入群聊的钉钉账号，可以传多个，通过英文逗号分隔。
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'chatType'    => 'chatType',
        'deviceCodes' => 'deviceCodes',
        'deviceUuids' => 'deviceUuids',
        'ownerUserId' => 'ownerUserId',
        'title'       => 'title',
        'userIds'     => 'userIds',
    ];

    public function validate()
    {
    }

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
