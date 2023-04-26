<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetApplyInviteInfoResponseBody extends Model
{
    /**
     * @var int
     */
    public $auditType;

    /**
     * @var bool
     */
    public $empApplyJoinDept;

    /**
     * @var bool
     */
    public $inviteSwitch;

    /**
     * @var string
     */
    public $inviteUrl;

    /**
     * @var bool
     */
    public $linkInvite;

    /**
     * @var bool
     */
    public $orgApplyCodeInvite;

    /**
     * @var bool
     */
    public $searchNameInvite;
    protected $_name = [
        'auditType'          => 'auditType',
        'empApplyJoinDept'   => 'empApplyJoinDept',
        'inviteSwitch'       => 'inviteSwitch',
        'inviteUrl'          => 'inviteUrl',
        'linkInvite'         => 'linkInvite',
        'orgApplyCodeInvite' => 'orgApplyCodeInvite',
        'searchNameInvite'   => 'searchNameInvite',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->auditType) {
            $res['auditType'] = $this->auditType;
        }
        if (null !== $this->empApplyJoinDept) {
            $res['empApplyJoinDept'] = $this->empApplyJoinDept;
        }
        if (null !== $this->inviteSwitch) {
            $res['inviteSwitch'] = $this->inviteSwitch;
        }
        if (null !== $this->inviteUrl) {
            $res['inviteUrl'] = $this->inviteUrl;
        }
        if (null !== $this->linkInvite) {
            $res['linkInvite'] = $this->linkInvite;
        }
        if (null !== $this->orgApplyCodeInvite) {
            $res['orgApplyCodeInvite'] = $this->orgApplyCodeInvite;
        }
        if (null !== $this->searchNameInvite) {
            $res['searchNameInvite'] = $this->searchNameInvite;
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
        if (isset($map['auditType'])) {
            $model->auditType = $map['auditType'];
        }
        if (isset($map['empApplyJoinDept'])) {
            $model->empApplyJoinDept = $map['empApplyJoinDept'];
        }
        if (isset($map['inviteSwitch'])) {
            $model->inviteSwitch = $map['inviteSwitch'];
        }
        if (isset($map['inviteUrl'])) {
            $model->inviteUrl = $map['inviteUrl'];
        }
        if (isset($map['linkInvite'])) {
            $model->linkInvite = $map['linkInvite'];
        }
        if (isset($map['orgApplyCodeInvite'])) {
            $model->orgApplyCodeInvite = $map['orgApplyCodeInvite'];
        }
        if (isset($map['searchNameInvite'])) {
            $model->searchNameInvite = $map['searchNameInvite'];
        }

        return $model;
    }
}
