<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class EditDeviceAdminRequest extends Model
{
    /**
     * @description 需要处理的设备编号。客户侧生成的设备标识，能够唯一标识一个设备，该字段与uuid字段需要二选一，并且不能都填充。
     *
     * @var string
     */
    public $deviceCode;

    /**
     * @description 角色唯一标识
     *
     * @var string
     */
    public $roleUuid;

    /**
     * @description 需要编辑的角色唯一标识，非必填，不传默认为管理员。
     *
     * @var string[]
     */
    public $userIds;

    /**
     * @description 设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCode字段需要二选一，并且不能都填充。
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'deviceCode' => 'deviceCode',
        'roleUuid'   => 'roleUuid',
        'userIds'    => 'userIds',
        'uuid'       => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->roleUuid) {
            $res['roleUuid'] = $this->roleUuid;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EditDeviceAdminRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['roleUuid'])) {
            $model->roleUuid = $map['roleUuid'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
