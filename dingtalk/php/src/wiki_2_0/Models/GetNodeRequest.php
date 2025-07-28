<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetNodeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example false
     *
     * @var bool
     */
    public $withPermissionRole;

    /**
     * @example false
     *
     * @var bool
     */
    public $withStatisticalInfo;
    protected $_name = [
        'operatorId' => 'operatorId',
        'withPermissionRole' => 'withPermissionRole',
        'withStatisticalInfo' => 'withStatisticalInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->withPermissionRole) {
            $res['withPermissionRole'] = $this->withPermissionRole;
        }
        if (null !== $this->withStatisticalInfo) {
            $res['withStatisticalInfo'] = $this->withStatisticalInfo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetNodeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['withPermissionRole'])) {
            $model->withPermissionRole = $map['withPermissionRole'];
        }
        if (isset($map['withStatisticalInfo'])) {
            $model->withStatisticalInfo = $map['withStatisticalInfo'];
        }

        return $model;
    }
}
