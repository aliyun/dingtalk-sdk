<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateTeamRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example YEp3JcM******UIbhwiE
     *
     * @var string
     */
    public $memberId;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $memberType;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
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
