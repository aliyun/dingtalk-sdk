<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetProjectMemebersRequest extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $projectRoleId;

    /**
     * @example 55
     *
     * @var int
     */
    public $skip;

    /**
     * @example 60a2187eb72xxxxxxx,60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $userIds;
    protected $_name = [
        'maxResults' => 'maxResults',
        'projectRoleId' => 'projectRoleId',
        'skip' => 'skip',
        'userIds' => 'userIds',
    ];

    public function validate() {}

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
