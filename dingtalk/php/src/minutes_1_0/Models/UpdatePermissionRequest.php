<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionRequest\memberInfoList;
use AlibabaCloud\Tea\Model;

class UpdatePermissionRequest extends Model
{
    /**
     * @var memberInfoList[]
     */
    public $memberInfoList;

    /**
     * @example 0
     *
     * @var int
     */
    public $opType;

    /**
     * @example 1000
     *
     * @var string
     */
    public $roleCode;

    /**
     * @var string[]
     */
    public $roleSubResourceIds;

    /**
     * @example 0
     *
     * @var int
     */
    public $shareScope;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'memberInfoList' => 'memberInfoList',
        'opType' => 'opType',
        'roleCode' => 'roleCode',
        'roleSubResourceIds' => 'roleSubResourceIds',
        'shareScope' => 'shareScope',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberInfoList) {
            $res['memberInfoList'] = [];
            if (null !== $this->memberInfoList && \is_array($this->memberInfoList)) {
                $n = 0;
                foreach ($this->memberInfoList as $item) {
                    $res['memberInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->opType) {
            $res['opType'] = $this->opType;
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }
        if (null !== $this->roleSubResourceIds) {
            $res['roleSubResourceIds'] = $this->roleSubResourceIds;
        }
        if (null !== $this->shareScope) {
            $res['shareScope'] = $this->shareScope;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberInfoList'])) {
            if (!empty($map['memberInfoList'])) {
                $model->memberInfoList = [];
                $n = 0;
                foreach ($map['memberInfoList'] as $item) {
                    $model->memberInfoList[$n++] = null !== $item ? memberInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['opType'])) {
            $model->opType = $map['opType'];
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }
        if (isset($map['roleSubResourceIds'])) {
            if (!empty($map['roleSubResourceIds'])) {
                $model->roleSubResourceIds = $map['roleSubResourceIds'];
            }
        }
        if (isset($map['shareScope'])) {
            $model->shareScope = $map['shareScope'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
