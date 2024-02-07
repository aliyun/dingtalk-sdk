<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsRequest\scheduleConfSettingModel;

use AlibabaCloud\Tea\Model;

class moziConfVirtualExtraSetting extends Model
{
    /**
     * @example 0：未开启 1：开启
     *
     * @var int
     */
    public $enableChat;

    /**
     * @example 0：未开启 1：开启
     *
     * @var int
     */
    public $joinBeforeHost;

    /**
     * @example 0：未开启 1：开启
     *
     * @var int
     */
    public $lockMediaStatusMicMute;

    /**
     * @example 0：未开启 1：开启
     *
     * @var int
     */
    public $lockNick;

    /**
     * @example 0：未开启 1：开启
     *
     * @var int
     */
    public $waitingRoom;
    protected $_name = [
        'enableChat'             => 'enableChat',
        'joinBeforeHost'         => 'joinBeforeHost',
        'lockMediaStatusMicMute' => 'lockMediaStatusMicMute',
        'lockNick'               => 'lockNick',
        'waitingRoom'            => 'waitingRoom',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->enableChat) {
            $res['enableChat'] = $this->enableChat;
        }
        if (null !== $this->joinBeforeHost) {
            $res['joinBeforeHost'] = $this->joinBeforeHost;
        }
        if (null !== $this->lockMediaStatusMicMute) {
            $res['lockMediaStatusMicMute'] = $this->lockMediaStatusMicMute;
        }
        if (null !== $this->lockNick) {
            $res['lockNick'] = $this->lockNick;
        }
        if (null !== $this->waitingRoom) {
            $res['waitingRoom'] = $this->waitingRoom;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return moziConfVirtualExtraSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enableChat'])) {
            $model->enableChat = $map['enableChat'];
        }
        if (isset($map['joinBeforeHost'])) {
            $model->joinBeforeHost = $map['joinBeforeHost'];
        }
        if (isset($map['lockMediaStatusMicMute'])) {
            $model->lockMediaStatusMicMute = $map['lockMediaStatusMicMute'];
        }
        if (isset($map['lockNick'])) {
            $model->lockNick = $map['lockNick'];
        }
        if (isset($map['waitingRoom'])) {
            $model->waitingRoom = $map['waitingRoom'];
        }

        return $model;
    }
}
