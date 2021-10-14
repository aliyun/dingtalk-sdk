<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeOrderResponseBody\batchTradeOrderVOs;
use AlibabaCloud\Tea\Model;

class QueryBatchTradeOrderResponseBody extends Model
{
    /**
     * @description 批量交易订单VO
     *
     * @var batchTradeOrderVOs[]
     */
    public $batchTradeOrderVOs;
    protected $_name = [
        'batchTradeOrderVOs' => 'batchTradeOrderVOs',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->batchTradeOrderVOs) {
            $res['batchTradeOrderVOs'] = [];
            if (null !== $this->batchTradeOrderVOs && \is_array($this->batchTradeOrderVOs)) {
                $n = 0;
                foreach ($this->batchTradeOrderVOs as $item) {
                    $res['batchTradeOrderVOs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBatchTradeOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['batchTradeOrderVOs'])) {
            if (!empty($map['batchTradeOrderVOs'])) {
                $model->batchTradeOrderVOs = [];
                $n                         = 0;
                foreach ($map['batchTradeOrderVOs'] as $item) {
                    $model->batchTradeOrderVOs[$n++] = null !== $item ? batchTradeOrderVOs::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
