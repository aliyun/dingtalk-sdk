<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryRolesResponseBody extends Model
{
    /**
     * @var RoleMapValue[][]
     */
    public $roleMap;
    protected $_name = [
        'roleMap' => 'roleMap',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleMap) {
            $res['roleMap'] = $this->roleMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryRolesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleMap'])) {
            $model->roleMap = $map['roleMap'];
        }

        return $model;
    }
}
