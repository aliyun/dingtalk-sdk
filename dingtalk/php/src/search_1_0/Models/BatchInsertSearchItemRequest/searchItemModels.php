<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\BatchInsertSearchItemRequest;

use AlibabaCloud\Tea\Model;

class searchItemModels extends Model
{
    /**
     * @example 四大名著
     *
     * @var string
     */
    public $footer;

    /**
     * @var string
     */
    public $icon;

    /**
     * @description This parameter is required.
     *
     * @example 1111
     *
     * @var string
     */
    public $itemId;

    /**
     * @example www.baidu.com
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @example www.baidu.com
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @example 中国古代章回体长篇小说
     *
     * @var string
     */
    public $summary;

    /**
     * @description This parameter is required.
     *
     * @example 红楼梦
     *
     * @var string
     */
    public $title;

    /**
     * @example www.baidu.com
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'footer' => 'footer',
        'icon' => 'icon',
        'itemId' => 'itemId',
        'mobileUrl' => 'mobileUrl',
        'pcUrl' => 'pcUrl',
        'summary' => 'summary',
        'title' => 'title',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->footer) {
            $res['footer'] = $this->footer;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->itemId) {
            $res['itemId'] = $this->itemId;
        }
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
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
     * @return searchItemModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['footer'])) {
            $model->footer = $map['footer'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['itemId'])) {
            $model->itemId = $map['itemId'];
        }
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
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
