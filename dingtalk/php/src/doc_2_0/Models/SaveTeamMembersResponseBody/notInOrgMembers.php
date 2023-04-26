<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SaveTeamMembersResponseBody;

use AlibabaCloud\Tea\Model;

class notInOrgMembers extends Model
{
    /**
     * @example YEp3JcM******UIbhwiE
     *
     * @var string
     */
    public $memberId;

    /**
     * @example 2
     *
     * @var int
     */
    public $memberType;

    /**
     * @example 小钉
     *
     * @var string
     */
    public $name;

    /**
     * @example 0
     *
     * @var string
     */
    public $roleCode;
    protected $_name = [
        'memberId'   => 'memberId',
        'memberType' => 'memberType',
        'name'       => 'name',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return notInOrgMembers
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }

        return $model;
    }
}
