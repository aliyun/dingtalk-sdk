<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryMsgSendRecordsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryMsgSendRecordsResponseBody\result\items;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $itemCount;

    /**
     * @var items[]
     */
    public $items;

    /**
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'itemCount' => 'item_count',
        'items' => 'items',
        'totalCount' => 'total_count',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemCount) {
            $res['item_count'] = $this->itemCount;
        }
        if (null !== $this->items) {
            $res['items'] = [];
            if (null !== $this->items && \is_array($this->items)) {
                $n = 0;
                foreach ($this->items as $item) {
                    $res['items'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalCount) {
            $res['total_count'] = $this->totalCount;
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
        if (isset($map['item_count'])) {
            $model->itemCount = $map['item_count'];
        }
        if (isset($map['items'])) {
            if (!empty($map['items'])) {
                $model->items = [];
                $n = 0;
                foreach ($map['items'] as $item) {
                    $model->items[$n++] = null !== $item ? items::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['total_count'])) {
            $model->totalCount = $map['total_count'];
        }

        return $model;
    }
}
