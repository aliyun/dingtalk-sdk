<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAcquireRefundOrderResponseBody extends Model
{
    /**
     * @description 外部退款单号
     *
     * @var string
     */
    public $outRefundNo;

    /**
     * @description 钉钉退款单号
     *
     * @var string
     */
    public $refundOrderNo;

    /**
     * @description 退款状态
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'outRefundNo'   => 'outRefundNo',
        'refundOrderNo' => 'refundOrderNo',
        'status'        => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outRefundNo) {
            $res['outRefundNo'] = $this->outRefundNo;
        }
        if (null !== $this->refundOrderNo) {
            $res['refundOrderNo'] = $this->refundOrderNo;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAcquireRefundOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outRefundNo'])) {
            $model->outRefundNo = $map['outRefundNo'];
        }
        if (isset($map['refundOrderNo'])) {
            $model->refundOrderNo = $map['refundOrderNo'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
