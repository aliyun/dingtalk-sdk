<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\AddContactHideBySceneSettingRequest;

use AlibabaCloud\Tea\Model;

class nodeListSceneConfig extends Model
{
    /**
     * @var bool
     */
    public $active;

    /**
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
