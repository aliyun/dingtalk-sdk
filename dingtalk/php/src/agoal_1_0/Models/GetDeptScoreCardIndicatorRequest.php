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
    protected $_name = [
        'dingTeamId' => 'dingTeamId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingTeamId) {
            $res['dingTeamId'] = $this->dingTeamId;
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

        return $model;
    }
}
