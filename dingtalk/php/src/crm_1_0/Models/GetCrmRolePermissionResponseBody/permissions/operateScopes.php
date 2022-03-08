<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;

use AlibabaCloud\Tea\Model;

class operateScopes extends Model
{
    /**
     * @description 是否有权限
     *
     * @var bool
     */
    public $hasAuth;

    /**
     * @description 操作范围类型
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'hasAuth' => 'hasAuth',
        'type'    => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasAuth) {
            $res['hasAuth'] = $this->hasAuth;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return operateScopes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasAuth'])) {
            $model->hasAuth = $map['hasAuth'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
