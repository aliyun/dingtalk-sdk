<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyDeletePartnerManagersRequest extends Model
{
    /**
     * @example 1231
     *
     * @var int
     */
    public $deptId;

    /**
     * @example 12131
     *
     * @var string
     */
    public $interfaceId;

    /**
     * @example user
     *
     * @var string
     */
    public $interfaceType;
    protected $_name = [
        'deptId'        => 'deptId',
        'interfaceId'   => 'interfaceId',
        'interfaceType' => 'interfaceType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->interfaceId) {
            $res['interfaceId'] = $this->interfaceId;
        }
        if (null !== $this->interfaceType) {
            $res['interfaceType'] = $this->interfaceType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyDeletePartnerManagersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['interfaceId'])) {
            $model->interfaceId = $map['interfaceId'];
        }
        if (isset($map['interfaceType'])) {
            $model->interfaceType = $map['interfaceType'];
        }

        return $model;
    }
}
