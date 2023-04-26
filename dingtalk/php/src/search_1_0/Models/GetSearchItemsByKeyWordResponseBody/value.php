<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models\GetSearchItemsByKeyWordResponseBody;

use AlibabaCloud\Tea\Model;

class value extends Model
{
    /**
     * @example 四大名著
     *
     * @var string
     */
    public $footer;

    /**
     * @example 2021-09-17T19:43Z
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @example 2021-09-17T19:43Z
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $icon;

    /**
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
     * @example 3333
     *
     * @var int
     */
    public $tabId;

    /**
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
        'footer'      => 'footer',
        'gmtCreate'   => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'icon'        => 'icon',
        'itemId'      => 'itemId',
        'mobileUrl'   => 'mobileUrl',
        'pcUrl'       => 'pcUrl',
        'summary'     => 'summary',
        'tabId'       => 'tabId',
        'title'       => 'title',
        'url'         => 'url',
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
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
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
        if (null !== $this->tabId) {
            $res['tabId'] = $this->tabId;
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
     * @return value
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['footer'])) {
            $model->footer = $map['footer'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
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
        if (isset($map['tabId'])) {
            $model->tabId = $map['tabId'];
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
