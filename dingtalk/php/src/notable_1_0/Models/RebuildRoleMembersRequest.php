<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\RebuildRoleMembersRequest\defaultRoleDTO;
use AlibabaCloud\Tea\Model;

class RebuildRoleMembersRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var defaultRoleDTO
     */
    public $defaultRoleDTO;

    /**
     * @description This parameter is required.
     *
     * @var ToRoleMemberDTOMapValue[][]
     */
    public $toRoleMemberDTOMap;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'defaultRoleDTO' => 'defaultRoleDTO',
        'toRoleMemberDTOMap' => 'toRoleMemberDTOMap',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->defaultRoleDTO) {
            $res['defaultRoleDTO'] = null !== $this->defaultRoleDTO ? $this->defaultRoleDTO->toMap() : null;
        }
        if (null !== $this->toRoleMemberDTOMap) {
            $res['toRoleMemberDTOMap'] = $this->toRoleMemberDTOMap;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RebuildRoleMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['defaultRoleDTO'])) {
            $model->defaultRoleDTO = defaultRoleDTO::fromMap($map['defaultRoleDTO']);
        }
        if (isset($map['toRoleMemberDTOMap'])) {
            $model->toRoleMemberDTOMap = $map['toRoleMemberDTOMap'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
