<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncBusinessSignInfoRequest;

use AlibabaCloud\Tea\Model;

class tmcProductDetailList extends Model
{
    /**
     * @example 1661927020219
     *
     * @var string
     */
    public $gmtOrgPay;

    /**
     * @var string
     */
    public $payType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $product;
    protected $_name = [
        'gmtOrgPay' => 'gmtOrgPay',
        'payType' => 'payType',
        'product' => 'product',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtOrgPay) {
            $res['gmtOrgPay'] = $this->gmtOrgPay;
        }
        if (null !== $this->payType) {
            $res['payType'] = $this->payType;
        }
        if (null !== $this->product) {
            $res['product'] = $this->product;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tmcProductDetailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtOrgPay'])) {
            $model->gmtOrgPay = $map['gmtOrgPay'];
        }
        if (isset($map['payType'])) {
            $model->payType = $map['payType'];
        }
        if (isset($map['product'])) {
            $model->product = $map['product'];
        }

        return $model;
    }
}
