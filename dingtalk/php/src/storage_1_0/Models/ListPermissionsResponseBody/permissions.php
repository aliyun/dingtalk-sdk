<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListPermissionsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListPermissionsResponseBody\permissions\member;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListPermissionsResponseBody\permissions\role;
use AlibabaCloud\Tea\Model;

class permissions extends Model
{
    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 文件id
     *
     * @var string
     */
    public $dentryId;

    /**
     * @description 有效时间
     *
     * @var int
     */
    public $duration;

    /**
     * @description 权限成员
     *
     * @var member
     */
    public $member;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @description 操作人id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 权限角色
     *
     * @var role
     */
    public $role;

    /**
     * @description 空间id
     *
     * @var string
     */
    public $spaceId;
    protected $_name = [
        'createTime'   => 'createTime',
        'dentryId'     => 'dentryId',
        'duration'     => 'duration',
        'member'       => 'member',
        'modifiedTime' => 'modifiedTime',
        'operatorId'   => 'operatorId',
        'role'         => 'role',
        'spaceId'      => 'spaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->member) {
            $res['member'] = null !== $this->member ? $this->member->toMap() : null;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->role) {
            $res['role'] = null !== $this->role ? $this->role->toMap() : null;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
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
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['member'])) {
            $model->member = member::fromMap($map['member']);
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['role'])) {
            $model->role = role::fromMap($map['role']);
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
