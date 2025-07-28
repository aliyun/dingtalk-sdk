<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCrmRolePermissionRequest extends Model
{
    /**
     * @example crm_customer
     *
     * @var string
     */
    public $bizType;

    /**
     * @example PROC-9EC85C45-E404-4E26-9300-E67455F0FF8F
     *
     * @var string
     */
    public $resourceId;
    protected $_name = [
        'bizType' => 'bizType',
        'resourceId' => 'resourceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->resourceId) {
            $res['resourceId'] = $this->resourceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCrmRolePermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['resourceId'])) {
            $model->resourceId = $map['resourceId'];
        }

        return $model;
    }
}
