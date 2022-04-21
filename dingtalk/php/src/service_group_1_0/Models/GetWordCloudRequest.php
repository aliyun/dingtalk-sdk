<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetWordCloudRequest extends Model
{
    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'openTeamId' => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetWordCloudRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
