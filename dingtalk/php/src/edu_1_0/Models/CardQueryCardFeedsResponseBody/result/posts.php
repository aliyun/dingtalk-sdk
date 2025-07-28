<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsResponseBody\result\posts\author;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsResponseBody\result\posts\content;
use AlibabaCloud\Tea\Model;

class posts extends Model
{
    /**
     * @var author
     */
    public $author;

    /**
     * @example 3
     *
     * @var int
     */
    public $bizType;

    /**
     * @var content
     */
    public $content;

    /**
     * @example 23424234234
     *
     * @var int
     */
    public $createAt;

    /**
     * @example 0
     *
     * @var int
     */
    public $feedType;

    /**
     * @example 232423423
     *
     * @var int
     */
    public $postId;

    /**
     * @example 0
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'author' => 'author',
        'bizType' => 'bizType',
        'content' => 'content',
        'createAt' => 'createAt',
        'feedType' => 'feedType',
        'postId' => 'postId',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->author) {
            $res['author'] = null !== $this->author ? $this->author->toMap() : null;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->content) {
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }
        if (null !== $this->createAt) {
            $res['createAt'] = $this->createAt;
        }
        if (null !== $this->feedType) {
            $res['feedType'] = $this->feedType;
        }
        if (null !== $this->postId) {
            $res['postId'] = $this->postId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return posts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['author'])) {
            $model->author = author::fromMap($map['author']);
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }
        if (isset($map['createAt'])) {
            $model->createAt = $map['createAt'];
        }
        if (isset($map['feedType'])) {
            $model->feedType = $map['feedType'];
        }
        if (isset($map['postId'])) {
            $model->postId = $map['postId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
