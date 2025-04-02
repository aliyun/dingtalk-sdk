<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentOrderDetailResponseBody\orderList;
use AlibabaCloud\Tea\Model;

class QueryPaymentOrderDetailResponseBody extends Model
{
    /**
     * @var orderList[]
     */
    public $orderList;

    /**
     * @var string
     */
    public $requestId;
    protected $_name = [
        'orderList' => 'orderList',
        'requestId' => 'requestId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->orderList) {
            $res['orderList'] = [];
            if (null !== $this->orderList && \is_array($this->orderList)) {
                $n = 0;
                foreach ($this->orderList as $item) {
                    $res['orderList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPaymentOrderDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orderList'])) {
            if (!empty($map['orderList'])) {
                $model->orderList = [];
                $n = 0;
                foreach ($map['orderList'] as $item) {
                    $model->orderList[$n++] = null !== $item ? orderList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}
