<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateVideoConferenceSettingRequest extends Model
{
    /**
     * @description 允许参会人员取消静音
     *
     * @var bool
     */
    public $allowUnmuteSelf;

    /**
     * @description 主持人离会，是否自动转移主持人角色
     *
     * @var bool
     */
    public $autoTransferHost;

    /**
     * @description 禁止共享屏幕
     *
     * @var bool
     */
    public $forbiddenShareScreen;

    /**
     * @description 锁定会议，禁止邀请入会
     *
     * @var bool
     */
    public $lockConference;

    /**
     * @description 全员静音
     *
     * @var bool
     */
    public $muteAll;

    /**
     * @description 仅允许企业内员工加入会议
     *
     * @var bool
     */
    public $onlyInternalEmployeesJoin;
    protected $_name = [
        'allowUnmuteSelf'           => 'allowUnmuteSelf',
        'autoTransferHost'          => 'autoTransferHost',
        'forbiddenShareScreen'      => 'forbiddenShareScreen',
        'lockConference'            => 'lockConference',
        'muteAll'                   => 'muteAll',
        'onlyInternalEmployeesJoin' => 'onlyInternalEmployeesJoin',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->allowUnmuteSelf) {
            $res['allowUnmuteSelf'] = $this->allowUnmuteSelf;
        }
        if (null !== $this->autoTransferHost) {
            $res['autoTransferHost'] = $this->autoTransferHost;
        }
        if (null !== $this->forbiddenShareScreen) {
            $res['forbiddenShareScreen'] = $this->forbiddenShareScreen;
        }
        if (null !== $this->lockConference) {
            $res['lockConference'] = $this->lockConference;
        }
        if (null !== $this->muteAll) {
            $res['muteAll'] = $this->muteAll;
        }
        if (null !== $this->onlyInternalEmployeesJoin) {
            $res['onlyInternalEmployeesJoin'] = $this->onlyInternalEmployeesJoin;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateVideoConferenceSettingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allowUnmuteSelf'])) {
            $model->allowUnmuteSelf = $map['allowUnmuteSelf'];
        }
        if (isset($map['autoTransferHost'])) {
            $model->autoTransferHost = $map['autoTransferHost'];
        }
        if (isset($map['forbiddenShareScreen'])) {
            $model->forbiddenShareScreen = $map['forbiddenShareScreen'];
        }
        if (isset($map['lockConference'])) {
            $model->lockConference = $map['lockConference'];
        }
        if (isset($map['muteAll'])) {
            $model->muteAll = $map['muteAll'];
        }
        if (isset($map['onlyInternalEmployeesJoin'])) {
            $model->onlyInternalEmployeesJoin = $map['onlyInternalEmployeesJoin'];
        }

        return $model;
    }
}
