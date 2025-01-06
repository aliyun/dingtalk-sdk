<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchQueryOrgInvoiceUrlResponseBody\failInvoiceList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchQueryOrgInvoiceUrlResponseBody\orgInvoiceUrlList;
use AlibabaCloud\Tea\Model;

class BatchQueryOrgInvoiceUrlResponseBody extends Model
{
    /**
     * @var failInvoiceList[]
     */
    public $failInvoiceList;

    /**
     * @var orgInvoiceUrlList[]
     */
    public $orgInvoiceUrlList;
    protected $_name = [
        'failInvoiceList'   => 'failInvoiceList',
        'orgInvoiceUrlList' => 'orgInvoiceUrlList',
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
        if (null !== $this->orgInvoiceUrlList) {
            $res['orgInvoiceUrlList'] = [];
            if (null !== $this->orgInvoiceUrlList && \is_array($this->orgInvoiceUrlList)) {
                $n = 0;
                foreach ($this->orgInvoiceUrlList as $item) {
                    $res['orgInvoiceUrlList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryOrgInvoiceUrlResponseBody
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
        if (isset($map['orgInvoiceUrlList'])) {
            if (!empty($map['orgInvoiceUrlList'])) {
                $model->orgInvoiceUrlList = [];
                $n                        = 0;
                foreach ($map['orgInvoiceUrlList'] as $item) {
                    $model->orgInvoiceUrlList[$n++] = null !== $item ? orgInvoiceUrlList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
