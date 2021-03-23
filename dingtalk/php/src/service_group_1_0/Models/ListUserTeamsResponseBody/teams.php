<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ListUserTeamsResponseBody;

use AlibabaCloud\Tea\Model;

class teams extends Model
{
    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 团队名称
     *
     * @var string
     */
    public $teamName;
    protected $_name = [
        'openTeamId' => 'openTeamId',
        'teamName'   => 'teamName',
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
        if (null !== $this->teamName) {
            $res['teamName'] = $this->teamName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return teams
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['teamName'])) {
            $model->teamName = $map['teamName'];
        }

        return $model;
    }
}
