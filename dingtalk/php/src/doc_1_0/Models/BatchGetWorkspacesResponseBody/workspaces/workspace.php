<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspacesResponseBody\workspaces;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchGetWorkspacesResponseBody\workspaces\workspace\recentList;
use AlibabaCloud\Tea\Model;

class workspace extends Model
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
    public $name;

    /**
     * @description 团队空间打开url
     *
     * @var string
     */
    public $url;

    /**
     * @description 最近访问列表
     *
     * @var recentList[]
     */
    public $recentList;

    /**
     * @description 是否全员公开
     *
     * @var bool
     */
    public $orgPublished;

    /**
     * @description 团队空间创建时间
     *
     * @var int
     */
    public $createTime;
    protected $_name = [
        'workspaceId'  => 'workspaceId',
        'name'         => 'name',
        'url'          => 'url',
        'recentList'   => 'recentList',
        'orgPublished' => 'orgPublished',
        'createTime'   => 'createTime',
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
        if (null !== $this->url) {
            $res['url'] = $this->url;
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
        if (null !== $this->orgPublished) {
            $res['orgPublished'] = $this->orgPublished;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
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
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
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
        if (isset($map['orgPublished'])) {
            $model->orgPublished = $map['orgPublished'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }

        return $model;
    }
}
