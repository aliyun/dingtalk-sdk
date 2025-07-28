<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskRequest;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskRequest\sendConfig\urlTrackConfig;
use AlibabaCloud\Tea\Model;

class sendConfig extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $needUrlTrack;

    /**
     * @example 2023-06-01 00:00:00
     *
     * @var string
     */
    public $sendTime;

    /**
     * @description This parameter is required.
     *
     * @example INSTANT
     *
     * @var string
     */
    public $sendType;

    /**
     * @var urlTrackConfig[]
     */
    public $urlTrackConfig;
    protected $_name = [
        'needUrlTrack' => 'needUrlTrack',
        'sendTime' => 'sendTime',
        'sendType' => 'sendType',
        'urlTrackConfig' => 'urlTrackConfig',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->needUrlTrack) {
            $res['needUrlTrack'] = $this->needUrlTrack;
        }
        if (null !== $this->sendTime) {
            $res['sendTime'] = $this->sendTime;
        }
        if (null !== $this->sendType) {
            $res['sendType'] = $this->sendType;
        }
        if (null !== $this->urlTrackConfig) {
            $res['urlTrackConfig'] = [];
            if (null !== $this->urlTrackConfig && \is_array($this->urlTrackConfig)) {
                $n = 0;
                foreach ($this->urlTrackConfig as $item) {
                    $res['urlTrackConfig'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sendConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['needUrlTrack'])) {
            $model->needUrlTrack = $map['needUrlTrack'];
        }
        if (isset($map['sendTime'])) {
            $model->sendTime = $map['sendTime'];
        }
        if (isset($map['sendType'])) {
            $model->sendType = $map['sendType'];
        }
        if (isset($map['urlTrackConfig'])) {
            if (!empty($map['urlTrackConfig'])) {
                $model->urlTrackConfig = [];
                $n = 0;
                foreach ($map['urlTrackConfig'] as $item) {
                    $model->urlTrackConfig[$n++] = null !== $item ? urlTrackConfig::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
