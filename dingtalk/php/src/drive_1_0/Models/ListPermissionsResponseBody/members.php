<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ListPermissionsResponseBody\members\member;
use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $extend;

    /**
     * @description This parameter is required.
     *
     * @var member
     */
    public $member;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $role;
    protected $_name = [
        'extend' => 'extend',
        'member' => 'member',
        'role'   => 'role',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extend) {
            $res['extend'] = $this->extend;
        }
        if (null !== $this->member) {
            $res['member'] = null !== $this->member ? $this->member->toMap() : null;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return members
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extend'])) {
            $model->extend = $map['extend'];
        }
        if (isset($map['member'])) {
            $model->member = member::fromMap($map['member']);
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }

        return $model;
    }
}
