<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceNodeResponseBody\nodeBO;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetWorkspaceNodeResponseBody\workspaceBO;
use AlibabaCloud\Tea\Model;

class GetWorkspaceNodeResponseBody extends Model
{
    /**
     * @description 是否有权限
     *
     * @var bool
     */
    public $hasPermission;

    /**
     * @description 节点信息
     *
     * @var nodeBO
     */
    public $nodeBO;

    /**
     * @description 节点所属知识库信息。
     *
     * @var workspaceBO
     */
    public $workspaceBO;
    protected $_name = [
        'hasPermission' => 'hasPermission',
        'nodeBO'        => 'nodeBO',
        'workspaceBO'   => 'workspaceBO',
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
        if (null !== $this->nodeBO) {
            $res['nodeBO'] = null !== $this->nodeBO ? $this->nodeBO->toMap() : null;
        }
        if (null !== $this->workspaceBO) {
            $res['workspaceBO'] = null !== $this->workspaceBO ? $this->workspaceBO->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetWorkspaceNodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasPermission'])) {
            $model->hasPermission = $map['hasPermission'];
        }
        if (isset($map['nodeBO'])) {
            $model->nodeBO = nodeBO::fromMap($map['nodeBO']);
        }
        if (isset($map['workspaceBO'])) {
            $model->workspaceBO = workspaceBO::fromMap($map['workspaceBO']);
        }

        return $model;
    }
}
