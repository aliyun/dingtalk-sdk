<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetShareRolesResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 角色code
     *
     * @var string
     */
    public $shareRoleCode;

    /**
     * @description 角色名称
     *
     * @var string
     */
    public $shareRoleName;
    protected $_name = [
        'shareRoleCode' => 'shareRoleCode',
        'shareRoleName' => 'shareRoleName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->shareRoleCode) {
            $res['shareRoleCode'] = $this->shareRoleCode;
        }
        if (null !== $this->shareRoleName) {
            $res['shareRoleName'] = $this->shareRoleName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['shareRoleCode'])) {
            $model->shareRoleCode = $map['shareRoleCode'];
        }
        if (isset($map['shareRoleName'])) {
            $model->shareRoleName = $map['shareRoleName'];
        }

        return $model;
    }
}
