<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponseBody\list_;

use AlibabaCloud\Tea\Model;

class docMemberList extends Model
{
    /**
     * @description 成员名称
     *
     * @var string
     */
    public $memberName;

    /**
     * @description 成员类型
     *
     * @var int
     */
    public $memberType;

    /**
     * @description 成员类型翻译值
     *
     * @var string
     */
    public $memberTypeView;

    /**
     * @description 权限类型
     *
     * @var int
     */
    public $permissionRole;

    /**
     * @description 权限类型翻译值
     *
     * @var string
     */
    public $permissionRoleView;
    protected $_name = [
        'memberName'         => 'memberName',
        'memberType'         => 'memberType',
        'memberTypeView'     => 'memberTypeView',
        'permissionRole'     => 'permissionRole',
        'permissionRoleView' => 'permissionRoleView',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberName) {
            $res['memberName'] = $this->memberName;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->memberTypeView) {
            $res['memberTypeView'] = $this->memberTypeView;
        }
        if (null !== $this->permissionRole) {
            $res['permissionRole'] = $this->permissionRole;
        }
        if (null !== $this->permissionRoleView) {
            $res['permissionRoleView'] = $this->permissionRoleView;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return docMemberList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberName'])) {
            $model->memberName = $map['memberName'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }
        if (isset($map['memberTypeView'])) {
            $model->memberTypeView = $map['memberTypeView'];
        }
        if (isset($map['permissionRole'])) {
            $model->permissionRole = $map['permissionRole'];
        }
        if (isset($map['permissionRoleView'])) {
            $model->permissionRoleView = $map['permissionRoleView'];
        }

        return $model;
    }
}
