<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePaymentOrderRequest;

use AlibabaCloud\Tea\Model;

class payerAccountDTO extends Model
{
    /**
     * @example ACC_XXXXX
     *
     * @var string
     */
    public $enterpriseAccountCode;
    protected $_name = [
        'enterpriseAccountCode' => 'enterpriseAccountCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enterpriseAccountCode) {
            $res['enterpriseAccountCode'] = $this->enterpriseAccountCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return payerAccountDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enterpriseAccountCode'])) {
            $model->enterpriseAccountCode = $map['enterpriseAccountCode'];
        }

        return $model;
    }
}
