<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskObjectLinkRequest;

use AlibabaCloud\Tea\Model;

class linkedData extends Model
{
    /**
     * @description 关联对象描述
     *
     * @var string
     */
    public $content;

    /**
     * @description 关联对象头像url
     *
     * @var string
     */
    public $thumbnailUrl;

    /**
     * @description 关联对象标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 关联对象链接url
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
