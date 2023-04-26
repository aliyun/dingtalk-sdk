<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\GetFeedResponseBody;

use AlibabaCloud\Tea\Model;

class feedItem extends Model
{
    /**
     * @example 9320
     *
     * @var int
     */
    public $durationMillis;

    /**
     * @example 0
     *
     * @var int
     */
    public $feedContentType;

    /**
     * @example 08****b5-2442-****-bd56-99cf****8861
     *
     * @var string
     */
    public $itemId;

    /**
     * @example 子内容标题
     *
     * @var string
     */
    public $title;

    /**
     * @example https://h5.dingtalk.com/live/video_lesson.htm?feedId=66****03-a825-****-9501-b1eeb****a8d&mcnId=1832**********06173&feedProperty=2&itemId=08****b5-2442-****-bd56-99c*****8861&dd_nav_bgcolor=FF2C2D2F#/video
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
