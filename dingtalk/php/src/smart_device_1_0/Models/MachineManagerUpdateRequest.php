<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\MachineManagerUpdateRequest\atmManagerRightMap;
use AlibabaCloud\Tea\Model;

class MachineManagerUpdateRequest extends Model
{
    /**
     * @description 设备管理员权限点。
     *
     * @var atmManagerRightMap
     */
    public $atmManagerRightMap;

    /**
     * @description 设备id。
     *
     * @var int
     */
    public $deviceId;

    /**
     * @description 权限范围：可管理的部门id列表，-1表示全公司
     *
     * @var int[]
     */
    public $scopeDeptIds;

    /**
     * @description 设备管理员的userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'atmManagerRightMap' => 'atmManagerRightMap',
        'deviceId'           => 'deviceId',
        'scopeDeptIds'       => 'scopeDeptIds',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atmManagerRightMap) {
            $res['atmManagerRightMap'] = null !== $this->atmManagerRightMap ? $this->atmManagerRightMap->toMap() : null;
        }
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
        }
        if (null !== $this->scopeDeptIds) {
            $res['scopeDeptIds'] = $this->scopeDeptIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MachineManagerUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atmManagerRightMap'])) {
            $model->atmManagerRightMap = atmManagerRightMap::fromMap($map['atmManagerRightMap']);
        }
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
        }
        if (isset($map['scopeDeptIds'])) {
            if (!empty($map['scopeDeptIds'])) {
                $model->scopeDeptIds = $map['scopeDeptIds'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
