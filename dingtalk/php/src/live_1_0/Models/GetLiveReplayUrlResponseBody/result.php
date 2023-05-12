<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetLiveReplayUrlResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example http://xxx.dingtalk.com/live_hp/7c7ba32a-c92d-4524-b71e-33a72575c5a9_normal.m3u8?auth_key=xxx
     *
     * @var string
     */
    public $replayUrl;
    protected $_name = [
        'replayUrl' => 'replayUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->replayUrl) {
            $res['replayUrl'] = $this->replayUrl;
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
        if (isset($map['replayUrl'])) {
            $model->replayUrl = $map['replayUrl'];
        }

        return $model;
    }
}
