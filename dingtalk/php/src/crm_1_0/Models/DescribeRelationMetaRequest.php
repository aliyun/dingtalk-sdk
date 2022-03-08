<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DescribeRelationMetaRequest extends Model
{
    /**
     * @var string
     */
    public $operatorUserId;

    /**
     * @var string[]
     */
    public $relationTypes;

    /**
     * @var string
     */
    public $tenant;
    protected $_name = [
        'operatorUserId' => 'operatorUserId',
        'relationTypes'  => 'relationTypes',
        'tenant'         => 'tenant',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->relationTypes) {
            $res['relationTypes'] = $this->relationTypes;
        }
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DescribeRelationMetaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['relationTypes'])) {
            if (!empty($map['relationTypes'])) {
                $model->relationTypes = $map['relationTypes'];
            }
        }
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }

        return $model;
    }
}
