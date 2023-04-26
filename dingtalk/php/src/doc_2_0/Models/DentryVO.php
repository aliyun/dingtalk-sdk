<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryVO\creator;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryVO\updater;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DentryVO\visitorInfo;
use AlibabaCloud\Tea\Model;

class DentryVO extends Model
{
    /**
     * @example alidoc
     *
     * @var string
     */
    public $contentType;

    /**
     * @example 1663918630284
     *
     * @var int
     */
    public $createdTime;

    /**
     * @var creator
     */
    public $creator;

    /**
     * @example YRBd*****KGDA
     *
     * @var string
     */
    public $dentryId;

    /**
     * @example file
     *
     * @var string
     */
    public $dentryType;

    /**
     * @example 6or0dp8Z****XWa91xzy3
     *
     * @var string
     */
    public $dentryUuid;

    /**
     * @example v1GXn****KqD4
     *
     * @var string
     */
    public $docKey;

    /**
     * @example alidoc
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
     * @var LinkSourceInfo
     */
    public $linkSourceInfo;

    /**
     * @example 钉钉文档
     *
     * @var string
     */
    public $name;

    /**
     * @example 测试组织/测试知识库/abc
     *
     * @var string
     */
    public $path;

    /**
     * @var SpaceModel
     */
    public $space;

    /**
     * @example YGv0****0xXAr
     *
     * @var string
     */
    public $spaceId;

    /**
     * @example 1663918630284
     *
     * @var int
     */
    public $updatedTime;

    /**
     * @var updater
     */
    public $updater;

    /**
     * @example https://xxx.yy
     *
     * @var string
     */
    public $url;

    /**
     * @var visitorInfo
     */
    public $visitorInfo;
    protected $_name = [
        'contentType'    => 'contentType',
        'createdTime'    => 'createdTime',
        'creator'        => 'creator',
        'dentryId'       => 'dentryId',
        'dentryType'     => 'dentryType',
        'dentryUuid'     => 'dentryUuid',
        'docKey'         => 'docKey',
        'extension'      => 'extension',
        'hasChildren'    => 'hasChildren',
        'linkSourceInfo' => 'linkSourceInfo',
        'name'           => 'name',
        'path'           => 'path',
        'space'          => 'space',
        'spaceId'        => 'spaceId',
        'updatedTime'    => 'updatedTime',
        'updater'        => 'updater',
        'url'            => 'url',
        'visitorInfo'    => 'visitorInfo',
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
     * @return DentryVO
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
