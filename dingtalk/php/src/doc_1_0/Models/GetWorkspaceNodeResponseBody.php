<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetWorkspaceNodeResponseBody extends Model
{
    /**
     * @description 节点信息
     *
     * @var mixed[]
     */
    public $nodeBO;

    /**
     * @description 节点所属团队空间信息
     *
     * @var mixed[]
     */
    public $workspaceBO;

    /**
     * @description 是否有权限
     *
     * @var bool
     */
    public $hasPermission;
    protected $_name = [
        'nodeBO'        => 'nodeBO',
        'workspaceBO'   => 'workspaceBO',
        'hasPermission' => 'hasPermission',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nodeBO) {
            $res['nodeBO'] = $this->nodeBO;
        }
        if (null !== $this->workspaceBO) {
            $res['workspaceBO'] = $this->workspaceBO;
        }
        if (null !== $this->hasPermission) {
            $res['hasPermission'] = $this->hasPermission;
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
        if (isset($map['nodeBO'])) {
            $model->nodeBO = $map['nodeBO'];
        }
        if (isset($map['workspaceBO'])) {
            $model->workspaceBO = $map['workspaceBO'];
        }
        if (isset($map['hasPermission'])) {
            $model->hasPermission = $map['hasPermission'];
        }

        return $model;
    }
}
