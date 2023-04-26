<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupRequest\members;
use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateManagementGroupRequest\scope;
use AlibabaCloud\Tea\Model;

class CreateManagementGroupRequest extends Model
{
    /**
     * @var string
     */
    public $groupName;

    /**
     * @var members[]
     */
    public $members;

    /**
     * @var string[]
     */
    public $resourceIds;

    /**
     * @var scope
     */
    public $scope;
    protected $_name = [
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
     * @return CreateManagementGroupRequest
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

        return $model;
    }
}
