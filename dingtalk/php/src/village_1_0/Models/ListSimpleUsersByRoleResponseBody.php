<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSimpleUsersByRoleResponseBody\list_;
use AlibabaCloud\Tea\Model;

class ListSimpleUsersByRoleResponseBody extends Model
{
    /**
     * @var list_[]
     */
    public $list;

    /**
     * @var string
     */
    public $nextCursorString;

    /**
     * @var int
     */
    public $nextCursor;

    /**
     * @var bool
     */
    public $hasMore;
    protected $_name = [
        'list'             => 'list',
        'nextCursorString' => 'nextCursorString',
        'nextCursor'       => 'nextCursor',
        'hasMore'          => 'hasMore',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->list) {
            $res['list'] = [];
            if (null !== $this->list && \is_array($this->list)) {
                $n = 0;
                foreach ($this->list as $item) {
                    $res['list'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextCursorString) {
            $res['nextCursorString'] = $this->nextCursorString;
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSimpleUsersByRoleResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['list'])) {
            if (!empty($map['list'])) {
                $model->list = [];
                $n           = 0;
                foreach ($map['list'] as $item) {
                    $model->list[$n++] = null !== $item ? list_::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextCursorString'])) {
            $model->nextCursorString = $map['nextCursorString'];
        }
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }

        return $model;
    }
}
