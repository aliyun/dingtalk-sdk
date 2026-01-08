<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\AddRoleMemberRequest;

use AlibabaCloud\Tea\Model;

class roleMemberList extends Model
{
    /**
     * @var string
     */
    public $memberId;

    /**
     * @var int
     */
    public $memberIdBelongOrgId;

    /**
     * @var string
     */
    public $memberType;

    /**
     * @var string
     */
    public $roleId;
    protected $_name = [
        'memberId' => 'memberId',
        'memberIdBelongOrgId' => 'memberIdBelongOrgId',
        'memberType' => 'memberType',
        'roleId' => 'roleId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }
        if (null !== $this->memberIdBelongOrgId) {
            $res['memberIdBelongOrgId'] = $this->memberIdBelongOrgId;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roleMemberList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }
        if (isset($map['memberIdBelongOrgId'])) {
            $model->memberIdBelongOrgId = $map['memberIdBelongOrgId'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }

        return $model;
    }
}
