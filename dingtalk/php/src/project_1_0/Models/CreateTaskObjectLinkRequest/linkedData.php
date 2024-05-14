<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskObjectLinkRequest;

use AlibabaCloud\Tea\Model;

class linkedData extends Model
{
    /**
     * @example 我是内容
     *
     * @var string
     */
    public $content;

    /**
     * @example https://abc.com/url
     *
     * @var string
     */
    public $thumbnailUrl;

    /**
     * @description This parameter is required.
     *
     * @example 我是标题
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example https://abcd.com/url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'content'      => 'content',
        'thumbnailUrl' => 'thumbnailUrl',
        'title'        => 'title',
        'url'          => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->thumbnailUrl) {
            $res['thumbnailUrl'] = $this->thumbnailUrl;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return linkedData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['thumbnailUrl'])) {
            $model->thumbnailUrl = $map['thumbnailUrl'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
