<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\UpdateManagementGroupRequest;

use AlibabaCloud\Tea\Model;

class scope extends Model
{
    /**
     * @description 范围类型
     *
     * @var int
     */
    public $scopeType;

    /**
     * @description 部门列表，只在scopeType=3 生效
     *
     * @var int[]
     */
    public $deptIds;
    protected $_name = [
        'scopeType' => 'scopeType',
        'deptIds'   => 'deptIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
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
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }

        return $model;
    }
}
