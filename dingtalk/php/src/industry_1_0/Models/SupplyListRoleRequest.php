<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyListRoleRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $parentRoleId;
    protected $_name = [
        'parentRoleId' => 'parentRoleId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->parentRoleId) {
            $res['parentRoleId'] = $this->parentRoleId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyListRoleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['parentRoleId'])) {
            $model->parentRoleId = $map['parentRoleId'];
        }

        return $model;
    }
}
