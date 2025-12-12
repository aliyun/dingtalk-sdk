<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChatSummaryResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetServiceChatSummaryResponseBody\result\product\itemList;
use AlibabaCloud\Tea\Model;

class product extends Model
{
    /**
     * @var itemList[]
     */
    public $itemList;

    /**
     * @var string
     */
    public $product;
    protected $_name = [
        'itemList' => 'itemList',
        'product' => 'product',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemList) {
            $res['itemList'] = [];
            if (null !== $this->itemList && \is_array($this->itemList)) {
                $n = 0;
                foreach ($this->itemList as $item) {
                    $res['itemList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->product) {
            $res['product'] = $this->product;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return product
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemList'])) {
            if (!empty($map['itemList'])) {
                $model->itemList = [];
                $n = 0;
                foreach ($map['itemList'] as $item) {
                    $model->itemList[$n++] = null !== $item ? itemList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['product'])) {
            $model->product = $map['product'];
        }

        return $model;
    }
}
