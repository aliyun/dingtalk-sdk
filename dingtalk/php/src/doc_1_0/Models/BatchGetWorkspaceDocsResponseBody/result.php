<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspaceDocsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspaceDocsResponseBody\result\nodeBO;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspaceDocsResponseBody\result\workspaceBO;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $hasPermission;

    /**
     * @var nodeBO
     */
    public $nodeBO;

    /**
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
     * @return result
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
