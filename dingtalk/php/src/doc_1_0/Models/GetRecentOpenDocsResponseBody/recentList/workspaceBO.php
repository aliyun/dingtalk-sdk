<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentOpenDocsResponseBody\recentList;

use AlibabaCloud\Tea\Model;

class workspaceBO extends Model
{
    /**
     * @description 团队空间Id
     *
     * @var string
     */
    public $workspaceId;

    /**
     * @description 团队空间名称
     *
     * @var string
     */
    public $workspaceName;
    protected $_name = [
        'workspaceId'   => 'workspaceId',
        'workspaceName' => 'workspaceName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return workspaceBO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }
        if (isset($map['workspaceName'])) {
            $model->workspaceName = $map['workspaceName'];
        }

        return $model;
    }
}
