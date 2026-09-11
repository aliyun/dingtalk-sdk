<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionRequest;

use AlibabaCloud\Tea\Model;

class shareScopeConfig extends Model
{
    /**
     * @example 1000
     *
     * @var string
     */
    public $roleCode;

    /**
     * @var string[]
     */
    public $roleSubResourceIds;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $shareScope;
    protected $_name = [
        'roleCode' => 'roleCode',
        'roleSubResourceIds' => 'roleSubResourceIds',
        'shareScope' => 'shareScope',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }
        if (null !== $this->roleSubResourceIds) {
            $res['roleSubResourceIds'] = $this->roleSubResourceIds;
        }
        if (null !== $this->shareScope) {
            $res['shareScope'] = $this->shareScope;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return shareScopeConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }
        if (isset($map['roleSubResourceIds'])) {
            if (!empty($map['roleSubResourceIds'])) {
                $model->roleSubResourceIds = $map['roleSubResourceIds'];
            }
        }
        if (isset($map['shareScope'])) {
            $model->shareScope = $map['shareScope'];
        }

        return $model;
    }
}
