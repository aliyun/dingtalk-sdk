<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionRequest;

use AlibabaCloud\Tea\Model;

class memberPermissionOperations extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $memberType;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $memberUnionId;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $opType;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $policyId;

    /**
     * @var string[]
     */
    public $roleSubResourceIds;
    protected $_name = [
        'memberType' => 'memberType',
        'memberUnionId' => 'memberUnionId',
        'opType' => 'opType',
        'policyId' => 'policyId',
        'roleSubResourceIds' => 'roleSubResourceIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->memberUnionId) {
            $res['memberUnionId'] = $this->memberUnionId;
        }
        if (null !== $this->opType) {
            $res['opType'] = $this->opType;
        }
        if (null !== $this->policyId) {
            $res['policyId'] = $this->policyId;
        }
        if (null !== $this->roleSubResourceIds) {
            $res['roleSubResourceIds'] = $this->roleSubResourceIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return memberPermissionOperations
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }
        if (isset($map['memberUnionId'])) {
            $model->memberUnionId = $map['memberUnionId'];
        }
        if (isset($map['opType'])) {
            $model->opType = $map['opType'];
        }
        if (isset($map['policyId'])) {
            $model->policyId = $map['policyId'];
        }
        if (isset($map['roleSubResourceIds'])) {
            if (!empty($map['roleSubResourceIds'])) {
                $model->roleSubResourceIds = $map['roleSubResourceIds'];
            }
        }

        return $model;
    }
}
