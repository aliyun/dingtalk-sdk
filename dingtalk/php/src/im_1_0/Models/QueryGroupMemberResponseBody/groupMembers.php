<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberResponseBody;

use AlibabaCloud\Tea\Model;

class groupMembers extends Model
{
    /**
     * @example http://****.png
     *
     * @var string
     */
    public $groupMemberAvatar;

    /**
     * @example 认真工作,快乐生活
     *
     * @var string
     */
    public $groupMemberDynamics;

    /**
     * @example 1107****2120
     *
     * @var string
     */
    public $groupMemberId;

    /**
     * @example Foo
     *
     * @var string
     */
    public $groupMemberName;

    /**
     * @example 1
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
