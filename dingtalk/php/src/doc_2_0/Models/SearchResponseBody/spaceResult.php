<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\spaceResult\items;
use AlibabaCloud\Tea\Model;

class spaceResult extends Model
{
    /**
     * @description 是否还有更多数据。
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 搜索命中的知识库列表。
     *
     * @var items[]
     */
    public $items;

    /**
     * @description 分页游标。
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'hasMore'   => 'hasMore',
        'items'     => 'items',
        'nextToken' => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return spaceResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['items'])) {
            if (!empty($map['items'])) {
                $model->items = [];
                $n            = 0;
                foreach ($map['items'] as $item) {
                    $model->items[$n++] = null !== $item ? items::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
