<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeListResponseBody\result\tagLikes;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var tagLikes[]
     */
    public $tagLikes;
    protected $_name = [
        'tagLikes' => 'tagLikes',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->tagLikes) {
            $res['tagLikes'] = [];
            if (null !== $this->tagLikes && \is_array($this->tagLikes)) {
                $n = 0;
                foreach ($this->tagLikes as $item) {
                    $res['tagLikes'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['tagLikes'])) {
            if (!empty($map['tagLikes'])) {
                $model->tagLikes = [];
                $n = 0;
                foreach ($map['tagLikes'] as $item) {
                    $model->tagLikes[$n++] = null !== $item ? tagLikes::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
