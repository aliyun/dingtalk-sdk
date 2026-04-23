<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeListResponseBody\result;

use AlibabaCloud\Tea\Model;

class tagLikes extends Model
{
    /**
     * @var bool
     */
    public $hasLiked;

    /**
     * @var int
     */
    public $likeCount;

    /**
     * @var string
     */
    public $tagCode;

    /**
     * @var string
     */
    public $tagName;
    protected $_name = [
        'hasLiked' => 'hasLiked',
        'likeCount' => 'likeCount',
        'tagCode' => 'tagCode',
        'tagName' => 'tagName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasLiked) {
            $res['hasLiked'] = $this->hasLiked;
        }
        if (null !== $this->likeCount) {
            $res['likeCount'] = $this->likeCount;
        }
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tagLikes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasLiked'])) {
            $model->hasLiked = $map['hasLiked'];
        }
        if (isset($map['likeCount'])) {
            $model->likeCount = $map['likeCount'];
        }
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }

        return $model;
    }
}
