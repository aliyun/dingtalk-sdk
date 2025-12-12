<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChatSummaryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChatSummaryResponseBody\result\basic;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChatSummaryResponseBody\result\product;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var basic[]
     */
    public $basic;

    /**
     * @var product[]
     */
    public $product;
    protected $_name = [
        'basic' => 'basic',
        'product' => 'product',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->basic) {
            $res['basic'] = [];
            if (null !== $this->basic && \is_array($this->basic)) {
                $n = 0;
                foreach ($this->basic as $item) {
                    $res['basic'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->product) {
            $res['product'] = [];
            if (null !== $this->product && \is_array($this->product)) {
                $n = 0;
                foreach ($this->product as $item) {
                    $res['product'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['basic'])) {
            if (!empty($map['basic'])) {
                $model->basic = [];
                $n = 0;
                foreach ($map['basic'] as $item) {
                    $model->basic[$n++] = null !== $item ? basic::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['product'])) {
            if (!empty($map['product'])) {
                $model->product = [];
                $n = 0;
                foreach ($map['product'] as $item) {
                    $model->product[$n++] = null !== $item ? product::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
