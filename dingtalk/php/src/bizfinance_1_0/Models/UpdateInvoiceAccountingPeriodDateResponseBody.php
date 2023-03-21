<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingPeriodDateResponseBody\failInvoices;
use AlibabaCloud\Tea\Model;

class UpdateInvoiceAccountingPeriodDateResponseBody extends Model
{
    /**
     * @description 返回结果
     *
     * @var failInvoices[]
     */
    public $failInvoices;
    protected $_name = [
        'failInvoices' => 'failInvoices',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->failInvoices) {
            $res['failInvoices'] = [];
            if (null !== $this->failInvoices && \is_array($this->failInvoices)) {
                $n = 0;
                foreach ($this->failInvoices as $item) {
                    $res['failInvoices'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInvoiceAccountingPeriodDateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failInvoices'])) {
            if (!empty($map['failInvoices'])) {
                $model->failInvoices = [];
                $n                   = 0;
                foreach ($map['failInvoices'] as $item) {
                    $model->failInvoices[$n++] = null !== $item ? failInvoices::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
