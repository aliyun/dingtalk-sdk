<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInvoiceUrlResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\UpdateInvoiceUrlResponseBody\result\failInvoiceList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var failInvoiceList[]
     */
    public $failInvoiceList;

    /**
     * @var string
     */
    public $isAllSuccess;
    protected $_name = [
        'failInvoiceList' => 'failInvoiceList',
        'isAllSuccess'    => 'isAllSuccess',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->failInvoiceList) {
            $res['failInvoiceList'] = [];
            if (null !== $this->failInvoiceList && \is_array($this->failInvoiceList)) {
                $n = 0;
                foreach ($this->failInvoiceList as $item) {
                    $res['failInvoiceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isAllSuccess) {
            $res['isAllSuccess'] = $this->isAllSuccess;
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
        if (isset($map['failInvoiceList'])) {
            if (!empty($map['failInvoiceList'])) {
                $model->failInvoiceList = [];
                $n                      = 0;
                foreach ($map['failInvoiceList'] as $item) {
                    $model->failInvoiceList[$n++] = null !== $item ? failInvoiceList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isAllSuccess'])) {
            $model->isAllSuccess = $map['isAllSuccess'];
        }

        return $model;
    }
}
