<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateLiveFeedRequest extends Model
{
    /**
     * @description 封面图url
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @description 课程简介
     *
     * @var string
     */
    public $introduction;

    /**
     * @description 预计开始时间（毫秒值）（课程必须预告状态才可以修改该项）
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
     * @description 操作者id（修改者的组织内id）
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'coverUrl'     => 'coverUrl',
        'introduction' => 'introduction',
        'startTime'    => 'startTime',
        'title'        => 'title',
        'userId'       => 'userId',
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
