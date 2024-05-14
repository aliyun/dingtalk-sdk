<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRelatedWorkspacesResponseBody\workspaces;

use AlibabaCloud\Tea\Model;

class recentList extends Model
{
    /**
     * @var int
     */
    public $lastEditTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $nodeId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'lastEditTime' => 'lastEditTime',
        'name'         => 'name',
        'nodeId'       => 'nodeId',
        'url'          => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->lastEditTime) {
            $res['lastEditTime'] = $this->lastEditTime;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nodeId) {
            $res['nodeId'] = $this->nodeId;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
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
        if (isset($map['lastEditTime'])) {
            $model->lastEditTime = $map['lastEditTime'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nodeId'])) {
            $model->nodeId = $map['nodeId'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
