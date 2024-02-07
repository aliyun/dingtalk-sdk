<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRecentsResponseBody\recentDentryList;
use AlibabaCloud\Tea\Model;

class ListRecentsResponseBody extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @example nextToken
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example recentDentryList
     *
     * @var recentDentryList[]
     */
    public $recentDentryList;
    protected $_name = [
        'hasMore'          => 'hasMore',
        'nextToken'        => 'nextToken',
        'recentDentryList' => 'recentDentryList',
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
        if (null !== $this->recentDentryList) {
            $res['recentDentryList'] = [];
            if (null !== $this->recentDentryList && \is_array($this->recentDentryList)) {
                $n = 0;
                foreach ($this->recentDentryList as $item) {
                    $res['recentDentryList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListRecentsResponseBody
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
        if (isset($map['recentDentryList'])) {
            if (!empty($map['recentDentryList'])) {
                $model->recentDentryList = [];
                $n                       = 0;
                foreach ($map['recentDentryList'] as $item) {
                    $model->recentDentryList[$n++] = null !== $item ? recentDentryList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
