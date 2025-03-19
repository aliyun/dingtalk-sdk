<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsResponseBody\result\posts;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var posts[]
     */
    public $posts;
    protected $_name = [
        'hasMore' => 'hasMore',
        'posts' => 'posts',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->posts) {
            $res['posts'] = [];
            if (null !== $this->posts && \is_array($this->posts)) {
                $n = 0;
                foreach ($this->posts as $item) {
                    $res['posts'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['posts'])) {
            if (!empty($map['posts'])) {
                $model->posts = [];
                $n = 0;
                foreach ($map['posts'] as $item) {
                    $model->posts[$n++] = null !== $item ? posts::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
