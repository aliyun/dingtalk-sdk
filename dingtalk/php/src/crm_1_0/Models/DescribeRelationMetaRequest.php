<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DescribeRelationMetaRequest extends Model
{
    /**
     * @var string
     */
    public $tenant;

    /**
     * @var string
     */
    public $operatorUserId;

    /**
     * @var string[]
     */
    public $relationTypes;
    protected $_name = [
        'tenant'         => 'tenant',
        'operatorUserId' => 'operatorUserId',
        'relationTypes'  => 'relationTypes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->relationTypes) {
            $res['relationTypes'] = $this->relationTypes;
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
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['relationTypes'])) {
            if (!empty($map['relationTypes'])) {
                $model->relationTypes = $map['relationTypes'];
            }
        }

        return $model;
    }
}
