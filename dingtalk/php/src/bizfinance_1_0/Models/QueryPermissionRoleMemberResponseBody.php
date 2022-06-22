<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPermissionRoleMemberResponseBody extends Model
{
    /**
     * @description 角色下的成员MAP
     *
     * @var RoleMemberMapValue[]
     */
    public $roleMemberMap;
    protected $_name = [
        'roleMemberMap' => 'roleMemberMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleMemberMap) {
            $res['roleMemberMap'] = [];
            if (null !== $this->roleMemberMap && \is_array($this->roleMemberMap)) {
                foreach ($this->roleMemberMap as $key => $val) {
                    $res['roleMemberMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPermissionRoleMemberResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleMemberMap'])) {
            $model->roleMemberMap = $map['roleMemberMap'];
        }

        return $model;
    }
}
