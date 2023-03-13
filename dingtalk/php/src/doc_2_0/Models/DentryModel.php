<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryModel\creator;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryModel\statisticalInfo;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryModel\updater;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryModel\visitorInfo;
use AlibabaCloud\Tea\Model;

class DentryModel extends Model
{
    /**
     * @description 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包；document-文件。
     *
     * @var string
     */
    public $contentType;

    /**
     * @description 创建时间。
     *
     * @var int
     */
    public $createdTime;

    /**
     * @description 创建者。
     *
     * @var creator
     */
    public $creator;

    /**
     * @description 节点id。
     *
     * @var string
     */
    public $dentryId;

    /**
     * @description 节点类型。file-文件；folder-文件夹。
     *
     * @var string
     */
    public $dentryType;

    /**
     * @description 节点全局唯一标识id。
     *
     * @var string
     */
    public $dentryUuid;

    /**
     * @description 文档docKey，用于标识一篇钉钉文档的key。只有内容类型为alidoc的才会有值。
     *
     * @var string
     */
    public $docKey;

    /**
     * @description 文件后缀名。
     *
     * @var string
     */
    public $extension;

    /**
     * @description 是否有子节点。
     *
     * @var bool
     */
    public $hasChildren;

    /**
     * @description 快捷方式类型的节点，其指向的原始数据信息。
     *
     * @var LinkSourceInfo
     */
    public $linkSourceInfo;

    /**
     * @description 节点名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 节点的路径。
     *
     * @var string
     */
    public $path;

    /**
     * @description 知识库信息。
     *
     * @var SpaceModel
     */
    public $space;

    /**
     * @description 知识库id。
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 统计信息
     *
     * @var statisticalInfo
     */
    public $statisticalInfo;

    /**
     * @description 更新时间。
     *
     * @var int
     */
    public $updatedTime;

    /**
     * @description 更新人。
     *
     * @var updater
     */
    public $updater;

    /**
     * @description 节点访问url。
     *
     * @var string
     */
    public $url;

    /**
     * @description 访问者对当前节点的权限等信息。
     *
     * @var visitorInfo
     */
    public $visitorInfo;
    protected $_name = [
        'contentType'     => 'contentType',
        'createdTime'     => 'createdTime',
        'creator'         => 'creator',
        'dentryId'        => 'dentryId',
        'dentryType'      => 'dentryType',
        'dentryUuid'      => 'dentryUuid',
        'docKey'          => 'docKey',
        'extension'       => 'extension',
        'hasChildren'     => 'hasChildren',
        'linkSourceInfo'  => 'linkSourceInfo',
        'name'            => 'name',
        'path'            => 'path',
        'space'           => 'space',
        'spaceId'         => 'spaceId',
        'statisticalInfo' => 'statisticalInfo',
        'updatedTime'     => 'updatedTime',
        'updater'         => 'updater',
        'url'             => 'url',
        'visitorInfo'     => 'visitorInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->createdTime) {
            $res['createdTime'] = $this->createdTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->dentryType) {
            $res['dentryType'] = $this->dentryType;
        }
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->docKey) {
            $res['docKey'] = $this->docKey;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->hasChildren) {
            $res['hasChildren'] = $this->hasChildren;
        }
        if (null !== $this->linkSourceInfo) {
            $res['linkSourceInfo'] = null !== $this->linkSourceInfo ? $this->linkSourceInfo->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->space) {
            $res['space'] = null !== $this->space ? $this->space->toMap() : null;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->statisticalInfo) {
            $res['statisticalInfo'] = null !== $this->statisticalInfo ? $this->statisticalInfo->toMap() : null;
        }
        if (null !== $this->updatedTime) {
            $res['updatedTime'] = $this->updatedTime;
        }
        if (null !== $this->updater) {
            $res['updater'] = null !== $this->updater ? $this->updater->toMap() : null;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->visitorInfo) {
            $res['visitorInfo'] = null !== $this->visitorInfo ? $this->visitorInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DentryModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['createdTime'])) {
            $model->createdTime = $map['createdTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = creator::fromMap($map['creator']);
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['dentryType'])) {
            $model->dentryType = $map['dentryType'];
        }
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['docKey'])) {
            $model->docKey = $map['docKey'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['hasChildren'])) {
            $model->hasChildren = $map['hasChildren'];
        }
        if (isset($map['linkSourceInfo'])) {
            $model->linkSourceInfo = LinkSourceInfo::fromMap($map['linkSourceInfo']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }
        if (isset($map['space'])) {
            $model->space = SpaceModel::fromMap($map['space']);
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['statisticalInfo'])) {
            $model->statisticalInfo = statisticalInfo::fromMap($map['statisticalInfo']);
        }
        if (isset($map['updatedTime'])) {
            $model->updatedTime = $map['updatedTime'];
        }
        if (isset($map['updater'])) {
            $model->updater = updater::fromMap($map['updater']);
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['visitorInfo'])) {
            $model->visitorInfo = visitorInfo::fromMap($map['visitorInfo']);
        }

        return $model;
    }
}
