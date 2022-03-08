<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\Tea\Model;

class InsertSearchItemRequest extends Model
{
    /**
     * @description 数据项的脚注，长度不能超过64
     *
     * @var string
     */
    public $footer;

    /**
     * @description 数据项的头像，长度不能超过512
     *
     * @var string
     */
    public $icon;

    /**
     * @description 数据项的id，tabId和orgId相同的情况下，itemId唯一标识一条数据项，长度不能超过128
     *
     * @var string
     */
    public $itemId;

    /**
     * @description 数据项的移动端跳转url地址，若同时配置默认url和mobileUrl，移动端跳转链接优先使用mobileUrl
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @description 数据项的PC端跳转url地址，若同时配置默认url和pcUrl，PC端跳转链接优先使用pcUrl
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @description 数据项的摘要，长度不能超过64
     *
     * @var string
     */
    public $summary;

    /**
     * @description 数据项的标题，长度不能超过16
     *
     * @var string
     */
    public $title;

    /**
     * @description 数据项的默认url地址，若mobileUrl或pcUrl没有配置，则使用该url地址，默认url和mobileUrl、pcUrl至少配置其中一个
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'footer'    => 'footer',
        'icon'      => 'icon',
        'itemId'    => 'itemId',
        'mobileUrl' => 'mobileUrl',
        'pcUrl'     => 'pcUrl',
        'summary'   => 'summary',
        'title'     => 'title',
        'url'       => 'url',
    ];

    public function validate()
    {
    }

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
     * @return InsertSearchItemRequest
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
