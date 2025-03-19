<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCustomerBizTypeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example crm_customer
     *
     * @var string
     */
    public $customerBizType;

    /**
     * @description This parameter is required.
     *
     * @example 34234234ddddad
     *
     * @var string
     */
    public $operatorUserId;
    protected $_name = [
        'customerBizType' => 'customerBizType',
        'operatorUserId' => 'operatorUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerBizType) {
            $res['customerBizType'] = $this->customerBizType;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCustomerBizTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customerBizType'])) {
            $model->customerBizType = $map['customerBizType'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }

        return $model;
    }
}
