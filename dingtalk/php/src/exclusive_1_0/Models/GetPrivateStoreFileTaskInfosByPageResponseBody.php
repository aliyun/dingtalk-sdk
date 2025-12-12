<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreFileTaskInfosByPageResponseBody\items;
use AlibabaCloud\Tea\Model;

class GetPrivateStoreFileTaskInfosByPageResponseBody extends Model
{
    /**
     * @example true
     *
     * @var int
     */
    public $hasNext;

    /**
     * @example 100
     *
     * @var int
     */
    public $itemCount;

    /**
     * @var items[]
     */
    public $items;

    /**
     * @example 200
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'hasNext' => 'hasNext',
        'itemCount' => 'itemCount',
        'items' => 'items',
        'totalCount' => 'totalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasNext) {
            $res['hasNext'] = $this->hasNext;
        }
        if (null !== $this->itemCount) {
            $res['itemCount'] = $this->itemCount;
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
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPrivateStoreFileTaskInfosByPageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasNext'])) {
            $model->hasNext = $map['hasNext'];
        }
        if (isset($map['itemCount'])) {
            $model->itemCount = $map['itemCount'];
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
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
