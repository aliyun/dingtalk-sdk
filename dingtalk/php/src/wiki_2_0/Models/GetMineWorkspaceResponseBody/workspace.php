<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetMineWorkspaceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetMineWorkspaceResponseBody\workspace\icon;
use AlibabaCloud\Tea\Model;

class workspace extends Model
{
    /**
     * @example corp_id
     *
     * @var string
     */
    public $corpId;

    /**
     * @example workspace_cover
     *
     * @var string
     */
    public $cover;

    /**
     * @example workspace_create_time
     *
     * @var string
     */
    public $createTime;

    /**
     * @example workspace_creator_id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example workspace_description
     *
     * @var string
     */
    public $description;

    /**
     * @var icon
     */
    public $icon;

    /**
     * @example workspace_modified_time
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @example workspace_modifier_id
     *
     * @var string
     */
    public $modifierId;

    /**
     * @example workspace_name
     *
     * @var string
     */
    public $name;

    /**
     * @example READER
     *
     * @var string
     */
    public $permissionRole;

    /**
     * @example root_node_uuid
     *
     * @var string
     */
    public $rootNodeId;

    /**
     * @example team_id
     *
     * @var string
     */
    public $teamId;

    /**
     * @example TEAM
     *
     * @var string
     */
    public $type;

    /**
     * @example workspace_url
     *
     * @var string
     */
    public $url;

    /**
     * @example workspace_id
     *
     * @var string
     */
    public $workspaceId;
    protected $_name = [
        'corpId'         => 'corpId',
        'cover'          => 'cover',
        'createTime'     => 'createTime',
        'creatorId'      => 'creatorId',
        'description'    => 'description',
        'icon'           => 'icon',
        'modifiedTime'   => 'modifiedTime',
        'modifierId'     => 'modifierId',
        'name'           => 'name',
        'permissionRole' => 'permissionRole',
        'rootNodeId'     => 'rootNodeId',
        'teamId'         => 'teamId',
        'type'           => 'type',
        'url'            => 'url',
        'workspaceId'    => 'workspaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->cover) {
            $res['cover'] = $this->cover;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = null !== $this->icon ? $this->icon->toMap() : null;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->modifierId) {
            $res['modifierId'] = $this->modifierId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->permissionRole) {
            $res['permissionRole'] = $this->permissionRole;
        }
        if (null !== $this->rootNodeId) {
            $res['rootNodeId'] = $this->rootNodeId;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['cover'])) {
            $model->cover = $map['cover'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = icon::fromMap($map['icon']);
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['modifierId'])) {
            $model->modifierId = $map['modifierId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['permissionRole'])) {
            $model->permissionRole = $map['permissionRole'];
        }
        if (isset($map['rootNodeId'])) {
            $model->rootNodeId = $map['rootNodeId'];
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
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
