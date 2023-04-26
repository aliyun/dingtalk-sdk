<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterCustomAppRoleResponseBody extends Model
{
    /**
     * @example 123
     *
     * @var int
     */
    public $roleId;

    /**
     * @example 123123123
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
     * @return RegisterCustomAppRoleResponseBody
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
