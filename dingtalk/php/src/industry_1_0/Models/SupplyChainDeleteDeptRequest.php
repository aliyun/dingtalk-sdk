<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyChainDeleteDeptRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1111
     *
     * @var int
     */
    public $supplyDeptId;
    protected $_name = [
        'supplyDeptId' => 'supplyDeptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->supplyDeptId) {
            $res['supplyDeptId'] = $this->supplyDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyChainDeleteDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['supplyDeptId'])) {
            $model->supplyDeptId = $map['supplyDeptId'];
        }

        return $model;
    }
}
