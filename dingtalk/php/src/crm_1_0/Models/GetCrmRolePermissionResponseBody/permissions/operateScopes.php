<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCrmRolePermissionResponseBody\permissions;

use AlibabaCloud\Tea\Model;

class operateScopes extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $hasAuth;

    /**
     * @description This parameter is required.
     *
     * @example * 操作类型      * 发起：OPERATE_CREATE      * 查看：OPERATE_VIEW      * 编辑：OPERATE_EDIT      * 删除：OPERATE_DELETE      * 打印：OPERATE_PRINT      * 分配：ASSIGN      * 转交：TRANS      * 导入：IMPORT      * 导出：EXPORT
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'hasAuth' => 'hasAuth',
        'type' => 'type',
    ];

    public function validate() {}

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
