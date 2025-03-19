<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterDeviceRequest extends Model
{
    /**
     * @example manager1,1000,10001
     *
     * @var string
     */
    public $collaborators;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $departmentId;

    /**
     * @example 生产组1号设备负责生产第一批产品
     *
     * @var string
     */
    public $description;

    /**
     * @description This parameter is required.
     *
     * @example key_xxxxxxx
     *
     * @var string
     */
    public $deviceKey;

    /**
     * @description This parameter is required.
     *
     * @example 生产1组1号机
     *
     * @var string
     */
    public $deviceName;

    /**
     * @example manager1,manager2
     *
     * @var string
     */
    public $managers;

    /**
     * @description This parameter is required.
     *
     * @example manager10
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'collaborators' => 'collaborators',
        'departmentId' => 'departmentId',
        'description' => 'description',
        'deviceKey' => 'deviceKey',
        'deviceName' => 'deviceName',
        'managers' => 'managers',
        'userId' => 'userId',
    ];

    public function validate() {}

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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RegisterDeviceRequest
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
