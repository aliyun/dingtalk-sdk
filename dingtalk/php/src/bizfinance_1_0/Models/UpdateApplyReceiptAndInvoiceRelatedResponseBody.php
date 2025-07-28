<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateApplyReceiptAndInvoiceRelatedResponseBody\batchUpdateInvoiceResponse;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateApplyReceiptAndInvoiceRelatedResponseBody\errorInvoiceKeyVOList;
use AlibabaCloud\Tea\Model;

class UpdateApplyReceiptAndInvoiceRelatedResponseBody extends Model
{
    /**
     * @var batchUpdateInvoiceResponse
     */
    public $batchUpdateInvoiceResponse;

    /**
     * @var errorInvoiceKeyVOList[]
     */
    public $errorInvoiceKeyVOList;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'batchUpdateInvoiceResponse' => 'batchUpdateInvoiceResponse',
        'errorInvoiceKeyVOList' => 'errorInvoiceKeyVOList',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->batchUpdateInvoiceResponse) {
            $res['batchUpdateInvoiceResponse'] = null !== $this->batchUpdateInvoiceResponse ? $this->batchUpdateInvoiceResponse->toMap() : null;
        }
        if (null !== $this->errorInvoiceKeyVOList) {
            $res['errorInvoiceKeyVOList'] = [];
            if (null !== $this->errorInvoiceKeyVOList && \is_array($this->errorInvoiceKeyVOList)) {
                $n = 0;
                foreach ($this->errorInvoiceKeyVOList as $item) {
                    $res['errorInvoiceKeyVOList'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return UpdateApplyReceiptAndInvoiceRelatedResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['batchUpdateInvoiceResponse'])) {
            $model->batchUpdateInvoiceResponse = batchUpdateInvoiceResponse::fromMap($map['batchUpdateInvoiceResponse']);
        }
        if (isset($map['errorInvoiceKeyVOList'])) {
            if (!empty($map['errorInvoiceKeyVOList'])) {
                $model->errorInvoiceKeyVOList = [];
                $n = 0;
                foreach ($map['errorInvoiceKeyVOList'] as $item) {
                    $model->errorInvoiceKeyVOList[$n++] = null !== $item ? errorInvoiceKeyVOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
