<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SaveTeamMembersRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description 成员id。
     *
     * @var string
     */
    public $memberId;

    /**
     * @description 成员类型。
     * 1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。
     * @var int
     */
    public $memberType;

    /**
     * @description 成员角色。
     * 0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。
     * @var string
     */
    public $roleCode;
    protected $_name = [
        'memberId'   => 'memberId',
        'memberType' => 'memberType',
        'roleCode'   => 'roleCode',
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
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
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
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }

        return $model;
    }
}
