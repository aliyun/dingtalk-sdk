<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\PageFeedResponseBody\feedList;
use AlibabaCloud\Tea\Model;

class PageFeedResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var feedList[]
     */
    public $feedList;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $hasNext;

    /**
     * @description This parameter is required.
     *
     * @example 20
     *
     * @var int
     */
    public $nextCursor;
    protected $_name = [
        'feedList'   => 'feedList',
        'hasNext'    => 'hasNext',
        'nextCursor' => 'nextCursor',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->feedList) {
            $res['feedList'] = [];
            if (null !== $this->feedList && \is_array($this->feedList)) {
                $n = 0;
                foreach ($this->feedList as $item) {
                    $res['feedList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasNext) {
            $res['hasNext'] = $this->hasNext;
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageFeedResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['feedList'])) {
            if (!empty($map['feedList'])) {
                $model->feedList = [];
                $n               = 0;
                foreach ($map['feedList'] as $item) {
                    $model->feedList[$n++] = null !== $item ? feedList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasNext'])) {
            $model->hasNext = $map['hasNext'];
        }
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }

        return $model;
    }
}
