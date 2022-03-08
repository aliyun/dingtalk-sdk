<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetFeedResponseBody;

use AlibabaCloud\Tea\Model;

class feedItem extends Model
{
    /**
     * @description 子内容的持续时长，单位为毫秒
     *
     * @var int
     */
    public $durationMillis;

    /**
     * @description 内容类型，0表示直播，1表示图文，2表示视频，3表示音频
     *
     * @var int
     */
    public $feedContentType;

    /**
     * @description 子内容Id
     *
     * @var string
     */
    public $itemId;

    /**
     * @description 子内容标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 子内容的跳转链接
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'durationMillis'  => 'durationMillis',
        'feedContentType' => 'feedContentType',
        'itemId'          => 'itemId',
        'title'           => 'title',
        'url'             => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->durationMillis) {
            $res['durationMillis'] = $this->durationMillis;
        }
        if (null !== $this->feedContentType) {
            $res['feedContentType'] = $this->feedContentType;
        }
        if (null !== $this->itemId) {
            $res['itemId'] = $this->itemId;
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
     * @return feedItem
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['durationMillis'])) {
            $model->durationMillis = $map['durationMillis'];
        }
        if (isset($map['feedContentType'])) {
            $model->feedContentType = $map['feedContentType'];
        }
        if (isset($map['itemId'])) {
            $model->itemId = $map['itemId'];
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
