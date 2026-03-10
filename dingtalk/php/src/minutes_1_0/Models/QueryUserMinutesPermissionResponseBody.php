<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserMinutesPermissionResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasPermission;

    /**
     * @description 角色类型：manager-管理员, owner-所有者, editor-可编辑, read_download-可查看/下载, read-仅查看, none-无权限
     *
     * @var string
     */
    public $roleType;
    protected $_name = [
        'hasPermission' => 'hasPermission',
        'roleType' => 'roleType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasPermission) {
            $res['hasPermission'] = $this->hasPermission;
        }
        if (null !== $this->roleType) {
            $res['roleType'] = $this->roleType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserMinutesPermissionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasPermission'])) {
            $model->hasPermission = $map['hasPermission'];
        }
        if (isset($map['roleType'])) {
            $model->roleType = $map['roleType'];
        }

        return $model;
    }
}
