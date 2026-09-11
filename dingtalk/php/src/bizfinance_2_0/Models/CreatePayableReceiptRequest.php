<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePayableReceiptRequest\receipt;
use AlibabaCloud\Tea\Model;

class CreatePayableReceiptRequest extends Model
{
    /**
     * @var receipt
     */
    public $receipt;
    protected $_name = [
        'receipt' => 'receipt',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->receipt) {
            $res['receipt'] = null !== $this->receipt ? $this->receipt->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreatePayableReceiptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['receipt'])) {
            $model->receipt = receipt::fromMap($map['receipt']);
        }

        return $model;
    }
}
