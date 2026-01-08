<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class ToRoleMemberDTOMapValue extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $memberId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $memberType;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $memberIdBelongOrgId;

    /**
     * @var string
     */
    public $avatar;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'memberId' => 'memberId',
        'memberType' => 'memberType',
        'memberIdBelongOrgId' => 'memberIdBelongOrgId',
        'avatar' => 'avatar',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->memberIdBelongOrgId) {
            $res['memberIdBelongOrgId'] = $this->memberIdBelongOrgId;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ToRoleMemberDTOMapValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberId'])) {
            $model->memberId = $map['memberId'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }
        if (isset($map['memberIdBelongOrgId'])) {
            $model->memberIdBelongOrgId = $map['memberIdBelongOrgId'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
