<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateScheduleConferenceRequest;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateScheduleConferenceRequest\scheduleConfSettingModel\moziConfOpenRecordSetting;
use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateScheduleConferenceRequest\scheduleConfSettingModel\moziConfVirtualExtraSetting;
use AlibabaCloud\Tea\Model;

class scheduleConfSettingModel extends Model
{
    /**
     * @var string[]
     */
    public $cohostUnionIds;

    /**
     * @example dingc02f685fa06381c44ac5d6980864d335
     *
     * @var string
     */
    public $confAllowedCorpId;

    /**
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $hostUnionId;

    /**
     * @example 0：取消锁定 1：锁定
     *
     * @var int
     */
    public $lockRoom;

    /**
     * @var moziConfOpenRecordSetting
     */
    public $moziConfOpenRecordSetting;

    /**
     * @var moziConfVirtualExtraSetting
     */
    public $moziConfVirtualExtraSetting;

    /**
     * @example -1：开启 0：未开启 6：超过6人自动开启静音
     *
     * @var int
     */
    public $muteOnJoin;

    /**
     * @example 0：允许共享 1：禁止共享
     *
     * @var int
     */
    public $screenShareForbidden;
    protected $_name = [
        'cohostUnionIds' => 'cohostUnionIds',
        'confAllowedCorpId' => 'confAllowedCorpId',
        'hostUnionId' => 'hostUnionId',
        'lockRoom' => 'lockRoom',
        'moziConfOpenRecordSetting' => 'moziConfOpenRecordSetting',
        'moziConfVirtualExtraSetting' => 'moziConfVirtualExtraSetting',
        'muteOnJoin' => 'muteOnJoin',
        'screenShareForbidden' => 'screenShareForbidden',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cohostUnionIds) {
            $res['cohostUnionIds'] = $this->cohostUnionIds;
        }
        if (null !== $this->confAllowedCorpId) {
            $res['confAllowedCorpId'] = $this->confAllowedCorpId;
        }
        if (null !== $this->hostUnionId) {
            $res['hostUnionId'] = $this->hostUnionId;
        }
        if (null !== $this->lockRoom) {
            $res['lockRoom'] = $this->lockRoom;
        }
        if (null !== $this->moziConfOpenRecordSetting) {
            $res['moziConfOpenRecordSetting'] = null !== $this->moziConfOpenRecordSetting ? $this->moziConfOpenRecordSetting->toMap() : null;
        }
        if (null !== $this->moziConfVirtualExtraSetting) {
            $res['moziConfVirtualExtraSetting'] = null !== $this->moziConfVirtualExtraSetting ? $this->moziConfVirtualExtraSetting->toMap() : null;
        }
        if (null !== $this->muteOnJoin) {
            $res['muteOnJoin'] = $this->muteOnJoin;
        }
        if (null !== $this->screenShareForbidden) {
            $res['screenShareForbidden'] = $this->screenShareForbidden;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return scheduleConfSettingModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cohostUnionIds'])) {
            if (!empty($map['cohostUnionIds'])) {
                $model->cohostUnionIds = $map['cohostUnionIds'];
            }
        }
        if (isset($map['confAllowedCorpId'])) {
            $model->confAllowedCorpId = $map['confAllowedCorpId'];
        }
        if (isset($map['hostUnionId'])) {
            $model->hostUnionId = $map['hostUnionId'];
        }
        if (isset($map['lockRoom'])) {
            $model->lockRoom = $map['lockRoom'];
        }
        if (isset($map['moziConfOpenRecordSetting'])) {
            $model->moziConfOpenRecordSetting = moziConfOpenRecordSetting::fromMap($map['moziConfOpenRecordSetting']);
        }
        if (isset($map['moziConfVirtualExtraSetting'])) {
            $model->moziConfVirtualExtraSetting = moziConfVirtualExtraSetting::fromMap($map['moziConfVirtualExtraSetting']);
        }
        if (isset($map['muteOnJoin'])) {
            $model->muteOnJoin = $map['muteOnJoin'];
        }
        if (isset($map['screenShareForbidden'])) {
            $model->screenShareForbidden = $map['screenShareForbidden'];
        }

        return $model;
    }
}
