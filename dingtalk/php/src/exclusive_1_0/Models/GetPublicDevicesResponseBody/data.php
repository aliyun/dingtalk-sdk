<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublicDevicesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublicDevicesResponseBody\data\deviceDepts;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublicDevicesResponseBody\data\deviceRoles;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPublicDevicesResponseBody\data\deviceStaffs;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 部门列表，仅生效范围是部分生效时有效
     *
     * @var deviceDepts[]
     */
    public $deviceDepts;

    /**
     * @description 角色列表，仅生效范围是部分生效时有效
     *
     * @var deviceRoles[]
     */
    public $deviceRoles;

    /**
     * @description 生效范围
     *
     * @var int
     */
    public $deviceScopeType;

    /**
     * @description 员工列表，仅生效范围是部分生效时有效
     *
     * @var deviceStaffs[]
     */
    public $deviceStaffs;

    /**
     * @description 创建时间时间戳
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description 修改时间时间戳
     *
     * @var int
     */
    public $gmtModified;

    /**
     * @description 设备mac地址
     *
     * @var string
     */
    public $macAddress;

    /**
     * @description 系统
     *
     * @var string
     */
    public $platform;

    /**
     * @description 设备标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'deviceDepts'     => 'deviceDepts',
        'deviceRoles'     => 'deviceRoles',
        'deviceScopeType' => 'deviceScopeType',
        'deviceStaffs'    => 'deviceStaffs',
        'gmtCreate'       => 'gmtCreate',
        'gmtModified'     => 'gmtModified',
        'macAddress'      => 'macAddress',
        'platform'        => 'platform',
        'title'           => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceDepts) {
            $res['deviceDepts'] = [];
            if (null !== $this->deviceDepts && \is_array($this->deviceDepts)) {
                $n = 0;
                foreach ($this->deviceDepts as $item) {
                    $res['deviceDepts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->deviceRoles) {
            $res['deviceRoles'] = [];
            if (null !== $this->deviceRoles && \is_array($this->deviceRoles)) {
                $n = 0;
                foreach ($this->deviceRoles as $item) {
                    $res['deviceRoles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->deviceScopeType) {
            $res['deviceScopeType'] = $this->deviceScopeType;
        }
        if (null !== $this->deviceStaffs) {
            $res['deviceStaffs'] = [];
            if (null !== $this->deviceStaffs && \is_array($this->deviceStaffs)) {
                $n = 0;
                foreach ($this->deviceStaffs as $item) {
                    $res['deviceStaffs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->macAddress) {
            $res['macAddress'] = $this->macAddress;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceDepts'])) {
            if (!empty($map['deviceDepts'])) {
                $model->deviceDepts = [];
                $n                  = 0;
                foreach ($map['deviceDepts'] as $item) {
                    $model->deviceDepts[$n++] = null !== $item ? deviceDepts::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['deviceRoles'])) {
            if (!empty($map['deviceRoles'])) {
                $model->deviceRoles = [];
                $n                  = 0;
                foreach ($map['deviceRoles'] as $item) {
                    $model->deviceRoles[$n++] = null !== $item ? deviceRoles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['deviceScopeType'])) {
            $model->deviceScopeType = $map['deviceScopeType'];
        }
        if (isset($map['deviceStaffs'])) {
            if (!empty($map['deviceStaffs'])) {
                $model->deviceStaffs = [];
                $n                   = 0;
                foreach ($map['deviceStaffs'] as $item) {
                    $model->deviceStaffs[$n++] = null !== $item ? deviceStaffs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['macAddress'])) {
            $model->macAddress = $map['macAddress'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
