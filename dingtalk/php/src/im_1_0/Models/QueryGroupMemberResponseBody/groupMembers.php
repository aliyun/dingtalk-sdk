<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberResponseBody;

use AlibabaCloud\Tea\Model;

class groupMembers extends Model
{
    /**
     * @description 群成员头像地址。
     *
     * @var string
     */
    public $groupMemberAvatar;

    /**
     * @description 群成员动态信息。
     *
     * @var string
     */
    public $groupMemberDynamics;

    /**
     * @description 群成员Id。
     *
     * @var string
     */
    public $groupMemberId;

    /**
     * @description 群成员名称。
     *
     * @var string
     */
    public $groupMemberName;

    /**
     * @description 群成员类型。
     *
     * @var int
     */
    public $groupMemberType;
    protected $_name = [
        'groupMemberAvatar'   => 'groupMemberAvatar',
        'groupMemberDynamics' => 'groupMemberDynamics',
        'groupMemberId'       => 'groupMemberId',
        'groupMemberName'     => 'groupMemberName',
        'groupMemberType'     => 'groupMemberType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupMemberAvatar) {
            $res['groupMemberAvatar'] = $this->groupMemberAvatar;
        }
        if (null !== $this->groupMemberDynamics) {
            $res['groupMemberDynamics'] = $this->groupMemberDynamics;
        }
        if (null !== $this->groupMemberId) {
            $res['groupMemberId'] = $this->groupMemberId;
        }
        if (null !== $this->groupMemberName) {
            $res['groupMemberName'] = $this->groupMemberName;
        }
        if (null !== $this->groupMemberType) {
            $res['groupMemberType'] = $this->groupMemberType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupMembers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupMemberAvatar'])) {
            $model->groupMemberAvatar = $map['groupMemberAvatar'];
        }
        if (isset($map['groupMemberDynamics'])) {
            $model->groupMemberDynamics = $map['groupMemberDynamics'];
        }
        if (isset($map['groupMemberId'])) {
            $model->groupMemberId = $map['groupMemberId'];
        }
        if (isset($map['groupMemberName'])) {
            $model->groupMemberName = $map['groupMemberName'];
        }
        if (isset($map['groupMemberType'])) {
            $model->groupMemberType = $map['groupMemberType'];
        }

        return $model;
    }
}
