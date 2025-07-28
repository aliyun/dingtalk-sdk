<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateVideoConferenceSettingRequest extends Model
{
    /**
     * @var bool
     */
    public $allowUnmuteSelf;

    /**
     * @var bool
     */
    public $autoTransferHost;

    /**
     * @var bool
     */
    public $forbiddenShareScreen;

    /**
     * @var bool
     */
    public $lockConference;

    /**
     * @var bool
     */
    public $muteAll;

    /**
     * @var bool
     */
    public $onlyInternalEmployeesJoin;
    protected $_name = [
        'allowUnmuteSelf' => 'allowUnmuteSelf',
        'autoTransferHost' => 'autoTransferHost',
        'forbiddenShareScreen' => 'forbiddenShareScreen',
        'lockConference' => 'lockConference',
        'muteAll' => 'muteAll',
        'onlyInternalEmployeesJoin' => 'onlyInternalEmployeesJoin',
    ];

    public function validate() {}

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
