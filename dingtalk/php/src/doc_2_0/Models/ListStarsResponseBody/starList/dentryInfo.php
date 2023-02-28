<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsResponseBody\starList;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsResponseBody\starList\dentryInfo\creator;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsResponseBody\starList\dentryInfo\modifier;
use AlibabaCloud\Tea\Model;

class dentryInfo extends Model
{
    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 创建者信息
     *
     * @var creator
     */
    public $creator;

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
     * @description Mobile访问链接
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @description 修改者信息
     *
     * @var modifier
     */
    public $modifier;

    /**
     * @description 名称
     *
     * @var string
     */
    public $name;

    /**
     * @description PC 访问链接
     *
     * @var string
     */
    public $pcUrl;

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
    protected $_name = [
        'createTime'   => 'createTime',
        'creator'      => 'creator',
        'extension'    => 'extension',
        'id'           => 'id',
        'mobileUrl'    => 'mobileUrl',
        'modifiedTime' => 'modifiedTime',
        'modifier'     => 'modifier',
        'name'         => 'name',
        'pcUrl'        => 'pcUrl',
        'spaceId'      => 'spaceId',
        'status'       => 'status',
        'type'         => 'type',
        'uuid'         => 'uuid',
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
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = null !== $this->modifier ? $this->modifier->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dentryInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = creator::fromMap($map['creator']);
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = modifier::fromMap($map['modifier']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
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

        return $model;
    }
}
