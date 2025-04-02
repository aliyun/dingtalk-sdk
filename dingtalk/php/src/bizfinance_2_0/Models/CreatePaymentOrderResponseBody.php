<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class CreatePaymentOrderResponseBody extends Model
{
    /**
     * @var int
     */
    public $expireTime;

    /**
     * @var string
     */
    public $orderNo;

    /**
     * @var string
     */
    public $outBizNo;
    protected $_name = [
        'expireTime' => 'expireTime',
        'orderNo' => 'orderNo',
        'outBizNo' => 'outBizNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->expireTime) {
            $res['expireTime'] = $this->expireTime;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->outBizNo) {
            $res['outBizNo'] = $this->outBizNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreatePaymentOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expireTime'])) {
            $model->expireTime = $map['expireTime'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['outBizNo'])) {
            $model->outBizNo = $map['outBizNo'];
        }

        return $model;
    }
}
