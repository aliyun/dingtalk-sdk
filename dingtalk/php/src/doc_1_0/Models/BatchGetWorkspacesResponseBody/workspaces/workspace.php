<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspacesResponseBody\workspaces;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspacesResponseBody\workspaces\workspace\recentList;
use AlibabaCloud\Tea\Model;

class workspace extends Model
{
    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $name;

    /**
     * @var bool
     */
    public $orgPublished;

    /**
     * @var recentList[]
     */
    public $recentList;

    /**
     * @var string
     */
    public $url;

    /**
     * @var string
     */
    public $workspaceId;
    protected $_name = [
        'createTime'   => 'createTime',
        'name'         => 'name',
        'orgPublished' => 'orgPublished',
        'recentList'   => 'recentList',
        'url'          => 'url',
        'workspaceId'  => 'workspaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->orgPublished) {
            $res['orgPublished'] = $this->orgPublished;
        }
        if (null !== $this->recentList) {
            $res['recentList'] = [];
            if (null !== $this->recentList && \is_array($this->recentList)) {
                $n = 0;
                foreach ($this->recentList as $item) {
                    $res['recentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->workspaceId) {
            $res['workspaceId'] = $this->workspaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workspace
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['orgPublished'])) {
            $model->orgPublished = $map['orgPublished'];
        }
        if (isset($map['recentList'])) {
            if (!empty($map['recentList'])) {
                $model->recentList = [];
                $n                 = 0;
                foreach ($map['recentList'] as $item) {
                    $model->recentList[$n++] = null !== $item ? recentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }

        return $model;
    }
}
