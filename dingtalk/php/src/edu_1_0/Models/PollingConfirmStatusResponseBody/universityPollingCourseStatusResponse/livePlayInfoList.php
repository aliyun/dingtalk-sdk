<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PollingConfirmStatusResponseBody\universityPollingCourseStatusResponse;

use AlibabaCloud\Tea\Model;

class livePlayInfoList extends Model
{
    /**
     * @description 推流地址
     *
     * @var string
     */
    public $liveInputUrl;

    /**
     * @description 直播拉流地址
     *
     * @var string
     */
    public $liveOutputUrl;

    /**
     * @description 视频流类型
     *
     * @var int
     */
    public $liveType;

    /**
     * @description 视频回放地址
     *
     * @var string
     */
    public $replayUrl;
    protected $_name = [
        'liveInputUrl'  => 'liveInputUrl',
        'liveOutputUrl' => 'liveOutputUrl',
        'liveType'      => 'liveType',
        'replayUrl'     => 'replayUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveInputUrl) {
            $res['liveInputUrl'] = $this->liveInputUrl;
        }
        if (null !== $this->liveOutputUrl) {
            $res['liveOutputUrl'] = $this->liveOutputUrl;
        }
        if (null !== $this->liveType) {
            $res['liveType'] = $this->liveType;
        }
        if (null !== $this->replayUrl) {
            $res['replayUrl'] = $this->replayUrl;
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
        if (isset($map['liveInputUrl'])) {
            $model->liveInputUrl = $map['liveInputUrl'];
        }
        if (isset($map['liveOutputUrl'])) {
            $model->liveOutputUrl = $map['liveOutputUrl'];
        }
        if (isset($map['liveType'])) {
            $model->liveType = $map['liveType'];
        }
        if (isset($map['replayUrl'])) {
            $model->replayUrl = $map['replayUrl'];
        }

        return $model;
    }
}
