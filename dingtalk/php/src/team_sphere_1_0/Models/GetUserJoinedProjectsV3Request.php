<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserJoinedProjectsV3Request extends Model
{
    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var string
     */
    public $projectIds;

    /**
     * @var string
     */
    public $projectRoleLevels;

    /**
     * @var string
     */
    public $sortBy;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'projectIds' => 'projectIds',
        'projectRoleLevels' => 'projectRoleLevels',
        'sortBy' => 'sortBy',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->projectIds) {
            $res['projectIds'] = $this->projectIds;
        }
        if (null !== $this->projectRoleLevels) {
            $res['projectRoleLevels'] = $this->projectRoleLevels;
        }
        if (null !== $this->sortBy) {
            $res['sortBy'] = $this->sortBy;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserJoinedProjectsV3Request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['projectIds'])) {
            $model->projectIds = $map['projectIds'];
        }
        if (isset($map['projectRoleLevels'])) {
            $model->projectRoleLevels = $map['projectRoleLevels'];
        }
        if (isset($map['sortBy'])) {
            $model->sortBy = $map['sortBy'];
        }

        return $model;
    }
}
