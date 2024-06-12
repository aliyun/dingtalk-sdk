<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DescribeMetaModelRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $bizTypes;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $tenant;
    protected $_name = [
        'bizTypes'       => 'bizTypes',
        'operatorUserId' => 'operatorUserId',
        'tenant'         => 'tenant',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTypes) {
            $res['bizTypes'] = $this->bizTypes;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DescribeMetaModelRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTypes'])) {
            if (!empty($map['bizTypes'])) {
                $model->bizTypes = $map['bizTypes'];
            }
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }

        return $model;
    }
}
