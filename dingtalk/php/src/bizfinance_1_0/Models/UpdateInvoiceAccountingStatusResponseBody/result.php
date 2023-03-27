<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAccountingStatusResponseBody\result\failInvoices;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 失败发票数
     *
     * @var int
     */
    public $failCount;

    /**
     * @description 失败发票列表
     *
     * @var failInvoices[]
     */
    public $failInvoices;

    /**
     * @description 是否成功
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'failCount'    => 'failCount',
        'failInvoices' => 'failInvoices',
        'success'      => 'success',
    ];

    public function validate()
    {
    }

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
                $n                   = 0;
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
