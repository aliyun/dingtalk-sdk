<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryRecentListResponseBody\recentList;
use AlibabaCloud\Tea\Model;

class QueryRecentListResponseBody extends Model
{
    /**
     * @description 是否还有更多数据。
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 分页游标。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 子节点列表。
     *
     * @var recentList[]
     */
    public $recentList;
    protected $_name = [
        'hasMore'    => 'hasMore',
        'nextToken'  => 'nextToken',
        'recentList' => 'recentList',
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
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->recentList) {
            $res['recentList'] = [];
            if (null !== $this->recentList && \is_array($this->recentList)) {
                $n = 0;
                foreach ($this->recentList as $item) {
                    $res['recentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRecentListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['recentList'])) {
            if (!empty($map['recentList'])) {
                $model->recentList = [];
                $n                 = 0;
                foreach ($map['recentList'] as $item) {
                    $model->recentList[$n++] = null !== $item ? recentList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
