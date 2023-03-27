<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetProjectMemebersRequest extends Model
{
    /**
     * @description 每页返回最大数量。默认10，最大300。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 项目角色ID，仅查询拥有该角色的成员，并且仅支持单个角色查询。
     *
     * @var string
     */
    public $projectRoleId;

    /**
     * @description 跳过的数据数量。
     *
     * @var int
     */
    public $skip;

    /**
     * @description 如果传递，仅查询这些用户ID， 用逗号组合。
     *
     * @var string
     */
    public $userIds;
    protected $_name = [
        'maxResults'    => 'maxResults',
        'projectRoleId' => 'projectRoleId',
        'skip'          => 'skip',
        'userIds'       => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->projectRoleId) {
            $res['projectRoleId'] = $this->projectRoleId;
        }
        if (null !== $this->skip) {
            $res['skip'] = $this->skip;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProjectMemebersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['projectRoleId'])) {
            $model->projectRoleId = $map['projectRoleId'];
        }
        if (isset($map['skip'])) {
            $model->skip = $map['skip'];
        }
        if (isset($map['userIds'])) {
            $model->userIds = $map['userIds'];
        }

        return $model;
    }
}
