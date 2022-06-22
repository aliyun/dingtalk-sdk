<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPermissionRoleMemberRequest extends Model
{
    /**
     * @description 角色的唯一标识列表
     *
     * @var string[]
     */
    public $roleCodeList;
    protected $_name = [
        'roleCodeList' => 'roleCodeList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleCodeList) {
            $res['roleCodeList'] = $this->roleCodeList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPermissionRoleMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleCodeList'])) {
            if (!empty($map['roleCodeList'])) {
                $model->roleCodeList = $map['roleCodeList'];
            }
        }

        return $model;
    }
}
