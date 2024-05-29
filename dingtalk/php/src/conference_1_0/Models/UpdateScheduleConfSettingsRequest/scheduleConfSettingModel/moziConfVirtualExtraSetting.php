<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsRequest\scheduleConfSettingModel;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsRequest\scheduleConfSettingModel\moziConfVirtualExtraSetting\moziConfExtensionAppSettings;
use AlibabaCloud\Tea\Model;

class moziConfVirtualExtraSetting extends Model
{
    /**
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $cloudRecordOwnerUnionId;

    /**
     * @example 0：未开启 1：开启
     *
     * @var int
     */
    public $enableChat;

    /**
     * @example true：允许匿名登录入会 false：不允许匿名登录入会
     *
     * @var bool
     */
    public $enableWebAnonymousJoin;

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
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $minutesOwnerUnionId;

    /**
     * @var moziConfExtensionAppSettings[]
     */
    public $moziConfExtensionAppSettings;

    /**
     * @var bool
     */
    public $pushAllMeetingRecords;

    /**
     * @var bool
     */
    public $pushCloudRecordCard;

    /**
     * @var bool
     */
    public $pushMinutesCard;

    /**
     * @example 0：未开启 1：开启
     *
     * @var int
     */
    public $waitingRoom;
    protected $_name = [
        'cloudRecordOwnerUnionId'      => 'cloudRecordOwnerUnionId',
        'enableChat'                   => 'enableChat',
        'enableWebAnonymousJoin'       => 'enableWebAnonymousJoin',
        'joinBeforeHost'               => 'joinBeforeHost',
        'lockMediaStatusMicMute'       => 'lockMediaStatusMicMute',
        'lockNick'                     => 'lockNick',
        'minutesOwnerUnionId'          => 'minutesOwnerUnionId',
        'moziConfExtensionAppSettings' => 'moziConfExtensionAppSettings',
        'pushAllMeetingRecords'        => 'pushAllMeetingRecords',
        'pushCloudRecordCard'          => 'pushCloudRecordCard',
        'pushMinutesCard'              => 'pushMinutesCard',
        'waitingRoom'                  => 'waitingRoom',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cloudRecordOwnerUnionId) {
            $res['cloudRecordOwnerUnionId'] = $this->cloudRecordOwnerUnionId;
        }
        if (null !== $this->enableChat) {
            $res['enableChat'] = $this->enableChat;
        }
        if (null !== $this->enableWebAnonymousJoin) {
            $res['enableWebAnonymousJoin'] = $this->enableWebAnonymousJoin;
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
        if (null !== $this->minutesOwnerUnionId) {
            $res['minutesOwnerUnionId'] = $this->minutesOwnerUnionId;
        }
        if (null !== $this->moziConfExtensionAppSettings) {
            $res['moziConfExtensionAppSettings'] = [];
            if (null !== $this->moziConfExtensionAppSettings && \is_array($this->moziConfExtensionAppSettings)) {
                $n = 0;
                foreach ($this->moziConfExtensionAppSettings as $item) {
                    $res['moziConfExtensionAppSettings'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->pushAllMeetingRecords) {
            $res['pushAllMeetingRecords'] = $this->pushAllMeetingRecords;
        }
        if (null !== $this->pushCloudRecordCard) {
            $res['pushCloudRecordCard'] = $this->pushCloudRecordCard;
        }
        if (null !== $this->pushMinutesCard) {
            $res['pushMinutesCard'] = $this->pushMinutesCard;
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
        if (isset($map['cloudRecordOwnerUnionId'])) {
            $model->cloudRecordOwnerUnionId = $map['cloudRecordOwnerUnionId'];
        }
        if (isset($map['enableChat'])) {
            $model->enableChat = $map['enableChat'];
        }
        if (isset($map['enableWebAnonymousJoin'])) {
            $model->enableWebAnonymousJoin = $map['enableWebAnonymousJoin'];
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
        if (isset($map['minutesOwnerUnionId'])) {
            $model->minutesOwnerUnionId = $map['minutesOwnerUnionId'];
        }
        if (isset($map['moziConfExtensionAppSettings'])) {
            if (!empty($map['moziConfExtensionAppSettings'])) {
                $model->moziConfExtensionAppSettings = [];
                $n                                   = 0;
                foreach ($map['moziConfExtensionAppSettings'] as $item) {
                    $model->moziConfExtensionAppSettings[$n++] = null !== $item ? moziConfExtensionAppSettings::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['pushAllMeetingRecords'])) {
            $model->pushAllMeetingRecords = $map['pushAllMeetingRecords'];
        }
        if (isset($map['pushCloudRecordCard'])) {
            $model->pushCloudRecordCard = $map['pushCloudRecordCard'];
        }
        if (isset($map['pushMinutesCard'])) {
            $model->pushMinutesCard = $map['pushMinutesCard'];
        }
        if (isset($map['waitingRoom'])) {
            $model->waitingRoom = $map['waitingRoom'];
        }

        return $model;
    }
}
