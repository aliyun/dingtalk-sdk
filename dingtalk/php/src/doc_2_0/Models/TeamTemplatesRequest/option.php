<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamTemplatesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @var string[]
     */
    public $excludeWorkspaceIds;

    /**
     * @example 20
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example next_token
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example pc
     *
     * @var string
     */
    public $platform;

    /**
     * @var int[]
     */
    public $templateTypes;

    /**
     * @example 1
     *
     * @var int
     */
    public $version;

    /**
     * @var string[]
     */
    public $workspaceIds;
    protected $_name = [
        'excludeWorkspaceIds' => 'excludeWorkspaceIds',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'platform' => 'platform',
        'templateTypes' => 'templateTypes',
        'version' => 'version',
        'workspaceIds' => 'workspaceIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->excludeWorkspaceIds) {
            $res['excludeWorkspaceIds'] = $this->excludeWorkspaceIds;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->templateTypes) {
            $res['templateTypes'] = $this->templateTypes;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
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
        if (isset($map['excludeWorkspaceIds'])) {
            if (!empty($map['excludeWorkspaceIds'])) {
                $model->excludeWorkspaceIds = $map['excludeWorkspaceIds'];
            }
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['templateTypes'])) {
            if (!empty($map['templateTypes'])) {
                $model->templateTypes = $map['templateTypes'];
            }
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['workspaceIds'])) {
            if (!empty($map['workspaceIds'])) {
                $model->workspaceIds = $map['workspaceIds'];
            }
        }

        return $model;
    }
}
