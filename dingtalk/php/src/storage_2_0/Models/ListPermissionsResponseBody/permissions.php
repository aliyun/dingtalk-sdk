<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListPermissionsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListPermissionsResponseBody\permissions\member;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListPermissionsResponseBody\permissions\role;
use AlibabaCloud\Tea\Model;

class permissions extends Model
{
    /**
     * @example space_id
     *
     * @var string
     */
    public $dentryUuid;

    /**
     * @example 3600
     *
     * @var int
     */
    public $duration;

    /**
     * @var member
     */
    public $member;

    /**
     * @var role
     */
    public $role;
    protected $_name = [
        'dentryUuid' => 'dentryUuid',
        'duration'   => 'duration',
        'member'     => 'member',
        'role'       => 'role',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->member) {
            $res['member'] = null !== $this->member ? $this->member->toMap() : null;
        }
        if (null !== $this->role) {
            $res['role'] = null !== $this->role ? $this->role->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return permissions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['member'])) {
            $model->member = member::fromMap($map['member']);
        }
        if (isset($map['role'])) {
            $model->role = role::fromMap($map['role']);
        }

        return $model;
    }
}
