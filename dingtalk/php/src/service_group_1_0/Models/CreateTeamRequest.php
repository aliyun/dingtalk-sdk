<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTeamRequest extends Model
{
    /**
     * @description 团队管理员钉钉unionId
     *
     * @var string
     */
    public $creatorDingUnionId;

    /**
     * @description 团队名字
     *
     * @var string
     */
    public $teamName;
    protected $_name = [
        'creatorDingUnionId' => 'creatorDingUnionId',
        'teamName'           => 'teamName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorDingUnionId) {
            $res['creatorDingUnionId'] = $this->creatorDingUnionId;
        }
        if (null !== $this->teamName) {
            $res['teamName'] = $this->teamName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTeamRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorDingUnionId'])) {
            $model->creatorDingUnionId = $map['creatorDingUnionId'];
        }
        if (isset($map['teamName'])) {
            $model->teamName = $map['teamName'];
        }

        return $model;
    }
}
