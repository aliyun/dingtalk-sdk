<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupUserRoleQueryResponseBody\result;

use AlibabaCloud\Tea\Model;

class groupRoles extends Model
{
    /**
     * @example rolexxxxxxx
     *
     * @var string
     */
    public $openRoleId;

    /**
     * @example 小美
     *
     * @var string
     */
    public $roleName;
    protected $_name = [
        'openRoleId' => 'openRoleId',
        'roleName'   => 'roleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openRoleId) {
            $res['openRoleId'] = $this->openRoleId;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupRoles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openRoleId'])) {
            $model->openRoleId = $map['openRoleId'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }

        return $model;
    }
}
