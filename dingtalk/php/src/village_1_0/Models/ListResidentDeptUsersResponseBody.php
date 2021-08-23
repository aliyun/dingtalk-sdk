<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentDeptUsersResponseBody\list_;
use AlibabaCloud\Tea\Model;

class ListResidentDeptUsersResponseBody extends Model
{
    /**
     * @description 下一个游标
     *
     * @var int
     */
    public $nextCursor;

    /**
     * @description 是否还有更多数据
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 分页数据
     *
     * @var list_[]
     */
    public $list;
    protected $_name = [
        'nextCursor' => 'nextCursor',
        'hasMore'    => 'hasMore',
        'list'       => 'list',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->list) {
            $res['list'] = [];
            if (null !== $this->list && \is_array($this->list)) {
                $n = 0;
                foreach ($this->list as $item) {
                    $res['list'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListResidentDeptUsersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['list'])) {
            if (!empty($map['list'])) {
                $model->list = [];
                $n           = 0;
                foreach ($map['list'] as $item) {
                    $model->list[$n++] = null !== $item ? list_::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
