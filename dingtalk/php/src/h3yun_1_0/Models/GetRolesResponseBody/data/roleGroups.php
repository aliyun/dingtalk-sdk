<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRolesResponseBody\data;

use AlibabaCloud\Tea\Model;

class roleGroups extends Model
{
    /**
     * @description 所属企业id
     *
     * @var string
     */
    public $companyId;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 组编码
     *
     * @var string
     */
    public $groupCode;

    /**
     * @description 组id
     *
     * @var string
     */
    public $groupId;

    /**
     * @description 组名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 状态。Active=激活、Inactive=未激活，Unspecified=未指定状态
     *
     * @var string
     */
    public $state;

    /**
     * @description 可见性。All=全部可见、Normal=普通可见、OnlyAdmin=只有管理的时候可见、OnlyOrganization=本组织范围可见
     *
     * @var string
     */
    public $visibility;
    protected $_name = [
        'companyId'   => 'companyId',
        'description' => 'description',
        'groupCode'   => 'groupCode',
        'groupId'     => 'groupId',
        'groupName'   => 'groupName',
        'state'       => 'state',
        'visibility'  => 'visibility',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyId) {
            $res['companyId'] = $this->companyId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->groupCode) {
            $res['groupCode'] = $this->groupCode;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roleGroups
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyId'])) {
            $model->companyId = $map['companyId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['groupCode'])) {
            $model->groupCode = $map['groupCode'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }

        return $model;
    }
}
