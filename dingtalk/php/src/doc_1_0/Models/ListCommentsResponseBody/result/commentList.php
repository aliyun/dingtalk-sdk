<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListCommentsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListCommentsResponseBody\result\commentList\content;
use AlibabaCloud\Tea\Model;

class commentList extends Model
{
    /**
     * @example comment_id
     *
     * @var string
     */
    public $commentId;

    /**
     * @var content
     */
    public $content;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @example user_id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @var bool
     */
    public $isGlobal;

    /**
     * @example quote
     *
     * @var bool
     */
    public $isSolved;

    /**
     * @example quote
     *
     * @var string
     */
    public $quote;

    /**
     * @example topic_id
     *
     * @var string
     */
    public $topicId;

    /**
     * @var int
     */
    public $updateTime;
    protected $_name = [
        'commentId' => 'commentId',
        'content' => 'content',
        'createTime' => 'createTime',
        'creatorId' => 'creatorId',
        'isGlobal' => 'isGlobal',
        'isSolved' => 'isSolved',
        'quote' => 'quote',
        'topicId' => 'topicId',
        'updateTime' => 'updateTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commentId) {
            $res['commentId'] = $this->commentId;
        }
        if (null !== $this->content) {
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->isGlobal) {
            $res['isGlobal'] = $this->isGlobal;
        }
        if (null !== $this->isSolved) {
            $res['isSolved'] = $this->isSolved;
        }
        if (null !== $this->quote) {
            $res['quote'] = $this->quote;
        }
        if (null !== $this->topicId) {
            $res['topicId'] = $this->topicId;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return commentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commentId'])) {
            $model->commentId = $map['commentId'];
        }
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['isGlobal'])) {
            $model->isGlobal = $map['isGlobal'];
        }
        if (isset($map['isSolved'])) {
            $model->isSolved = $map['isSolved'];
        }
        if (isset($map['quote'])) {
            $model->quote = $map['quote'];
        }
        if (isset($map['topicId'])) {
            $model->topicId = $map['topicId'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }

        return $model;
    }
}
