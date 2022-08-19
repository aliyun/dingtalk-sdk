<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description 筛选直播截止时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 筛选直播开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 直播状态列表
     *
     * @var int[]
     */
    public $statuses;

    /**
     * @description 筛选的直播标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'endTime'   => 'endTime',
        'startTime' => 'startTime',
        'statuses'  => 'statuses',
        'title'     => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->statuses) {
            $res['statuses'] = $this->statuses;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
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
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['statuses'])) {
            if (!empty($map['statuses'])) {
                $model->statuses = $map['statuses'];
            }
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
