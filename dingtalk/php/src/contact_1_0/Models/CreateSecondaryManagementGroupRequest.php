<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateSecondaryManagementGroupRequest\members;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateSecondaryManagementGroupRequest\scope;
use AlibabaCloud\Tea\Model;

class CreateSecondaryManagementGroupRequest extends Model
{
    /**
     * @description 管理组名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 管理组成员列表
     *
     * @var members[]
     */
    public $members;

    /**
     * @description 资源id列表
     *
     * @var string[]
     */
    public $resourceIds;

    /**
     * @description 管理组权限范围信息
     *
     * @var scope
     */
    public $scope;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'groupName'   => 'groupName',
        'members'     => 'members',
        'resourceIds' => 'resourceIds',
        'scope'       => 'scope',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->resourceIds) {
            $res['resourceIds'] = $this->resourceIds;
        }
        if (null !== $this->scope) {
            $res['scope'] = null !== $this->scope ? $this->scope->toMap() : null;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSecondaryManagementGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n              = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['resourceIds'])) {
            if (!empty($map['resourceIds'])) {
                $model->resourceIds = $map['resourceIds'];
            }
        }
        if (isset($map['scope'])) {
            $model->scope = scope::fromMap($map['scope']);
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
