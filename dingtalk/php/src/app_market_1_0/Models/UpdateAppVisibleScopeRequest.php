<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateAppVisibleScopeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @var int[]
     */
    public $visibleDeptIds;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $visibleScopeType;

    /**
     * @var string[]
     */
    public $visibleUserIds;
    protected $_name = [
        'operatorUserId' => 'operatorUserId',
        'visibleDeptIds' => 'visibleDeptIds',
        'visibleScopeType' => 'visibleScopeType',
        'visibleUserIds' => 'visibleUserIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->visibleDeptIds) {
            $res['visibleDeptIds'] = $this->visibleDeptIds;
        }
        if (null !== $this->visibleScopeType) {
            $res['visibleScopeType'] = $this->visibleScopeType;
        }
        if (null !== $this->visibleUserIds) {
            $res['visibleUserIds'] = $this->visibleUserIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAppVisibleScopeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['visibleDeptIds'])) {
            if (!empty($map['visibleDeptIds'])) {
                $model->visibleDeptIds = $map['visibleDeptIds'];
            }
        }
        if (isset($map['visibleScopeType'])) {
            $model->visibleScopeType = $map['visibleScopeType'];
        }
        if (isset($map['visibleUserIds'])) {
            if (!empty($map['visibleUserIds'])) {
                $model->visibleUserIds = $map['visibleUserIds'];
            }
        }

        return $model;
    }
}
