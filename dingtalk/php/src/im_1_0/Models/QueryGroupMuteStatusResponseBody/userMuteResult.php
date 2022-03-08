<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryGroupMuteStatusResponseBody;

use AlibabaCloud\Tea\Model;

class userMuteResult extends Model
{
    /**
     * @description 禁言结束时间
     *
     * @var int
     */
    public $muteEndTime;

    /**
     * @description 禁言开始时间
     *
     * @var int
     */
    public $muteStartTime;

    /**
     * @description 成员禁言状态
     *
     * @var bool
     */
    public $userMuteMode;
    protected $_name = [
        'muteEndTime'   => 'muteEndTime',
        'muteStartTime' => 'muteStartTime',
        'userMuteMode'  => 'userMuteMode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->muteEndTime) {
            $res['muteEndTime'] = $this->muteEndTime;
        }
        if (null !== $this->muteStartTime) {
            $res['muteStartTime'] = $this->muteStartTime;
        }
        if (null !== $this->userMuteMode) {
            $res['userMuteMode'] = $this->userMuteMode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userMuteResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['muteEndTime'])) {
            $model->muteEndTime = $map['muteEndTime'];
        }
        if (isset($map['muteStartTime'])) {
            $model->muteStartTime = $map['muteStartTime'];
        }
        if (isset($map['userMuteMode'])) {
            $model->userMuteMode = $map['userMuteMode'];
        }

        return $model;
    }
}
