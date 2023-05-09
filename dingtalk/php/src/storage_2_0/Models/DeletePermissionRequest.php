<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\DeletePermissionRequest\members;
use AlibabaCloud\Tea\Model;

class DeletePermissionRequest extends Model
{
    /**
     * @var members[]
     */
    public $members;

    /**
     * @example MANAGER
     *
     * @var string
     */
    public $roleId;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'members' => 'members',
        'roleId'  => 'roleId',
        'unionId' => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeletePermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n              = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
