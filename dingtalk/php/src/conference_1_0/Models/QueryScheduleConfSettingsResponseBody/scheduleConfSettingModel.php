<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConfSettingsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryScheduleConfSettingsResponseBody\scheduleConfSettingModel\moziConfVirtualExtraSetting;
use AlibabaCloud\Tea\Model;

class scheduleConfSettingModel extends Model
{
    /**
     * @var string[]
     */
    public $cohostUnionIds;

    /**
     * @var string
     */
    public $confAllowedCorpId;

    /**
     * @var string
     */
    public $hostUnionId;

    /**
     * @var int
     */
    public $lockRoom;

    /**
     * @var moziConfVirtualExtraSetting
     */
    public $moziConfVirtualExtraSetting;

    /**
     * @var int
     */
    public $muteOnJoin;

    /**
     * @var int
     */
    public $screenShareForbidden;
    protected $_name = [
        'cohostUnionIds' => 'cohostUnionIds',
        'confAllowedCorpId' => 'confAllowedCorpId',
        'hostUnionId' => 'hostUnionId',
        'lockRoom' => 'lockRoom',
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
