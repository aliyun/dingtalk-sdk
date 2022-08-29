<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UnbindApplyReceiptAndInvoiceRelatedResponseBody\batchUpdateInvoiceResponse;
use AlibabaCloud\Tea\Model;

class UnbindApplyReceiptAndInvoiceRelatedResponseBody extends Model
{
    /**
     * @description 批量更新发票返回结果
     *
     *
     * @var batchUpdateInvoiceResponse
     */
    public $batchUpdateInvoiceResponse;

    /**
     * @description 是否成功
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'batchUpdateInvoiceResponse' => 'batchUpdateInvoiceResponse',
        'success'                    => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->batchUpdateInvoiceResponse) {
            $res['batchUpdateInvoiceResponse'] = null !== $this->batchUpdateInvoiceResponse ? $this->batchUpdateInvoiceResponse->toMap() : null;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UnbindApplyReceiptAndInvoiceRelatedResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['batchUpdateInvoiceResponse'])) {
            $model->batchUpdateInvoiceResponse = batchUpdateInvoiceResponse::fromMap($map['batchUpdateInvoiceResponse']);
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
