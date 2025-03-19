<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCloudFeedRequest extends Model
{
    /**
     * @example https://img.alicdn.com/tfs/TB1A7cBtYr1gK0jSZR0XXbP8XXa-750-422.png
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @example 这是一场云导播课程
     *
     * @var string
     */
    public $intro;

    /**
     * @description This parameter is required.
     *
     * @example 1615260061000
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @example 课程一
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example 214675
     *
     * @var string
     */
    public $userId;

    /**
     * @description This parameter is required.
     *
     * @example http/https:/xxx.mp4
     *
     * @var string
     */
    public $videoUrl;
    protected $_name = [
        'coverUrl' => 'coverUrl',
        'intro' => 'intro',
        'startTime' => 'startTime',
        'title' => 'title',
        'userId' => 'userId',
        'videoUrl' => 'videoUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }
        if (null !== $this->intro) {
            $res['intro'] = $this->intro;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->videoUrl) {
            $res['videoUrl'] = $this->videoUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCloudFeedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['intro'])) {
            $model->intro = $map['intro'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['videoUrl'])) {
            $model->videoUrl = $map['videoUrl'];
        }

        return $model;
    }
}
