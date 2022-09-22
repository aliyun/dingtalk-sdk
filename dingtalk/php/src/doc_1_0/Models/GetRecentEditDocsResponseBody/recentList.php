<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsResponseBody\recentList\nodeBO;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsResponseBody\recentList\workspaceBO;
use AlibabaCloud\Tea\Model;

class recentList extends Model
{
    /**
     * @description 文档信息
     *
     * @var nodeBO
     */
    public $nodeBO;

    /**
     * @description 知识库信息。
     *
     * @var workspaceBO
     */
    public $workspaceBO;
    protected $_name = [
        'nodeBO'      => 'nodeBO',
        'workspaceBO' => 'workspaceBO',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return recentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nodeBO'])) {
            $model->nodeBO = nodeBO::fromMap($map['nodeBO']);
        }
        if (isset($map['workspaceBO'])) {
            $model->workspaceBO = workspaceBO::fromMap($map['workspaceBO']);
        }

        return $model;
    }
}
