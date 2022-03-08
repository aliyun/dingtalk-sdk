<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsResponseBody\groups\members;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListManagementGroupsResponseBody\groups\scope;
use AlibabaCloud\Tea\Model;

class groups extends Model
{
    /**
     * @description 管理组id
     *
     * @var string
     */
    public $groupId;

    /**
     * @description 管理组名
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 成员
     *
     * @var members[]
     */
    public $members;

    /**
     * @description 资源列表
     *
     * @var string[]
     */
    public $resourceIds;

    /**
     * @description 管理范围
     *
     * @var scope
     */
    public $scope;
    protected $_name = [
        'groupId'     => 'groupId',
        'groupName'   => 'groupName',
        'members'     => 'members',
        'resourceIds' => 'resourceIds',
        'scope'       => 'scope',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groups
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
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

        return $model;
    }
}
