<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\ListOrgWorkspacesResponseBody;

use AlibabaCloud\Tea\Model;

class workspaces extends Model
{
    /**
     * @example 0
     *
     * @var string
     */
    public $createTime;

    /**
     * @example workspace_id
     *
     * @var string
     */
    public $rootDentryUuid;

    /**
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @example url
     *
     * @var string
     */
    public $url;

    /**
     * @example workspace_id
     *
     * @var string
     */
    public $workspaceId;

    /**
     * @example workspace_name
     *
     * @var string
     */
    public $workspaceName;
    protected $_name = [
        'createTime' => 'createTime',
        'rootDentryUuid' => 'rootDentryUuid',
        'status' => 'status',
        'url' => 'url',
        'workspaceId' => 'workspaceId',
        'workspaceName' => 'workspaceName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->rootDentryUuid) {
            $res['rootDentryUuid'] = $this->rootDentryUuid;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->workspaceId) {
            $res['workspaceId'] = $this->workspaceId;
        }
        if (null !== $this->workspaceName) {
            $res['workspaceName'] = $this->workspaceName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workspaces
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['rootDentryUuid'])) {
            $model->rootDentryUuid = $map['rootDentryUuid'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }
        if (isset($map['workspaceName'])) {
            $model->workspaceName = $map['workspaceName'];
        }

        return $model;
    }
}
