<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CategoryStatisticsRequest extends Model
{
    /**
     * @description 截止日期
     *
     * @var string
     */
    public $maxDt;

    /**
     * @description 起始日期
     *
     * @var string
     */
    public $minDt;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'maxDt'      => 'maxDt',
        'minDt'      => 'minDt',
        'openTeamId' => 'openTeamId',
    ];

    public function validate()
    {
    }

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
     * @return CategoryStatisticsRequest
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
