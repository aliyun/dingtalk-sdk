<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListRobotResponseBody\list_;
use AlibabaCloud\Tea\Model;

class PageListRobotResponseBody extends Model
{
    /**
     * @description 是否有更多结果
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 查询结果列表
     *
     * @var list_[]
     */
    public $list;

    /**
     * @description 下一次查询起始游标
     *
     * @var int
     */
    public $nextCursor;

    /**
     * @description 查询结果总数
     *
     * @var int
     */
    public $total;
    protected $_name = [
        'hasMore'    => 'hasMore',
        'list'       => 'list',
        'nextCursor' => 'nextCursor',
        'total'      => 'total',
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
        if (null !== $this->list) {
            $res['list'] = [];
            if (null !== $this->list && \is_array($this->list)) {
                $n = 0;
                foreach ($this->list as $item) {
                    $res['list'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageListRobotResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
