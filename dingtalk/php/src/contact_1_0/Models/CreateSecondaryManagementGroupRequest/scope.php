<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\CreateSecondaryManagementGroupRequest;

use AlibabaCloud\Tea\Model;

class scope extends Model
{
    /**
     * @description 部门id列表
     *
     * @var int[]
     */
    public $deptIds;

    /**
     * @description 权限范围
     *
     * @var int
     */
    public $scopeType;
    protected $_name = [
        'deptIds'   => 'deptIds',
        'scopeType' => 'scopeType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return scope
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }

        return $model;
    }
}
