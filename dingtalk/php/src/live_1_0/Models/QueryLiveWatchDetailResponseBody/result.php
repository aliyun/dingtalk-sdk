<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchDetailResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 3560
     *
     * @var int
     */
    public $avgWatchTime;

    /**
     * @example 55
     *
     * @var int
     */
    public $liveUv;

    /**
     * @example 252
     *
     * @var int
     */
    public $msgCount;

    /**
     * @example 72
     *
     * @var int
     */
    public $playbackUv;

    /**
     * @example 500
     *
     * @var int
     */
    public $praiseCount;

    /**
     * @example 120
     *
     * @var int
     */
    public $pv;

    /**
     * @example 1903640
     *
     * @var int
     */
    public $totalWatchTime;

    /**
     * @example 90
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
