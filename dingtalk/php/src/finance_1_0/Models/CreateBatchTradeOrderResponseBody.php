<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateBatchTradeOrderResponseBody extends Model
{
    /**
     * @description 钉钉批次单号
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description 商户批次号
     *
     * @var string
     */
    public $outBatchNo;

    /**
     * @description 批次订单状态
     *
     * @var string
     */
    public $orderStatus;
    protected $_name = [
        'orderNo'     => 'orderNo',
        'outBatchNo'  => 'outBatchNo',
        'orderStatus' => 'orderStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->outBatchNo) {
            $res['outBatchNo'] = $this->outBatchNo;
        }
        if (null !== $this->orderStatus) {
            $res['orderStatus'] = $this->orderStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateBatchTradeOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['outBatchNo'])) {
            $model->outBatchNo = $map['outBatchNo'];
        }
        if (isset($map['orderStatus'])) {
            $model->orderStatus = $map['orderStatus'];
        }

        return $model;
    }
}
