<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodesResponseBody\nodes\statisticalInfo;
use AlibabaCloud\Tea\Model;

class nodes extends Model
{
    /**
     * @example ALIDOC
     *
     * @var string
     */
    public $category;

    /**
     * @example node_create_time
     *
     * @var string
     */
    public $createTime;

    /**
     * @example node_creator_id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example adoc
     *
     * @var string
     */
    public $extension;

    /**
     * @example false
     *
     * @var bool
     */
    public $hasChildren;

    /**
     * @example node_modified_time
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @example node_modifier_id
     *
     * @var string
     */
    public $modifierId;

    /**
     * @example node_name
     *
     * @var string
     */
    public $name;

    /**
     * @example node_id
     *
     * @var string
     */
    public $nodeId;

    /**
     * @example READER
     *
     * @var string
     */
    public $permissionRole;

    /**
     * @example 512
     *
     * @var int
     */
    public $size;

    /**
     * @var statisticalInfo
     */
    public $statisticalInfo;

    /**
     * @example FILE
     *
     * @var string
     */
    public $type;

    /**
     * @example node_url
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
        'category'        => 'category',
        'createTime'      => 'createTime',
        'creatorId'       => 'creatorId',
        'extension'       => 'extension',
        'hasChildren'     => 'hasChildren',
        'modifiedTime'    => 'modifiedTime',
        'modifierId'      => 'modifierId',
        'name'            => 'name',
        'nodeId'          => 'nodeId',
        'permissionRole'  => 'permissionRole',
        'size'            => 'size',
        'statisticalInfo' => 'statisticalInfo',
        'type'            => 'type',
        'url'             => 'url',
        'workspaceId'     => 'workspaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->hasChildren) {
            $res['hasChildren'] = $this->hasChildren;
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
        if (null !== $this->nodeId) {
            $res['nodeId'] = $this->nodeId;
        }
        if (null !== $this->permissionRole) {
            $res['permissionRole'] = $this->permissionRole;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->statisticalInfo) {
            $res['statisticalInfo'] = null !== $this->statisticalInfo ? $this->statisticalInfo->toMap() : null;
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
     * @return nodes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['hasChildren'])) {
            $model->hasChildren = $map['hasChildren'];
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
        if (isset($map['nodeId'])) {
            $model->nodeId = $map['nodeId'];
        }
        if (isset($map['permissionRole'])) {
            $model->permissionRole = $map['permissionRole'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['statisticalInfo'])) {
            $model->statisticalInfo = statisticalInfo::fromMap($map['statisticalInfo']);
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
