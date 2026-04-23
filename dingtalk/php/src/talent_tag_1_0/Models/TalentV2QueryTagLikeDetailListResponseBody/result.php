<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeDetailListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeDetailListResponseBody\result\likeDetails;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var likeDetails[]
     */
    public $likeDetails;

    /**
     * @var int
     */
    public $nextCursor;
    protected $_name = [
        'hasMore' => 'hasMore',
        'likeDetails' => 'likeDetails',
        'nextCursor' => 'nextCursor',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->likeDetails) {
            $res['likeDetails'] = [];
            if (null !== $this->likeDetails && \is_array($this->likeDetails)) {
                $n = 0;
                foreach ($this->likeDetails as $item) {
                    $res['likeDetails'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
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
        if (isset($map['likeDetails'])) {
            if (!empty($map['likeDetails'])) {
                $model->likeDetails = [];
                $n = 0;
                foreach ($map['likeDetails'] as $item) {
                    $model->likeDetails[$n++] = null !== $item ? likeDetails::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }

        return $model;
    }
}
