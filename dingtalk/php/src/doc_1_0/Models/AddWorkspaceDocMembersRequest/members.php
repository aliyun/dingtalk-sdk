<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddWorkspaceDocMembersRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description 被操作用户unionId
     *
     * @var string
     */
    public $memberId;

    /**
     * @description 用户类型
     *
     * @var string
     */
    public $memberType;

    /**
     * @description 用户权限
     *
     * @var string
     */
    public $roleType;
    protected $_name = [
        'memberId'   => 'memberId',
        'memberType' => 'memberType',
        'roleType'   => 'roleType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberId) {
            $res['memberId'] = $this->memberId;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->roleType) {
            $res['roleType'] = $this->roleType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return members
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
        if (isset($map['roleType'])) {
            $model->roleType = $map['roleType'];
        }

        return $model;
    }
}
