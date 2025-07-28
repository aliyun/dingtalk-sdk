<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMemberResponseBody;

use AlibabaCloud\Tea\Model;

class groupMembers extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1000000
     *
     * @var int
     */
    public $appUid;

    /**
     * @example http://****.png
     *
     * @var string
     */
    public $groupMemberAvatar;

    /**
     * @example abc
     *
     * @var string
     */
    public $groupMemberAvatarMediaId;

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
     * @description This parameter is required.
     *
     * @example Foo
     *
     * @var string
     */
    public $groupMemberName;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $groupMemberType;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $groupMemberTypeV2;
    protected $_name = [
        'appUid' => 'appUid',
        'groupMemberAvatar' => 'groupMemberAvatar',
        'groupMemberAvatarMediaId' => 'groupMemberAvatarMediaId',
        'groupMemberDynamics' => 'groupMemberDynamics',
        'groupMemberId' => 'groupMemberId',
        'groupMemberName' => 'groupMemberName',
        'groupMemberType' => 'groupMemberType',
        'groupMemberTypeV2' => 'groupMemberTypeV2',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUid) {
            $res['appUid'] = $this->appUid;
        }
        if (null !== $this->groupMemberAvatar) {
            $res['groupMemberAvatar'] = $this->groupMemberAvatar;
        }
        if (null !== $this->groupMemberAvatarMediaId) {
            $res['groupMemberAvatarMediaId'] = $this->groupMemberAvatarMediaId;
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
        if (null !== $this->groupMemberTypeV2) {
            $res['groupMemberTypeV2'] = $this->groupMemberTypeV2;
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
        if (isset($map['appUid'])) {
            $model->appUid = $map['appUid'];
        }
        if (isset($map['groupMemberAvatar'])) {
            $model->groupMemberAvatar = $map['groupMemberAvatar'];
        }
        if (isset($map['groupMemberAvatarMediaId'])) {
            $model->groupMemberAvatarMediaId = $map['groupMemberAvatarMediaId'];
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
        if (isset($map['groupMemberTypeV2'])) {
            $model->groupMemberTypeV2 = $map['groupMemberTypeV2'];
        }

        return $model;
    }
}
