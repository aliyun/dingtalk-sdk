<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class EditDeviceAdminRequest extends Model
{
    /**
     * @example xxxxxx
     *
     * @var string
     */
    public $deviceCode;

    /**
     * @example xxxxx
     *
     * @var string
     */
    public $roleUuid;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;

    /**
     * @example xxxxxx
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'deviceCode' => 'deviceCode',
        'roleUuid' => 'roleUuid',
        'userIds' => 'userIds',
        'uuid' => 'uuid',
    ];

    public function validate() {}

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
