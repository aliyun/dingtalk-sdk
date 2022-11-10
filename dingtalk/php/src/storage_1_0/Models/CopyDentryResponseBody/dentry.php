<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CopyDentryResponseBody\dentry\properties;
use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\DentryAppPropertiesValue;
use AlibabaCloud\Tea\Model;

class dentry extends Model
{
    /**
     * @description 在特定应用上的属性。key是微应用Id, value是属性列表。
     * 10
     * @var DentryAppPropertiesValue[][]
     */
    public $appProperties;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 创建者id
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 后缀
     *
     * @var string
     */
    public $extension;

    /**
     * @description id
     *
     * @var string
     */
    public $id;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @description 修改者id
     *
     * @var string
     */
    public $modifierId;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 父目录id, 根目录id值为0
     * 空值代表根目录的parentId不存在
     * @var string
     */
    public $parentId;

    /**
     * @description 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
     * MINI_OSS_PARTITION: 专属Mini OSS存储分区
     * @var string
     */
    public $partitionType;

    /**
     * @description 路径
     *
     * @var string
     */
    public $path;

    /**
     * @description 属性
     *
     * @var properties
     */
    public $properties;

    /**
     * @description 大小, 单位:Byte
     *
     * @var int
     */
    public $size;

    /**
     * @description 所在空间id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 状态
     * EXPIRED: 已过期
     * @var string
     */
    public $status;

    /**
     * @description 驱动类型
     * UNKNOWN: 未知驱动
     * @var string
     */
    public $storageDriver;

    /**
     * @description 类型，目录或文件
     * FOLDER: 文件夹
     * @var string
     */
    public $type;

    /**
     * @description uuid，如移动文件，此字段不变
     *
     * @var string
     */
    public $uuid;

    /**
     * @description 版本
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'appProperties' => 'appProperties',
        'createTime'    => 'createTime',
        'creatorId'     => 'creatorId',
        'extension'     => 'extension',
        'id'            => 'id',
        'modifiedTime'  => 'modifiedTime',
        'modifierId'    => 'modifierId',
        'name'          => 'name',
        'parentId'      => 'parentId',
        'partitionType' => 'partitionType',
        'path'          => 'path',
        'properties'    => 'properties',
        'size'          => 'size',
        'spaceId'       => 'spaceId',
        'status'        => 'status',
        'storageDriver' => 'storageDriver',
        'type'          => 'type',
        'uuid'          => 'uuid',
        'version'       => 'version',
    ];

    public function validate()
    {
    }

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
     * @return dentry
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
