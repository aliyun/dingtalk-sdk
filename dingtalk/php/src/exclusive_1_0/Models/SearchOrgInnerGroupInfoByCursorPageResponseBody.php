<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SearchOrgInnerGroupInfoByCursorPageResponseBody\items;
use AlibabaCloud\Tea\Model;

class SearchOrgInnerGroupInfoByCursorPageResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasNext;

    /**
     * @var items[]
     */
    public $items;

    /**
     * @var int
     */
    public $nextCursor;
    protected $_name = [
        'hasNext' => 'hasNext',
        'items' => 'items',
        'nextCursor' => 'nextCursor',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasNext) {
            $res['hasNext'] = $this->hasNext;
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
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchOrgInnerGroupInfoByCursorPageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasNext'])) {
            $model->hasNext = $map['hasNext'];
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
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }

        return $model;
    }
}
