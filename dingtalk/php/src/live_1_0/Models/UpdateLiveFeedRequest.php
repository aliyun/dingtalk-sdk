<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateLiveFeedRequest extends Model
{
    /**
     * @example http:xxx.png
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @example 简介
     *
     * @var string
     */
    public $introduction;

    /**
     * @example 1617436058000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 标题
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example 1206186351746728
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'coverUrl' => 'coverUrl',
        'introduction' => 'introduction',
        'startTime' => 'startTime',
        'title' => 'title',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateLiveFeedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
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

        return $model;
    }
}
