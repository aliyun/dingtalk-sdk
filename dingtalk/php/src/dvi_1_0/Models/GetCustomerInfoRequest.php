<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCustomerInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $customerId;
    protected $_name = [
        'customerId' => 'customerId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerId) {
            $res['customerId'] = $this->customerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCustomerInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customerId'])) {
            $model->customerId = $map['customerId'];
        }

        return $model;
    }
}
