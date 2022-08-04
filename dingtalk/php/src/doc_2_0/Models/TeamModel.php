<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamModel\creator;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamModel\relatedDeptInfo;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamModel\updater;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamModel\visitInfo;
use AlibabaCloud\Tea\Model;

class TeamModel extends Model
{
    /**
     * @description 封面
     *
     * @var string
     */
    public $cover;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $createdTime;

    /**
     * @description 创建人
     *
     * @var creator
     */
    public $creator;

    /**
     * @description 团队描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 图标
     *
     * @var string
     */
    public $icon;

    /**
     * @description 团队ID
     *
     * @var string
     */
    public $id;

    /**
     * @description 团队名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 关联部门信息
     *
     * @var relatedDeptInfo
     */
    public $relatedDeptInfo;

    /**
     * @description 团队状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 团队类型
     *
     * @var int
     */
    public $type;

    /**
     * @description 更新时间
     *
     * @var int
     */
    public $updatedTime;

    /**
     * @description 更新人
     *
     * @var updater
     */
    public $updater;

    /**
     * @description 团队链接
     *
     * @var string
     */
    public $url;

    /**
     * @description 用户对这个团队的访问情况
     *
     * @var visitInfo
     */
    public $visitInfo;
    protected $_name = [
        'cover'           => 'cover',
        'createdTime'     => 'createdTime',
        'creator'         => 'creator',
        'description'     => 'description',
        'icon'            => 'icon',
        'id'              => 'id',
        'name'            => 'name',
        'relatedDeptInfo' => 'relatedDeptInfo',
        'status'          => 'status',
        'type'            => 'type',
        'updatedTime'     => 'updatedTime',
        'updater'         => 'updater',
        'url'             => 'url',
        'visitInfo'       => 'visitInfo',
    ];

    public function validate()
    {
    }

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
     * @return TeamModel
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
