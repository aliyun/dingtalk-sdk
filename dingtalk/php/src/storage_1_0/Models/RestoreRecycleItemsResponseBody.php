<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\RestoreRecycleItemsResponseBody\resultItems;
use AlibabaCloud\Tea\Model;

class RestoreRecycleItemsResponseBody extends Model
{
    /**
     * @var resultItems[]
     */
    public $resultItems;
    protected $_name = [
        'resultItems' => 'resultItems',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->resultItems) {
            $res['resultItems'] = [];
            if (null !== $this->resultItems && \is_array($this->resultItems)) {
                $n = 0;
                foreach ($this->resultItems as $item) {
                    $res['resultItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RestoreRecycleItemsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['resultItems'])) {
            if (!empty($map['resultItems'])) {
                $model->resultItems = [];
                $n                  = 0;
                foreach ($map['resultItems'] as $item) {
                    $model->resultItems[$n++] = null !== $item ? resultItems::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
