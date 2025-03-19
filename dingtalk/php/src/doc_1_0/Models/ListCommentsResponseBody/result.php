<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListCommentsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListCommentsResponseBody\result\commentList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var commentList[]
     */
    public $commentList;

    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @example next_token
     *
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'commentList' => 'commentList',
        'hasMore' => 'hasMore',
        'nextToken' => 'nextToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commentList) {
            $res['commentList'] = [];
            if (null !== $this->commentList && \is_array($this->commentList)) {
                $n = 0;
                foreach ($this->commentList as $item) {
                    $res['commentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commentList'])) {
            if (!empty($map['commentList'])) {
                $model->commentList = [];
                $n = 0;
                foreach ($map['commentList'] as $item) {
                    $model->commentList[$n++] = null !== $item ? commentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
