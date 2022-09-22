<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRecentEditDocsResponseBody\recentList;

use AlibabaCloud\Tea\Model;

class workspaceBO extends Model
{
    /**
     * @description 知识库打开url。
     *
     * @var string
     */
    public $url;

    /**
     * @description 知识库id。
     *
     * @var string
     */
    public $workspaceId;

    /**
     * @description 知识库名称。
     *
     * @var string
     */
    public $workspaceName;
    protected $_name = [
        'url'           => 'url',
        'workspaceId'   => 'workspaceId',
        'workspaceName' => 'workspaceName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return workspaceBO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
