<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendByAppResponseBody;

use AlibabaCloud\Tea\Model;

class file extends Model
{
    /**
     * @description 文件所在会话id
     *
     * @var string
     */
    public $conversationId;

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
     * @description 文件后缀
     *
     * @var string
     */
    public $extension;

    /**
     * @description 文件id
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
     * @description 文件(夹)名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 文件所在的父目录id, 根目录id值为0
     *
     * @var string
     */
    public $parentId;

    /**
     * @description 文件路径
     *
     * @var string
     */
    public $path;

    /**
     * @description 文件大小, 单位:Byte
     *
     * @var int
     */
    public $size;

    /**
     * @description 文件所在空间id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 文件状态
     * EXPIRED: 已过期
     * @var string
     */
    public $status;

    /**
     * @description 文件类型：文件、文件夹
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
     * @description 文件版本
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'conversationId' => 'conversationId',
        'createTime'     => 'createTime',
        'creatorId'      => 'creatorId',
        'extension'      => 'extension',
        'id'             => 'id',
        'modifiedTime'   => 'modifiedTime',
        'modifierId'     => 'modifierId',
        'name'           => 'name',
        'parentId'       => 'parentId',
        'path'           => 'path',
        'size'           => 'size',
        'spaceId'        => 'spaceId',
        'status'         => 'status',
        'type'           => 'type',
        'uuid'           => 'uuid',
        'version'        => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
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
        if (null !== $this->path) {
            $res['path'] = $this->path;
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
     * @return file
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
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
        if (isset($map['path'])) {
            $model->path = $map['path'];
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
