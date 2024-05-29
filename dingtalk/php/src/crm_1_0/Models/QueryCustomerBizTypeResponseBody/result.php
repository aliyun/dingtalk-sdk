<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryCustomerBizTypeResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example crm_customer
     *
     * @var string
     */
    public $customerBizType;
    protected $_name = [
        'customerBizType' => 'customerBizType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerBizType) {
            $res['customerBizType'] = $this->customerBizType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customerBizType'])) {
            $model->customerBizType = $map['customerBizType'];
        }

        return $model;
    }
}
