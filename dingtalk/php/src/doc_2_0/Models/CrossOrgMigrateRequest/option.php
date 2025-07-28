<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CrossOrgMigrateRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $checkOperatorSourceRole;

    /**
     * @example true
     *
     * @var bool
     */
    public $deleteSource;

    /**
     * @example true
     *
     * @var bool
     */
    public $needRecycleFailedWorkspaceId;

    /**
     * @example 1L
     *
     * @var int
     */
    public $relateTeamId;

    /**
     * @example team_id
     *
     * @var string
     */
    public $relateTeamIdStr;

    /**
     * @example true
     *
     * @var bool
     */
    public $retainOrgGroup;

    /**
     * @example true
     *
     * @var bool
     */
    public $skipRole;

    /**
     * @var string[]
     */
    public $workspaceIdStrs;

    /**
     * @var int[]
     */
    public $workspaceIds;
    protected $_name = [
        'checkOperatorSourceRole' => 'checkOperatorSourceRole',
        'deleteSource' => 'deleteSource',
        'needRecycleFailedWorkspaceId' => 'needRecycleFailedWorkspaceId',
        'relateTeamId' => 'relateTeamId',
        'relateTeamIdStr' => 'relateTeamIdStr',
        'retainOrgGroup' => 'retainOrgGroup',
        'skipRole' => 'skipRole',
        'workspaceIdStrs' => 'workspaceIdStrs',
        'workspaceIds' => 'workspaceIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkOperatorSourceRole) {
            $res['checkOperatorSourceRole'] = $this->checkOperatorSourceRole;
        }
        if (null !== $this->deleteSource) {
            $res['deleteSource'] = $this->deleteSource;
        }
        if (null !== $this->needRecycleFailedWorkspaceId) {
            $res['needRecycleFailedWorkspaceId'] = $this->needRecycleFailedWorkspaceId;
        }
        if (null !== $this->relateTeamId) {
            $res['relateTeamId'] = $this->relateTeamId;
        }
        if (null !== $this->relateTeamIdStr) {
            $res['relateTeamIdStr'] = $this->relateTeamIdStr;
        }
        if (null !== $this->retainOrgGroup) {
            $res['retainOrgGroup'] = $this->retainOrgGroup;
        }
        if (null !== $this->skipRole) {
            $res['skipRole'] = $this->skipRole;
        }
        if (null !== $this->workspaceIdStrs) {
            $res['workspaceIdStrs'] = $this->workspaceIdStrs;
        }
        if (null !== $this->workspaceIds) {
            $res['workspaceIds'] = $this->workspaceIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['checkOperatorSourceRole'])) {
            $model->checkOperatorSourceRole = $map['checkOperatorSourceRole'];
        }
        if (isset($map['deleteSource'])) {
            $model->deleteSource = $map['deleteSource'];
        }
        if (isset($map['needRecycleFailedWorkspaceId'])) {
            $model->needRecycleFailedWorkspaceId = $map['needRecycleFailedWorkspaceId'];
        }
        if (isset($map['relateTeamId'])) {
            $model->relateTeamId = $map['relateTeamId'];
        }
        if (isset($map['relateTeamIdStr'])) {
            $model->relateTeamIdStr = $map['relateTeamIdStr'];
        }
        if (isset($map['retainOrgGroup'])) {
            $model->retainOrgGroup = $map['retainOrgGroup'];
        }
        if (isset($map['skipRole'])) {
            $model->skipRole = $map['skipRole'];
        }
        if (isset($map['workspaceIdStrs'])) {
            if (!empty($map['workspaceIdStrs'])) {
                $model->workspaceIdStrs = $map['workspaceIdStrs'];
            }
        }
        if (isset($map['workspaceIds'])) {
            if (!empty($map['workspaceIds'])) {
                $model->workspaceIds = $map['workspaceIds'];
            }
        }

        return $model;
    }
}
