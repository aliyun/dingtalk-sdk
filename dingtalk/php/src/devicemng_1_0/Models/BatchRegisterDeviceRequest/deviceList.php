<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\BatchRegisterDeviceRequest;

use AlibabaCloud\Tea\Model;

class deviceList extends Model
{
    /**
     * @description 协助者userId列表
     *
     * @var string
     */
    public $collaborators;

    /**
     * @description 部门id
     *
     * @var int
     */
    public $departmentId;

    /**
     * @description 设备描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 设备标识
     *
     * @var string
     */
    public $deviceKey;

    /**
     * @description 设备名称
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description 管理员userId列表
     *
     * @var string
     */
    public $managers;
    protected $_name = [
        'collaborators' => 'collaborators',
        'departmentId'  => 'departmentId',
        'description'   => 'description',
        'deviceKey'     => 'deviceKey',
        'deviceName'    => 'deviceName',
        'managers'      => 'managers',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->collaborators) {
            $res['collaborators'] = $this->collaborators;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->deviceKey) {
            $res['deviceKey'] = $this->deviceKey;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->managers) {
            $res['managers'] = $this->managers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deviceList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['collaborators'])) {
            $model->collaborators = $map['collaborators'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['deviceKey'])) {
            $model->deviceKey = $map['deviceKey'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['managers'])) {
            $model->managers = $map['managers'];
        }

        return $model;
    }
}
