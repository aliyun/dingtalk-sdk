<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCustomerResponseBody extends Model
{
    /**
     * @description 客户CODE
     *
     * @var string
     */
    public $customerCode;
    protected $_name = [
        'customerCode' => 'customerCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerCode) {
            $res['customerCode'] = $this->customerCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCustomerResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customerCode'])) {
            $model->customerCode = $map['customerCode'];
        }

        return $model;
    }
}
