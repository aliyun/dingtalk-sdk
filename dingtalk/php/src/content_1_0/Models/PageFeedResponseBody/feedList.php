<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\PageFeedResponseBody;

use AlibabaCloud\Tea\Model;

class feedList extends Model
{
    /**
     * @example 200000257
     *
     * @var string
     */
    public $feedCategory;

    /**
     * @example 3d******-1cd2-****-ba1d-8******3c6dc
     *
     * @var string
     */
    public $feedId;

    /**
     * @example 4
     *
     * @var int
     */
    public $feedType;

    /**
     * @example 名称
     *
     * @var string
     */
    public $name;

    /**
     * @example https://static.dingtalk.com/media/**************NAlg_600_337.jpg
     *
     * @var string
     */
    public $thumbUrl;

    /**
     * @example https://h5.dingtalk.com/live/video_lesson.htm?spm=a1zdd.*******.0.0.3e9617129vSDL8&feedId=5e*****-17ec-45f1-8cc0-e******4a3&mcnId=183206*******06173&feedProperty=1&itemId=5ef7*****-17ec-45f1-8cc0-e64*****954a3&dd_nav_bgcolor=FF2****F#/video
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'feedCategory' => 'feedCategory',
        'feedId'       => 'feedId',
        'feedType'     => 'feedType',
        'name'         => 'name',
        'thumbUrl'     => 'thumbUrl',
        'url'          => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->feedCategory) {
            $res['feedCategory'] = $this->feedCategory;
        }
        if (null !== $this->feedId) {
            $res['feedId'] = $this->feedId;
        }
        if (null !== $this->feedType) {
            $res['feedType'] = $this->feedType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->thumbUrl) {
            $res['thumbUrl'] = $this->thumbUrl;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return feedList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['feedCategory'])) {
            $model->feedCategory = $map['feedCategory'];
        }
        if (isset($map['feedId'])) {
            $model->feedId = $map['feedId'];
        }
        if (isset($map['feedType'])) {
            $model->feedType = $map['feedType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['thumbUrl'])) {
            $model->thumbUrl = $map['thumbUrl'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
