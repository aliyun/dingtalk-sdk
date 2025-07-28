<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamVO\creator;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamVO\relatedDeptInfo;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamVO\shareScopeInfo;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamVO\updater;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamVO\visitInfo;
use AlibabaCloud\Tea\Model;

class TeamVO extends Model
{
    /**
     * @example https://abc.com
     *
     * @var string
     */
    public $cover;

    /**
     * @example 12340000
     *
     * @var int
     */
    public $createdTime;

    /**
     * @var creator
     */
    public $creator;

    /**
     * @example 这里是团队描述
     *
     * @var string
     */
    public $description;

    /**
     * @example https://def.com
     *
     * @var string
     */
    public $icon;

    /**
     * @description This parameter is required.
     *
     * @example AbcDef
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 测试团队名称
     *
     * @var string
     */
    public $name;

    /**
     * @var relatedDeptInfo
     */
    public $relatedDeptInfo;

    /**
     * @var shareScopeInfo
     */
    public $shareScopeInfo;

    /**
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $type;

    /**
     * @example 34560000
     *
     * @var int
     */
    public $updatedTime;

    /**
     * @var updater
     */
    public $updater;

    /**
     * @description This parameter is required.
     *
     * @example https://abc.com
     *
     * @var string
     */
    public $url;

    /**
     * @var visitInfo
     */
    public $visitInfo;
    protected $_name = [
        'cover' => 'cover',
        'createdTime' => 'createdTime',
        'creator' => 'creator',
        'description' => 'description',
        'icon' => 'icon',
        'id' => 'id',
        'name' => 'name',
        'relatedDeptInfo' => 'relatedDeptInfo',
        'shareScopeInfo' => 'shareScopeInfo',
        'status' => 'status',
        'type' => 'type',
        'updatedTime' => 'updatedTime',
        'updater' => 'updater',
        'url' => 'url',
        'visitInfo' => 'visitInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cover) {
            $res['cover'] = $this->cover;
        }
        if (null !== $this->createdTime) {
            $res['createdTime'] = $this->createdTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->relatedDeptInfo) {
            $res['relatedDeptInfo'] = null !== $this->relatedDeptInfo ? $this->relatedDeptInfo->toMap() : null;
        }
        if (null !== $this->shareScopeInfo) {
            $res['shareScopeInfo'] = null !== $this->shareScopeInfo ? $this->shareScopeInfo->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (null !== $this->visitInfo) {
            $res['visitInfo'] = null !== $this->visitInfo ? $this->visitInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TeamVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cover'])) {
            $model->cover = $map['cover'];
        }
        if (isset($map['createdTime'])) {
            $model->createdTime = $map['createdTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = creator::fromMap($map['creator']);
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['relatedDeptInfo'])) {
            $model->relatedDeptInfo = relatedDeptInfo::fromMap($map['relatedDeptInfo']);
        }
        if (isset($map['shareScopeInfo'])) {
            $model->shareScopeInfo = shareScopeInfo::fromMap($map['shareScopeInfo']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
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
        if (isset($map['visitInfo'])) {
            $model->visitInfo = visitInfo::fromMap($map['visitInfo']);
        }

        return $model;
    }
}
