<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateContactHideBySceneSettingRequest;

use AlibabaCloud\Tea\Model;

class searchSceneConfig extends Model
{
    /**
     * @description 是否在搜索场景生效，默认为true。如果为false，允许被搜索。
     *
     * @var bool
     */
    public $active;

    /**
     * @description 是否同时隐藏被隐藏的部门下的员工，默认为true。如果为false，objectDeptIds中的部门无法被搜索，但是员工仍然可以被搜索
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
     * @return searchSceneConfig
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
