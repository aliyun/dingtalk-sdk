<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentRecallFileResponseBody\paymentRecallFileList;
use AlibabaCloud\Tea\Model;

class QueryPaymentRecallFileResponseBody extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var paymentRecallFileList[]
     */
    public $paymentRecallFileList;
    protected $_name = [
        'corpId' => 'corpId',
        'paymentRecallFileList' => 'paymentRecallFileList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->paymentRecallFileList) {
            $res['paymentRecallFileList'] = [];
            if (null !== $this->paymentRecallFileList && \is_array($this->paymentRecallFileList)) {
                $n = 0;
                foreach ($this->paymentRecallFileList as $item) {
                    $res['paymentRecallFileList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPaymentRecallFileResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['paymentRecallFileList'])) {
            if (!empty($map['paymentRecallFileList'])) {
                $model->paymentRecallFileList = [];
                $n = 0;
                foreach ($map['paymentRecallFileList'] as $item) {
                    $model->paymentRecallFileList[$n++] = null !== $item ? paymentRecallFileList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
