<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\Tea\Model;

class InsertSearchItemRequest extends Model
{
    /**
     * @description 数据项的id，tabId和orgId相同的情况下，itemId唯一标识一条数据项，长度不能超过128
     *
     * @var string
     */
    public $itemId;

    /**
     * @description 数据项的标题，长度不能超过16
     *
     * @var string
     */
    public $title;

    /**
     * @description 数据项的脚注，长度不能超过64
     *
     * @var string
     */
    public $footer;

    /**
     * @description 数据项的摘要，长度不能超过64
     *
     * @var string
     */
    public $summary;

    /**
     * @description 数据项的头像，长度不能超过512
     *
     * @var string
     */
    public $icon;

    /**
     * @description 数据项的跳转url地址
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'itemId'  => 'itemId',
        'title'   => 'title',
        'footer'  => 'footer',
        'summary' => 'summary',
        'icon'    => 'icon',
        'url'     => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemId) {
            $res['itemId'] = $this->itemId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->footer) {
            $res['footer'] = $this->footer;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InsertSearchItemRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemId'])) {
            $model->itemId = $map['itemId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['footer'])) {
            $model->footer = $map['footer'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
