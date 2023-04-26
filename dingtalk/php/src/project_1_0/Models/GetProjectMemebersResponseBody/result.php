<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectMemebersResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 62c25e3b376ec29c45xxxxx
     *
     * @deprecated
     *
     * @var string
     */
    public $memberId;

    /**
     * @example 0
     *
     * @var int
     */
    public $role;

    /**
     * @var string[]
     */
    public $roleIds;

    /**
     * @example 0715153011125xxxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'memberId' => 'memberId',
        'role'     => 'role',
        'roleIds'  => 'roleIds',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->roleIds) {
            $res['roleIds'] = $this->roleIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['roleIds'])) {
            if (!empty($map['roleIds'])) {
                $model->roleIds = $map['roleIds'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
