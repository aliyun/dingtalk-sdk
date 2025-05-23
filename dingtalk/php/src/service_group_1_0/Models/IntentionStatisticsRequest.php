<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class IntentionStatisticsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 20220101
     *
     * @var string
     */
    public $maxDt;

    /**
     * @description This parameter is required.
     *
     * @example 20220101
     *
     * @var string
     */
    public $minDt;

    /**
     * @description This parameter is required.
     *
     * @example KxisoOk
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'maxDt' => 'maxDt',
        'minDt' => 'minDt',
        'openTeamId' => 'openTeamId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxDt) {
            $res['maxDt'] = $this->maxDt;
        }
        if (null !== $this->minDt) {
            $res['minDt'] = $this->minDt;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IntentionStatisticsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxDt'])) {
            $model->maxDt = $map['maxDt'];
        }
        if (isset($map['minDt'])) {
            $model->minDt = $map['minDt'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
