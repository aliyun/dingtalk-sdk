<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCustomerBizTypeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1343dfd1233
     *
     * @var string
     */
    public $operatorUserId;
    protected $_name = [
        'operatorUserId' => 'operatorUserId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCustomerBizTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }

        return $model;
    }
}
