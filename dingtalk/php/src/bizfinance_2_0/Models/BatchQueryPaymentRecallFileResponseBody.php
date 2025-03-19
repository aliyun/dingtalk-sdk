<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchQueryPaymentRecallFileResponseBody\paymentRecallFileList;
use AlibabaCloud\Tea\Model;

class BatchQueryPaymentRecallFileResponseBody extends Model
{
    /**
     * @var paymentRecallFileList[]
     */
    public $paymentRecallFileList;
    protected $_name = [
        'paymentRecallFileList' => 'paymentRecallFileList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
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
     * @return BatchQueryPaymentRecallFileResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
