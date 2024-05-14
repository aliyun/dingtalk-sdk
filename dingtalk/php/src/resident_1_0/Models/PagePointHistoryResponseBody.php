<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\PagePointHistoryResponseBody\pointRecordList;
use AlibabaCloud\Tea\Model;

class PagePointHistoryResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description This parameter is required.
     *
     * @example 3276
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var pointRecordList[]
     */
    public $pointRecordList;

    /**
     * @description This parameter is required.
     *
     * @example -1
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
