<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideBySceneSettingRequest;

use AlibabaCloud\Tea\Model;

class nodeListSceneConfig extends Model
{
    /**
     * @description 是否在浏览组织架构与选人组件中生效，默认为true
     *
     * @var bool
     */
    public $active;

    /**
     * @description 是否同时隐藏被隐藏部门下的员工，默认为true。如果为false，仅部门不可见，但是允许跳转到被隐藏部门查看部门下员工。
     *
     * @var bool
     */
    public $deptObjectIncludeEmp;
    protected $_name = [
        'active'               => 'active',
        'deptObjectIncludeEmp' => 'deptObjectIncludeEmp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->deptObjectIncludeEmp) {
            $res['deptObjectIncludeEmp'] = $this->deptObjectIncludeEmp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return nodeListSceneConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }
        if (isset($map['deptObjectIncludeEmp'])) {
            $model->deptObjectIncludeEmp = $map['deptObjectIncludeEmp'];
        }

        return $model;
    }
}
