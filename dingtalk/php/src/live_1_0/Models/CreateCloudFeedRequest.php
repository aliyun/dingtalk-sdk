<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCloudFeedRequest extends Model
{
    /**
     * @description 课程封面Url
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @description 课程简介
     *
     * @var string
     */
    public $intro;

    /**
     * @description 预计开始的时间戳(未来的时间点)
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 课程标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 创建课程的主播id（staffId）
     *
     * @var string
     */
    public $userId;

    /**
     * @description 云导播课程资源的url
     *
     * @var string
     */
    public $videoUrl;
    protected $_name = [
        'coverUrl'  => 'coverUrl',
        'intro'     => 'intro',
        'startTime' => 'startTime',
        'title'     => 'title',
        'userId'    => 'userId',
        'videoUrl'  => 'videoUrl',
    ];

    public function validate()
    {
    }

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
