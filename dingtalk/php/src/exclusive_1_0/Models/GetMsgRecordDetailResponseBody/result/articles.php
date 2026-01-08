<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgRecordDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class articles extends Model
{
    /**
     * @example 129003
     *
     * @var int
     */
    public $articleId;

    /**
     * @var string
     */
    public $content;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $digest;

    /**
     * @var int
     */
    public $publishStatus;

    /**
     * @var int
     */
    public $publishTime;

    /**
     * @var string
     */
    public $thumbMediaId;

    /**
     * @var string
     */
    public $title;

    /**
     * @var int
     */
    public $updateTime;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'articleId' => 'article_id',
        'content' => 'content',
        'createTime' => 'create_time',
        'digest' => 'digest',
        'publishStatus' => 'publish_status',
        'publishTime' => 'publish_time',
        'thumbMediaId' => 'thumb_media_id',
        'title' => 'title',
        'updateTime' => 'update_time',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->articleId) {
            $res['article_id'] = $this->articleId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->createTime) {
            $res['create_time'] = $this->createTime;
        }
        if (null !== $this->digest) {
            $res['digest'] = $this->digest;
        }
        if (null !== $this->publishStatus) {
            $res['publish_status'] = $this->publishStatus;
        }
        if (null !== $this->publishTime) {
            $res['publish_time'] = $this->publishTime;
        }
        if (null !== $this->thumbMediaId) {
            $res['thumb_media_id'] = $this->thumbMediaId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->updateTime) {
            $res['update_time'] = $this->updateTime;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return articles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['article_id'])) {
            $model->articleId = $map['article_id'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['create_time'])) {
            $model->createTime = $map['create_time'];
        }
        if (isset($map['digest'])) {
            $model->digest = $map['digest'];
        }
        if (isset($map['publish_status'])) {
            $model->publishStatus = $map['publish_status'];
        }
        if (isset($map['publish_time'])) {
            $model->publishTime = $map['publish_time'];
        }
        if (isset($map['thumb_media_id'])) {
            $model->thumbMediaId = $map['thumb_media_id'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['update_time'])) {
            $model->updateTime = $map['update_time'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
