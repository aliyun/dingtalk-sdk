<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListDentriesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\DentriesAppPropertiesValue;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListDentriesResponseBody\dentries\properties;
use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\ListDentriesResponseBody\dentries\thumbnail;
use AlibabaCloud\Tea\Model;

class dentries extends Model
{
    /**
     * @var DentriesAppPropertiesValue[][]
     */
    public $appProperties;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @example creator_id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example txt
     *
     * @var string
     */
    public $extension;

    /**
     * @example dentry_id
     *
     * @var string
     */
    public $id;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @example modifier_id
     *
     * @var string
     */
    public $modifierId;

    /**
     * @example dentry_name
     *
     * @var string
     */
    public $name;

    /**
     * @example parent_id
     *
     * @var string
     */
    public $parentId;

    /**
     * @example PUBLIC_OSS_PARTITION
     *
     * @var string
     */
    public $partitionType;

    /**
     * @example dentry_path
     *
     * @var string
     */
    public $path;

    /**
     * @var properties
     */
    public $properties;

    /**
     * @example 512
     *
     * @var int
     */
    public $size;

    /**
     * @example space_id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @example NORMAL
     *
     * @var string
     */
    public $status;

    /**
     * @example DINGTALK
     *
     * @var string
     */
    public $storageDriver;

    /**
     * @var thumbnail
     */
    public $thumbnail;

    /**
     * @example file
     *
     * @var string
     */
    public $type;

    /**
     * @example uuid
     *
     * @var string
     */
    public $uuid;

    /**
     * @example 1
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'appProperties' => 'appProperties',
        'createTime' => 'createTime',
        'creatorId' => 'creatorId',
        'extension' => 'extension',
        'id' => 'id',
        'modifiedTime' => 'modifiedTime',
        'modifierId' => 'modifierId',
        'name' => 'name',
        'parentId' => 'parentId',
        'partitionType' => 'partitionType',
        'path' => 'path',
        'properties' => 'properties',
        'size' => 'size',
        'spaceId' => 'spaceId',
        'status' => 'status',
        'storageDriver' => 'storageDriver',
        'thumbnail' => 'thumbnail',
        'type' => 'type',
        'uuid' => 'uuid',
        'version' => 'version',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appProperties) {
            $res['appProperties'] = $this->appProperties;
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->partitionType) {
            $res['partitionType'] = $this->partitionType;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->properties) {
            $res['properties'] = null !== $this->properties ? $this->properties->toMap() : null;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->storageDriver) {
            $res['storageDriver'] = $this->storageDriver;
        }
        if (null !== $this->thumbnail) {
            $res['thumbnail'] = null !== $this->thumbnail ? $this->thumbnail->toMap() : null;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dentries
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appProperties'])) {
            $model->appProperties = $map['appProperties'];
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['partitionType'])) {
            $model->partitionType = $map['partitionType'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }
        if (isset($map['properties'])) {
            $model->properties = properties::fromMap($map['properties']);
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['storageDriver'])) {
            $model->storageDriver = $map['storageDriver'];
        }
        if (isset($map['thumbnail'])) {
            $model->thumbnail = thumbnail::fromMap($map['thumbnail']);
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
