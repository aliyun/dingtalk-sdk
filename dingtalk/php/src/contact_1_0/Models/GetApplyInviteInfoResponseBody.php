<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetApplyInviteInfoResponseBody extends Model
{
    /**
     * @description 是否开启邀请
     *
     * @var bool
     */
    public $inviteSwitch;

    /**
     * @description 是否开启通过企业名称搜索申请
     *
     * @var bool
     */
    public $searchNameInvite;

    /**
     * @description 是否开启通过团队号申请加入
     *
     * @var bool
     */
    public $orgApplyCodeInvite;

    /**
     * @description 是否开启通过链接邀请加入
     *
     * @var bool
     */
    public $linkInvite;

    /**
     * @description 邀请链接
     *
     * @var string
     */
    public $inviteUrl;

    /**
     * @description 仅部门邀请有效： 0-无需审核 1-有权限的子管理员
     *
     * @var int
     */
    public $auditType;

    /**
     * @description 是否允许员工扫码加入部门，仅在无需审核的时候有效（已经在组织内的成员通过扫描部门二维码加入某个部门）
     *
     * @var bool
     */
    public $empApplyJoinDept;
    protected $_name = [
        'inviteSwitch'       => 'inviteSwitch',
        'searchNameInvite'   => 'searchNameInvite',
        'orgApplyCodeInvite' => 'orgApplyCodeInvite',
        'linkInvite'         => 'linkInvite',
        'inviteUrl'          => 'inviteUrl',
        'auditType'          => 'auditType',
        'empApplyJoinDept'   => 'empApplyJoinDept',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->inviteSwitch) {
            $res['inviteSwitch'] = $this->inviteSwitch;
        }
        if (null !== $this->searchNameInvite) {
            $res['searchNameInvite'] = $this->searchNameInvite;
        }
        if (null !== $this->orgApplyCodeInvite) {
            $res['orgApplyCodeInvite'] = $this->orgApplyCodeInvite;
        }
        if (null !== $this->linkInvite) {
            $res['linkInvite'] = $this->linkInvite;
        }
        if (null !== $this->inviteUrl) {
            $res['inviteUrl'] = $this->inviteUrl;
        }
        if (null !== $this->auditType) {
            $res['auditType'] = $this->auditType;
        }
        if (null !== $this->empApplyJoinDept) {
            $res['empApplyJoinDept'] = $this->empApplyJoinDept;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetApplyInviteInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['inviteSwitch'])) {
            $model->inviteSwitch = $map['inviteSwitch'];
        }
        if (isset($map['searchNameInvite'])) {
            $model->searchNameInvite = $map['searchNameInvite'];
        }
        if (isset($map['orgApplyCodeInvite'])) {
            $model->orgApplyCodeInvite = $map['orgApplyCodeInvite'];
        }
        if (isset($map['linkInvite'])) {
            $model->linkInvite = $map['linkInvite'];
        }
        if (isset($map['inviteUrl'])) {
            $model->inviteUrl = $map['inviteUrl'];
        }
        if (isset($map['auditType'])) {
            $model->auditType = $map['auditType'];
        }
        if (isset($map['empApplyJoinDept'])) {
            $model->empApplyJoinDept = $map['empApplyJoinDept'];
        }

        return $model;
    }
}
