<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\toolbarInfo;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result\toolbarInfo\groupTypes\setting;
use AlibabaCloud\Tea\Model;

class groupTypes extends Model
{
    /**
     * @var bool
     */
    public $canCreateGroup;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $serviceName;

    /**
     * @var setting
     */
    public $setting;

    /**
     * @var string
     */
    public $value;
    protected $_name = [
        'canCreateGroup' => 'canCreateGroup',
        'name' => 'name',
        'serviceName' => 'serviceName',
        'setting' => 'setting',
        'value' => 'value',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canCreateGroup) {
            $res['canCreateGroup'] = $this->canCreateGroup;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->serviceName) {
            $res['serviceName'] = $this->serviceName;
        }
        if (null !== $this->setting) {
            $res['setting'] = null !== $this->setting ? $this->setting->toMap() : null;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupTypes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canCreateGroup'])) {
            $model->canCreateGroup = $map['canCreateGroup'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['serviceName'])) {
            $model->serviceName = $map['serviceName'];
        }
        if (isset($map['setting'])) {
            $model->setting = setting::fromMap($map['setting']);
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
