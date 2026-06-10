<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListStarsResponseBody\starList;
use AlibabaCloud\Tea\Model;

class ListStarsResponseBody extends Model
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
     * @var starList[]
     */
    public $starList;
    protected $_name = [
        'hasMore' => 'hasMore',
        'nextToken' => 'nextToken',
        'starList' => 'starList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->starList) {
            $res['starList'] = [];
            if (null !== $this->starList && \is_array($this->starList)) {
                $n = 0;
                foreach ($this->starList as $item) {
                    $res['starList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListStarsResponseBody
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
        if (isset($map['starList'])) {
            if (!empty($map['starList'])) {
                $model->starList = [];
                $n = 0;
                foreach ($map['starList'] as $item) {
                    $model->starList[$n++] = null !== $item ? starList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
