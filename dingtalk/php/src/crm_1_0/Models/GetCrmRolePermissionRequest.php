<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCrmRolePermissionRequest extends Model
{
    /**
     * @description 表单bizType
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 资源id，填表单code
     *
     * @var string
     */
    public $resourceId;
    protected $_name = [
        'bizType'    => 'bizType',
        'resourceId' => 'resourceId',
    ];

    public function validate()
    {
    }

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
