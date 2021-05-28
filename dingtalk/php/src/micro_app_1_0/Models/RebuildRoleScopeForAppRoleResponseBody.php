<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class RebuildRoleScopeForAppRoleResponseBody extends Model
{
    /**
     * @description 角色范围最新版本号
     *
     * @var int
     */
    public $latestScopeVersion;
    protected $_name = [
        'latestScopeVersion' => 'latestScopeVersion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->latestScopeVersion) {
            $res['latestScopeVersion'] = $this->latestScopeVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RebuildRoleScopeForAppRoleResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['latestScopeVersion'])) {
            $model->latestScopeVersion = $map['latestScopeVersion'];
        }

        return $model;
    }
}
