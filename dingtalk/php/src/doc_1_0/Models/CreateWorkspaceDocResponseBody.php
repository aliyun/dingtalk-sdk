<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateWorkspaceDocResponseBody extends Model
{
    /**
     * @description 团队空间Id
     *
     * @var string
     */
    public $workspaceId;

    /**
     * @description 文档Id
     *
     * @var string
     */
    public $nodeId;

    /**
     * @description 文档docKey
     *
     * @var string
     */
    public $docKey;

    /**
     * @description 文档打开url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'workspaceId' => 'workspaceId',
        'nodeId'      => 'nodeId',
        'docKey'      => 'docKey',
        'url'         => 'url',
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
        if (null !== $this->nodeId) {
            $res['nodeId'] = $this->nodeId;
        }
        if (null !== $this->docKey) {
            $res['docKey'] = $this->docKey;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateWorkspaceDocResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }
        if (isset($map['nodeId'])) {
            $model->nodeId = $map['nodeId'];
        }
        if (isset($map['docKey'])) {
            $model->docKey = $map['docKey'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
