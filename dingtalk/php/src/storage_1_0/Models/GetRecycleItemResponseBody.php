<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleItemResponseBody\item;
use AlibabaCloud\Tea\Model;

class GetRecycleItemResponseBody extends Model
{
    /**
     * @description 回收项信息
     *
     * @var item
     */
    public $item;
    protected $_name = [
        'item' => 'item',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->item) {
            $res['item'] = null !== $this->item ? $this->item->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRecycleItemResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['item'])) {
            $model->item = item::fromMap($map['item']);
        }

        return $model;
    }
}
