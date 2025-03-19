<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\AppendRolePermissionRequest\rolePermissionItemList;

use AlibabaCloud\Tea\Model;

class permissionList extends Model
{
    /**
     * @var string[]
     */
    public $actionIdList;

    /**
     * @example /invoice
     *
     * @var string
     */
    public $resourceIdentity;
    protected $_name = [
        'actionIdList' => 'actionIdList',
        'resourceIdentity' => 'resourceIdentity',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionIdList) {
            $res['actionIdList'] = $this->actionIdList;
        }
        if (null !== $this->resourceIdentity) {
            $res['resourceIdentity'] = $this->resourceIdentity;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return permissionList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionIdList'])) {
            if (!empty($map['actionIdList'])) {
                $model->actionIdList = $map['actionIdList'];
            }
        }
        if (isset($map['resourceIdentity'])) {
            $model->resourceIdentity = $map['resourceIdentity'];
        }

        return $model;
    }
}
