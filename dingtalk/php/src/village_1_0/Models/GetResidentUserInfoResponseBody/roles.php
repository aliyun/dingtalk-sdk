<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetResidentUserInfoResponseBody;

use AlibabaCloud\Tea\Model;

class roles extends Model
{
    /**
     * @var int
     */
    public $roleId;

    /**
     * @var string
     */
    public $roleName;

    /**
     * @var string
     */
    public $tagCode;
    protected $_name = [
        'roleId'   => 'roleId',
        'roleName' => 'roleName',
        'tagCode'  => 'tagCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }

        return $model;
    }
}
