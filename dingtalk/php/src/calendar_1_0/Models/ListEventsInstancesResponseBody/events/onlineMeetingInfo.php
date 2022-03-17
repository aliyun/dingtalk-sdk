<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListEventsInstancesResponseBody\events;

use AlibabaCloud\Tea\Model;

class onlineMeetingInfo extends Model
{
    /**
     * @description 会议ID
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @description 线上会议类型，目前支持：  dingtalk：钉钉视频会议
     *
     * @var string
     */
    public $type;

    /**
     * @description 会议url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'conferenceId' => 'conferenceId',
        'type'         => 'type',
        'url'          => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return onlineMeetingInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
