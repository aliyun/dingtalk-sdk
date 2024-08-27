<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\UploadVideosRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $authorIconUrl;

    /**
     * @var string
     */
    public $authorId;

    /**
     * @var string
     */
    public $authorName;

    /**
     * @var string
     */
    public $coverUrl;

    /**
     * @var string
     */
    public $jumpIconUrl;

    /**
     * @var string
     */
    public $jumpTitle;

    /**
     * @var string
     */
    public $jumpUrl;

    /**
     * @var string
     */
    public $videoDuration;

    /**
     * @var string
     */
    public $videoHeight;

    /**
     * @var string
     */
    public $videoId;

    /**
     * @var string
     */
    public $videoTitle;

    /**
     * @var string
     */
    public $videoWidth;

    /**
     * @var string
     */
    public $webpUrl;
    protected $_name = [
        'authorIconUrl' => 'authorIconUrl',
        'authorId'      => 'authorId',
        'authorName'    => 'authorName',
        'coverUrl'      => 'coverUrl',
        'jumpIconUrl'   => 'jumpIconUrl',
        'jumpTitle'     => 'jumpTitle',
        'jumpUrl'       => 'jumpUrl',
        'videoDuration' => 'videoDuration',
        'videoHeight'   => 'videoHeight',
        'videoId'       => 'videoId',
        'videoTitle'    => 'videoTitle',
        'videoWidth'    => 'videoWidth',
        'webpUrl'       => 'webpUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authorIconUrl) {
            $res['authorIconUrl'] = $this->authorIconUrl;
        }
        if (null !== $this->authorId) {
            $res['authorId'] = $this->authorId;
        }
        if (null !== $this->authorName) {
            $res['authorName'] = $this->authorName;
        }
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }
        if (null !== $this->jumpIconUrl) {
            $res['jumpIconUrl'] = $this->jumpIconUrl;
        }
        if (null !== $this->jumpTitle) {
            $res['jumpTitle'] = $this->jumpTitle;
        }
        if (null !== $this->jumpUrl) {
            $res['jumpUrl'] = $this->jumpUrl;
        }
        if (null !== $this->videoDuration) {
            $res['videoDuration'] = $this->videoDuration;
        }
        if (null !== $this->videoHeight) {
            $res['videoHeight'] = $this->videoHeight;
        }
        if (null !== $this->videoId) {
            $res['videoId'] = $this->videoId;
        }
        if (null !== $this->videoTitle) {
            $res['videoTitle'] = $this->videoTitle;
        }
        if (null !== $this->videoWidth) {
            $res['videoWidth'] = $this->videoWidth;
        }
        if (null !== $this->webpUrl) {
            $res['webpUrl'] = $this->webpUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authorIconUrl'])) {
            $model->authorIconUrl = $map['authorIconUrl'];
        }
        if (isset($map['authorId'])) {
            $model->authorId = $map['authorId'];
        }
        if (isset($map['authorName'])) {
            $model->authorName = $map['authorName'];
        }
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['jumpIconUrl'])) {
            $model->jumpIconUrl = $map['jumpIconUrl'];
        }
        if (isset($map['jumpTitle'])) {
            $model->jumpTitle = $map['jumpTitle'];
        }
        if (isset($map['jumpUrl'])) {
            $model->jumpUrl = $map['jumpUrl'];
        }
        if (isset($map['videoDuration'])) {
            $model->videoDuration = $map['videoDuration'];
        }
        if (isset($map['videoHeight'])) {
            $model->videoHeight = $map['videoHeight'];
        }
        if (isset($map['videoId'])) {
            $model->videoId = $map['videoId'];
        }
        if (isset($map['videoTitle'])) {
            $model->videoTitle = $map['videoTitle'];
        }
        if (isset($map['videoWidth'])) {
            $model->videoWidth = $map['videoWidth'];
        }
        if (isset($map['webpUrl'])) {
            $model->webpUrl = $map['webpUrl'];
        }

        return $model;
    }
}
