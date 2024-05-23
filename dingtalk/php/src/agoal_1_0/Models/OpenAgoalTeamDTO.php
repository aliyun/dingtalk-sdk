<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalTeamDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 8535683xx
     *
     * @var string
     */
    public $deptId;

    /**
     * @description This parameter is required.
     *
     * @example 测试部门
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $teamId;
    protected $_name = [
        'deptId' => 'deptId',
        'name'   => 'name',
        'teamId' => 'teamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalTeamDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }

        return $model;
    }
}
