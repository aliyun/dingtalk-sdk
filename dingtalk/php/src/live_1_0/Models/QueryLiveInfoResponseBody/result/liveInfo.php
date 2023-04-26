<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInfoResponseBody\result;

use AlibabaCloud\Tea\Model;

class liveInfo extends Model
{
    /**
     * @example https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @example 18450
     *
     * @var int
     */
    public $duration;

    /**
     * @example 1659653648000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 测试直播简介
     *
     * @var string
     */
    public $introduction;

    /**
     * @example 1a353547-040d-4095-bb93-404bc5d47920
     *
     * @var string
     */
    public $liveId;

    /**
     * @example https://h5.dingtalk.com/group-live-share/index.htm?type=2&liveFromType=6&liveUuid=1a353547-040d-4095-bb93-404bc5d47920&dd_nav_bgcolor=FF2C2D2F#/union
     *
     * @var string
     */
    public $livePlayUrl;

    /**
     * @example 3
     *
     * @var int
     */
    public $liveStatus;

    /**
     * @example 18430
     *
     * @var int
     */
    public $playbackDuration;

    /**
     * @example 1659613648000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 2
     *
     * @var int
     */
    public $subscribeCount;

    /**
     * @example 测试直播
     *
     * @var string
     */
    public $title;

    /**
     * @example DC7wZGOSueEEIGOf3WKwWgiEiE
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 3
     *
     * @var int
     */
    public $uv;
    protected $_name = [
        'coverUrl'         => 'coverUrl',
        'duration'         => 'duration',
        'endTime'          => 'endTime',
        'introduction'     => 'introduction',
        'liveId'           => 'liveId',
        'livePlayUrl'      => 'livePlayUrl',
        'liveStatus'       => 'liveStatus',
        'playbackDuration' => 'playbackDuration',
        'startTime'        => 'startTime',
        'subscribeCount'   => 'subscribeCount',
        'title'            => 'title',
        'unionId'          => 'unionId',
        'uv'               => 'uv',
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
        if (null !== $this->playbackDuration) {
            $res['playbackDuration'] = $this->playbackDuration;
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
     * @return liveInfo
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
        if (isset($map['playbackDuration'])) {
            $model->playbackDuration = $map['playbackDuration'];
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
