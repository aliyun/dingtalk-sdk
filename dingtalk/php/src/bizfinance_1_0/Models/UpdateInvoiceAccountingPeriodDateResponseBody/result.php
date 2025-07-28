<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingPeriodDateResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingPeriodDateResponseBody\result\failInvoices;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 100
     *
     * @var int
     */
    public $failCount;

    /**
     * @var failInvoices[]
     */
    public $failInvoices;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'failCount' => 'failCount',
        'failInvoices' => 'failInvoices',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failCount) {
            $res['failCount'] = $this->failCount;
        }
        if (null !== $this->failInvoices) {
            $res['failInvoices'] = [];
            if (null !== $this->failInvoices && \is_array($this->failInvoices)) {
                $n = 0;
                foreach ($this->failInvoices as $item) {
                    $res['failInvoices'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failCount'])) {
            $model->failCount = $map['failCount'];
        }
        if (isset($map['failInvoices'])) {
            if (!empty($map['failInvoices'])) {
                $model->failInvoices = [];
                $n = 0;
                foreach ($map['failInvoices'] as $item) {
                    $model->failInvoices[$n++] = null !== $item ? failInvoices::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
