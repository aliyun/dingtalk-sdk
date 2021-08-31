<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateWorkspaceResponseBody extends Model
{
    /**
     * @description 工作空间id
     *
     * @var string
     */
    public $workspaceId;

    /**
     * @description 工作空间名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 工作空间描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 工作空间打开url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'workspaceId' => 'workspaceId',
        'name'        => 'name',
        'description' => 'description',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateWorkspaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
