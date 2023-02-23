<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnReadMessageResponseBody\unReadItems;
use AlibabaCloud\Tea\Model;

class QueryUnReadMessageResponseBody extends Model
{
    /**
     * @description 未读消息数。
     *
     * @var int
     */
    public $unReadCount;

    /**
     * @description 未读消息列表。
     *
     * @var unReadItems[]
     */
    public $unReadItems;
    protected $_name = [
        'unReadCount' => 'unReadCount',
        'unReadItems' => 'unReadItems',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unReadCount) {
            $res['unReadCount'] = $this->unReadCount;
        }
        if (null !== $this->unReadItems) {
            $res['unReadItems'] = [];
            if (null !== $this->unReadItems && \is_array($this->unReadItems)) {
                $n = 0;
                foreach ($this->unReadItems as $item) {
                    $res['unReadItems'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUnReadMessageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unReadCount'])) {
            $model->unReadCount = $map['unReadCount'];
        }
        if (isset($map['unReadItems'])) {
            if (!empty($map['unReadItems'])) {
                $model->unReadItems = [];
                $n                  = 0;
                foreach ($map['unReadItems'] as $item) {
                    $model->unReadItems[$n++] = null !== $item ? unReadItems::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
