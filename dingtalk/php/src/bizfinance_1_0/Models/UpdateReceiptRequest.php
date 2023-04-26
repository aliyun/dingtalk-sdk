<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateReceiptRequest\receipts;
use AlibabaCloud\Tea\Model;

class UpdateReceiptRequest extends Model
{
    /**
     * @var receipts[]
     */
    public $receipts;
    protected $_name = [
        'receipts' => 'receipts',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->receipts) {
            $res['receipts'] = [];
            if (null !== $this->receipts && \is_array($this->receipts)) {
                $n = 0;
                foreach ($this->receipts as $item) {
                    $res['receipts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateReceiptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['receipts'])) {
            if (!empty($map['receipts'])) {
                $model->receipts = [];
                $n               = 0;
                foreach ($map['receipts'] as $item) {
                    $model->receipts[$n++] = null !== $item ? receipts::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
