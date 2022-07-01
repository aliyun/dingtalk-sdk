<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\UpdatePermissionForUsersRequest;

use AlibabaCloud\Tea\Model;

class members extends Model
{
    /**
     * @var int
     */
    public $memberId;

    /**
     * @description 要赋予用户的权限名称。该字段表示要授予特定用户的权限名称，由开发者填写。
     *
     * READ：只读权限
     * @var string
     */
    public $memberType;

    /**
     * @var string
     */
    public $policyType;
    protected $_name = [
        'memberId'   => 'memberId',
        'memberType' => 'memberType',
        'policyType' => 'policyType',
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
        if (null !== $this->policyType) {
            $res['policyType'] = $this->policyType;
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
        if (isset($map['policyType'])) {
            $model->policyType = $map['policyType'];
        }

        return $model;
    }
}
