<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\PagePointHistoryResponseBody\pointRecordList;
use AlibabaCloud\Tea\Model;

class PagePointHistoryResponseBody extends Model
{
    /**
     * @description 是否有下一页
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 下一个游标值
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 查询所得积分流水集合
     *
     * @var pointRecordList[]
     */
    public $pointRecordList;

    /**
     * @description 总数，如果为-1则不计算总数
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'hasMore'         => 'hasMore',
        'nextToken'       => 'nextToken',
        'pointRecordList' => 'pointRecordList',
        'totalCount'      => 'totalCount',
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
        if (null !== $this->pointRecordList) {
            $res['pointRecordList'] = [];
            if (null !== $this->pointRecordList && \is_array($this->pointRecordList)) {
                $n = 0;
                foreach ($this->pointRecordList as $item) {
                    $res['pointRecordList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PagePointHistoryResponseBody
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
        if (isset($map['pointRecordList'])) {
            if (!empty($map['pointRecordList'])) {
                $model->pointRecordList = [];
                $n                      = 0;
                foreach ($map['pointRecordList'] as $item) {
                    $model->pointRecordList[$n++] = null !== $item ? pointRecordList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
