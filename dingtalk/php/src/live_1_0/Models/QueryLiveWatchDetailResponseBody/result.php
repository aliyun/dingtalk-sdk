<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchDetailResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 平均观看时长
     *
     * @var int
     */
    public $avgWatchTime;

    /**
     * @description 观看直播人数
     *
     * @var int
     */
    public $liveUv;

    /**
     * @description 消息数
     *
     * @var int
     */
    public $msgCount;

    /**
     * @description 观看回放人数
     *
     * @var int
     */
    public $playbackUv;

    /**
     * @description 点赞数
     *
     * @var int
     */
    public $praiseCount;

    /**
     * @description 观看次数
     *
     * @var int
     */
    public $pv;

    /**
     * @description 观看总时长
     *
     * @var int
     */
    public $totalWatchTime;

    /**
     * @description 观看人数
     *
     * @var int
     */
    public $uv;
    protected $_name = [
        'avgWatchTime'   => 'avgWatchTime',
        'liveUv'         => 'liveUv',
        'msgCount'       => 'msgCount',
        'playbackUv'     => 'playbackUv',
        'praiseCount'    => 'praiseCount',
        'pv'             => 'pv',
        'totalWatchTime' => 'totalWatchTime',
        'uv'             => 'uv',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avgWatchTime) {
            $res['avgWatchTime'] = $this->avgWatchTime;
        }
        if (null !== $this->liveUv) {
            $res['liveUv'] = $this->liveUv;
        }
        if (null !== $this->msgCount) {
            $res['msgCount'] = $this->msgCount;
        }
        if (null !== $this->playbackUv) {
            $res['playbackUv'] = $this->playbackUv;
        }
        if (null !== $this->praiseCount) {
            $res['praiseCount'] = $this->praiseCount;
        }
        if (null !== $this->pv) {
            $res['pv'] = $this->pv;
        }
        if (null !== $this->totalWatchTime) {
            $res['totalWatchTime'] = $this->totalWatchTime;
        }
        if (null !== $this->uv) {
            $res['uv'] = $this->uv;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avgWatchTime'])) {
            $model->avgWatchTime = $map['avgWatchTime'];
        }
        if (isset($map['liveUv'])) {
            $model->liveUv = $map['liveUv'];
        }
        if (isset($map['msgCount'])) {
            $model->msgCount = $map['msgCount'];
        }
        if (isset($map['playbackUv'])) {
            $model->playbackUv = $map['playbackUv'];
        }
        if (isset($map['praiseCount'])) {
            $model->praiseCount = $map['praiseCount'];
        }
        if (isset($map['pv'])) {
            $model->pv = $map['pv'];
        }
        if (isset($map['totalWatchTime'])) {
            $model->totalWatchTime = $map['totalWatchTime'];
        }
        if (isset($map['uv'])) {
            $model->uv = $map['uv'];
        }

        return $model;
    }
}
