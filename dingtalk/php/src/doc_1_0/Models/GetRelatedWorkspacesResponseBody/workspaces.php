<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRelatedWorkspacesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetRelatedWorkspacesResponseBody\workspaces\recentList;
use AlibabaCloud\Tea\Model;

class workspaces extends Model
{
    /**
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $deleted;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $owner;

    /**
     * @var recentList[]
     */
    public $recentList;

    /**
     * @example OWNER：所有者；MANAGER：管理者；EDITOR：可编辑；VIEWER：可查询\下载；ONLY_VIEWER：尽可查看
     *
     * @var string
     */
    public $role;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $url;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workspaceId;
    protected $_name = [
        'createTime'  => 'createTime',
        'deleted'     => 'deleted',
        'name'        => 'name',
        'owner'       => 'owner',
        'recentList'  => 'recentList',
        'role'        => 'role',
        'url'         => 'url',
        'workspaceId' => 'workspaceId',
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
        if (null !== $this->deleted) {
            $res['deleted'] = $this->deleted;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->owner) {
            $res['owner'] = $this->owner;
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
        if (null !== $this->role) {
            $res['role'] = $this->role;
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
     * @return workspaces
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['deleted'])) {
            $model->deleted = $map['deleted'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
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
        if (isset($map['role'])) {
            $model->role = $map['role'];
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
