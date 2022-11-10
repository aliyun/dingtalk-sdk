<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\ListRecycleItemsResponseBody\recycleItems;
use AlibabaCloud\Tea\Model;

class ListRecycleItemsResponseBody extends Model
{
    /**
     * @description 分页游标
     * 不为空表示有更多数据
     * @var string
     */
    public $nextToken;

    /**
     * @description 回收项列表
     * 50
     * @var recycleItems[]
     */
    public $recycleItems;
    protected $_name = [
        'nextToken'    => 'nextToken',
        'recycleItems' => 'recycleItems',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->recycleItems) {
            $res['recycleItems'] = [];
            if (null !== $this->recycleItems && \is_array($this->recycleItems)) {
                $n = 0;
                foreach ($this->recycleItems as $item) {
                    $res['recycleItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListRecycleItemsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['recycleItems'])) {
            if (!empty($map['recycleItems'])) {
                $model->recycleItems = [];
                $n                   = 0;
                foreach ($map['recycleItems'] as $item) {
                    $model->recycleItems[$n++] = null !== $item ? recycleItems::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
