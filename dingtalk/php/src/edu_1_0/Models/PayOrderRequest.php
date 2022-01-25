<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class PayOrderRequest extends Model
{
    /**
     * @description 设备序列号
     *
     * @var string
     */
    public $sn;

    /**
     * @description 订单号
     *
     * @var string
     */
    public $orderNo;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'sn'      => 'sn',
        'orderNo' => 'orderNo',
        'userId'  => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PayOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
