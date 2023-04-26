<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListResponseBody\result\liveInfoPopModelList;

use AlibabaCloud\Tea\Model;

class liveBasicInfo extends Model
{
    /**
     * @var string
     */
    public $coverUrl;

    /**
     * @var int
     */
    public $duration;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $introduction;

    /**
     * @var string
     */
    public $liveId;

    /**
     * @var string
     */
    public $livePlayUrl;

    /**
     * @var int
     */
    public $liveStatus;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var int
     */
    public $subscribeCount;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var int
     */
    public $uv;
    protected $_name = [
        'coverUrl'       => 'coverUrl',
        'duration'       => 'duration',
        'endTime'        => 'endTime',
        'introduction'   => 'introduction',
        'liveId'         => 'liveId',
        'livePlayUrl'    => 'livePlayUrl',
        'liveStatus'     => 'liveStatus',
        'startTime'      => 'startTime',
        'subscribeCount' => 'subscribeCount',
        'title'          => 'title',
        'unionId'        => 'unionId',
        'uv'             => 'uv',
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
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
        }
        if (null !== $this->liveId) {
            $res['liveId'] = $this->liveId;
        }
        if (null !== $this->livePlayUrl) {
            $res['livePlayUrl'] = $this->livePlayUrl;
        }
        if (null !== $this->liveStatus) {
            $res['liveStatus'] = $this->liveStatus;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->subscribeCount) {
            $res['subscribeCount'] = $this->subscribeCount;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->uv) {
            $res['uv'] = $this->uv;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return liveBasicInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
        }
        if (isset($map['liveId'])) {
            $model->liveId = $map['liveId'];
        }
        if (isset($map['livePlayUrl'])) {
            $model->livePlayUrl = $map['livePlayUrl'];
        }
        if (isset($map['liveStatus'])) {
            $model->liveStatus = $map['liveStatus'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['subscribeCount'])) {
            $model->subscribeCount = $map['subscribeCount'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['uv'])) {
            $model->uv = $map['uv'];
        }

        return $model;
    }
}
