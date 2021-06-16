<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPluginPermissionPointResponseBody extends Model
{
    /**
     * @description 插件权限点列表
     *
     * @var string[]
     */
    public $permissionPointList;
    protected $_name = [
        'permissionPointList' => 'permissionPointList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissionPointList) {
            $res['permissionPointList'] = $this->permissionPointList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPluginPermissionPointResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissionPointList'])) {
            if (!empty($map['permissionPointList'])) {
                $model->permissionPointList = $map['permissionPointList'];
            }
        }

        return $model;
    }
}
