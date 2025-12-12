<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CirclePostRecordResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CirclePostRecordResponseBody\result\postsList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $direction;

    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var int
     */
    public $lastPostId;

    /**
     * @var postsList[]
     */
    public $postsList;
    protected $_name = [
        'direction' => 'direction',
        'hasMore' => 'hasMore',
        'lastPostId' => 'lastPostId',
        'postsList' => 'postsList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->direction) {
            $res['direction'] = $this->direction;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->lastPostId) {
            $res['lastPostId'] = $this->lastPostId;
        }
        if (null !== $this->postsList) {
            $res['postsList'] = [];
            if (null !== $this->postsList && \is_array($this->postsList)) {
                $n = 0;
                foreach ($this->postsList as $item) {
                    $res['postsList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['direction'])) {
            $model->direction = $map['direction'];
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['lastPostId'])) {
            $model->lastPostId = $map['lastPostId'];
        }
        if (isset($map['postsList'])) {
            if (!empty($map['postsList'])) {
                $model->postsList = [];
                $n = 0;
                foreach ($map['postsList'] as $item) {
                    $model->postsList[$n++] = null !== $item ? postsList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
