<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\UpdateScheduleConfSettingsRequest\scheduleConfSettingModel;

use AlibabaCloud\Tea\Model;

class moziConfOpenRecordSetting extends Model
{
    /**
     * @example true：跟随 false：不跟随
     *
     * @var bool
     */
    public $isFollowHost;

    /**
     * @example grid：宫格模式,默认9宫格(3x3) speech：演讲者模式 full_screen：全屏模式 auto_grid：自动宫格模式，默认最大4x4宫格 screen_cast：屏幕共享模式，仅放置屏幕共享流 p2p：双人通话模式 full_screen_and_speaker：共享内容+发言人模式
     *
     * @var string
     */
    public $mode;

    /**
     * @example 0：不自动开启 1：自动开启
     *
     * @var int
     */
    public $recordAutoStart;

    /**
     * @example 0：我以主持人身份入会后自动开启 1：其他人以联席主持人身份入会后开启 2：任何人以任何身份入会后开启
     *
     * @var int
     */
    public $recordAutoStartType;
    protected $_name = [
        'isFollowHost'        => 'isFollowHost',
        'mode'                => 'mode',
        'recordAutoStart'     => 'recordAutoStart',
        'recordAutoStartType' => 'recordAutoStartType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isFollowHost) {
            $res['isFollowHost'] = $this->isFollowHost;
        }
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }
        if (null !== $this->recordAutoStart) {
            $res['recordAutoStart'] = $this->recordAutoStart;
        }
        if (null !== $this->recordAutoStartType) {
            $res['recordAutoStartType'] = $this->recordAutoStartType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return moziConfOpenRecordSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isFollowHost'])) {
            $model->isFollowHost = $map['isFollowHost'];
        }
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }
        if (isset($map['recordAutoStart'])) {
            $model->recordAutoStart = $map['recordAutoStart'];
        }
        if (isset($map['recordAutoStartType'])) {
            $model->recordAutoStartType = $map['recordAutoStartType'];
        }

        return $model;
    }
}
