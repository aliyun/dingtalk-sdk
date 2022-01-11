<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EndCourseRequest;

use AlibabaCloud\Tea\Model;

class livePlayInfoList extends Model
{
    /**
     * @description Hls直播拉流地址
     *
     * @var string
     */
    public $liveOutputHlsUrl;

    /**
     * @description 直播流类型
     *
     * @var int
     */
    public $liveType;

    /**
     * @description 直播推流地址
     *
     * @var string
     */
    public $liveInputUrl;

    /**
     * @description 回放视频地址
     *
     * @var string
     */
    public $replayUrl;

    /**
     * @description Flv直播拉回地址
     *
     * @var string
     */
    public $liveOutputFlvUrl;
    protected $_name = [
        'liveOutputHlsUrl' => 'liveOutputHlsUrl',
        'liveType'         => 'liveType',
        'liveInputUrl'     => 'liveInputUrl',
        'replayUrl'        => 'replayUrl',
        'liveOutputFlvUrl' => 'liveOutputFlvUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveOutputHlsUrl) {
            $res['liveOutputHlsUrl'] = $this->liveOutputHlsUrl;
        }
        if (null !== $this->liveType) {
            $res['liveType'] = $this->liveType;
        }
        if (null !== $this->liveInputUrl) {
            $res['liveInputUrl'] = $this->liveInputUrl;
        }
        if (null !== $this->replayUrl) {
            $res['replayUrl'] = $this->replayUrl;
        }
        if (null !== $this->liveOutputFlvUrl) {
            $res['liveOutputFlvUrl'] = $this->liveOutputFlvUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return livePlayInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['liveOutputHlsUrl'])) {
            $model->liveOutputHlsUrl = $map['liveOutputHlsUrl'];
        }
        if (isset($map['liveType'])) {
            $model->liveType = $map['liveType'];
        }
        if (isset($map['liveInputUrl'])) {
            $model->liveInputUrl = $map['liveInputUrl'];
        }
        if (isset($map['replayUrl'])) {
            $model->replayUrl = $map['replayUrl'];
        }
        if (isset($map['liveOutputFlvUrl'])) {
            $model->liveOutputFlvUrl = $map['liveOutputFlvUrl'];
        }

        return $model;
    }
}
