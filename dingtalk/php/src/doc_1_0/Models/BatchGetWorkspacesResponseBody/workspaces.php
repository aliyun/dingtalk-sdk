<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspacesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspacesResponseBody\workspaces\workspace;
use AlibabaCloud\Tea\Model;

class workspaces extends Model
{
    /**
     * @description 是否有访问知识库权限。
     *
     * @var bool
     */
    public $hasPermission;

    /**
     * @description 知识库信息。
     *
     * @var workspace
     */
    public $workspace;
    protected $_name = [
        'hasPermission' => 'hasPermission',
        'workspace'     => 'workspace',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasPermission) {
            $res['hasPermission'] = $this->hasPermission;
        }
        if (null !== $this->workspace) {
            $res['workspace'] = null !== $this->workspace ? $this->workspace->toMap() : null;
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
        if (isset($map['hasPermission'])) {
            $model->hasPermission = $map['hasPermission'];
        }
        if (isset($map['workspace'])) {
            $model->workspace = workspace::fromMap($map['workspace']);
        }

        return $model;
    }
}
