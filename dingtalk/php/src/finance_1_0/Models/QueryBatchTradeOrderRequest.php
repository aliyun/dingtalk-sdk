<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBatchTradeOrderRequest extends Model
{
    /**
     * @description 外部商户批次号列表
     *
     * @var string[]
     */
    public $outBatchNos;
    protected $_name = [
        'outBatchNos' => 'outBatchNos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outBatchNos) {
            $res['outBatchNos'] = $this->outBatchNos;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBatchTradeOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outBatchNos'])) {
            if (!empty($map['outBatchNos'])) {
                $model->outBatchNos = $map['outBatchNos'];
            }
        }

        return $model;
    }
}
