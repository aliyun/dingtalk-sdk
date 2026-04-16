<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDeptScoreCardIndicatorRequest extends Model
{
    /**
     * @var string
     */
    public $dingTeamId;

    /**
     * @var int
     */
    public $selectedTime;
    protected $_name = [
        'dingTeamId' => 'dingTeamId',
        'selectedTime' => 'selectedTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingTeamId) {
            $res['dingTeamId'] = $this->dingTeamId;
        }
        if (null !== $this->selectedTime) {
            $res['selectedTime'] = $this->selectedTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDeptScoreCardIndicatorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingTeamId'])) {
            $model->dingTeamId = $map['dingTeamId'];
        }
        if (isset($map['selectedTime'])) {
            $model->selectedTime = $map['selectedTime'];
        }

        return $model;
    }
}
