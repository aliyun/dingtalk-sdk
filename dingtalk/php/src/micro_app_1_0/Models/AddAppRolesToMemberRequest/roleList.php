<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppRolesToMemberRequest;

use AlibabaCloud\Tea\Model;

class roleList extends Model
{
    /**
     * @description 角色ID
     *
     * @var int
     */
    public $roleId;

    /**
     * @description 角色范围版本号
     *
     * @var int
     */
    public $scopeVersion;
    protected $_name = [
        'roleId'       => 'roleId',
        'scopeVersion' => 'scopeVersion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }
        if (null !== $this->scopeVersion) {
            $res['scopeVersion'] = $this->scopeVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roleList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }
        if (isset($map['scopeVersion'])) {
            $model->scopeVersion = $map['scopeVersion'];
        }

        return $model;
    }
}
