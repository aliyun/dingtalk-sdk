<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryOrgConferenceListResponseBody\onGoingConfList;
use AlibabaCloud\Tea\Model;

class QueryOrgConferenceListResponseBody extends Model
{
    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var onGoingConfList[]
     */
    public $onGoingConfList;

    /**
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'hasMore'         => 'hasMore',
        'nextToken'       => 'nextToken',
        'onGoingConfList' => 'onGoingConfList',
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
        if (null !== $this->onGoingConfList) {
            $res['onGoingConfList'] = [];
            if (null !== $this->onGoingConfList && \is_array($this->onGoingConfList)) {
                $n = 0;
                foreach ($this->onGoingConfList as $item) {
                    $res['onGoingConfList'][$n++] = null !== $item ? $item->toMap() : $item;
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
     * @return QueryOrgConferenceListResponseBody
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
        if (isset($map['onGoingConfList'])) {
            if (!empty($map['onGoingConfList'])) {
                $model->onGoingConfList = [];
                $n                      = 0;
                foreach ($map['onGoingConfList'] as $item) {
                    $model->onGoingConfList[$n++] = null !== $item ? onGoingConfList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
