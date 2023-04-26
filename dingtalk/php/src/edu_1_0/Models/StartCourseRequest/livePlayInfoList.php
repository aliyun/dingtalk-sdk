<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\StartCourseRequest;

use AlibabaCloud\Tea\Model;

class livePlayInfoList extends Model
{
    /**
     * @example testUrl
     *
     * @var string
     */
    public $liveInputUrl;

    /**
     * @example testUrl
     *
     * @var string
     */
    public $liveOutputFlvUrl;

    /**
     * @example testUrl
     *
     * @var string
     */
    public $liveOutputHlsUrl;

    /**
     * @example 1
     *
     * @var int
     */
    public $liveType;

    /**
     * @example testUrl
     *
     * @var string
     */
    public $replayUrl;
    protected $_name = [
        'liveInputUrl'     => 'liveInputUrl',
        'liveOutputFlvUrl' => 'liveOutputFlvUrl',
        'liveOutputHlsUrl' => 'liveOutputHlsUrl',
        'liveType'         => 'liveType',
        'replayUrl'        => 'replayUrl',
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
        if (null !== $this->liveOutputFlvUrl) {
            $res['liveOutputFlvUrl'] = $this->liveOutputFlvUrl;
        }
        if (null !== $this->liveOutputHlsUrl) {
            $res['liveOutputHlsUrl'] = $this->liveOutputHlsUrl;
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
        if (isset($map['liveOutputFlvUrl'])) {
            $model->liveOutputFlvUrl = $map['liveOutputFlvUrl'];
        }
        if (isset($map['liveOutputHlsUrl'])) {
            $model->liveOutputHlsUrl = $map['liveOutputHlsUrl'];
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
