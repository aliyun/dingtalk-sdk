<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsResponseBody\starList\dentryInfo;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsResponseBody\starList\spaceInfo;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsResponseBody\starList\teamInfo;
use AlibabaCloud\Tea\Model;

class starList extends Model
{
    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 资源实体数据
     *
     * @var dentryInfo
     */
    public $dentryInfo;

    /**
     * @description 文档权限
     * OWNER: 所有者
     * @var string
     */
    public $dentryPermissionRole;

    /**
     * @description 星标id
     *
     * @var string
     */
    public $id;

    /**
     * @description 是否已经删除
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @description 知识库信息
     *
     * @var spaceInfo
     */
    public $spaceInfo;

    /**
     * @description 知识库权限
     * OWNER: 所有者
     * @var string
     */
    public $spacePermissionRole;

    /**
     * @description 星标类型
     * COMMON: 普通星标
     * @var string
     */
    public $starType;

    /**
     * @description 小组信息
     *
     * @var teamInfo
     */
    public $teamInfo;
    protected $_name = [
        'createTime'           => 'createTime',
        'dentryInfo'           => 'dentryInfo',
        'dentryPermissionRole' => 'dentryPermissionRole',
        'id'                   => 'id',
        'isDeleted'            => 'isDeleted',
        'modifiedTime'         => 'modifiedTime',
        'spaceInfo'            => 'spaceInfo',
        'spacePermissionRole'  => 'spacePermissionRole',
        'starType'             => 'starType',
        'teamInfo'             => 'teamInfo',
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
        if (null !== $this->dentryInfo) {
            $res['dentryInfo'] = null !== $this->dentryInfo ? $this->dentryInfo->toMap() : null;
        }
        if (null !== $this->dentryPermissionRole) {
            $res['dentryPermissionRole'] = $this->dentryPermissionRole;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->spaceInfo) {
            $res['spaceInfo'] = null !== $this->spaceInfo ? $this->spaceInfo->toMap() : null;
        }
        if (null !== $this->spacePermissionRole) {
            $res['spacePermissionRole'] = $this->spacePermissionRole;
        }
        if (null !== $this->starType) {
            $res['starType'] = $this->starType;
        }
        if (null !== $this->teamInfo) {
            $res['teamInfo'] = null !== $this->teamInfo ? $this->teamInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return starList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['dentryInfo'])) {
            $model->dentryInfo = dentryInfo::fromMap($map['dentryInfo']);
        }
        if (isset($map['dentryPermissionRole'])) {
            $model->dentryPermissionRole = $map['dentryPermissionRole'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['spaceInfo'])) {
            $model->spaceInfo = spaceInfo::fromMap($map['spaceInfo']);
        }
        if (isset($map['spacePermissionRole'])) {
            $model->spacePermissionRole = $map['spacePermissionRole'];
        }
        if (isset($map['starType'])) {
            $model->starType = $map['starType'];
        }
        if (isset($map['teamInfo'])) {
            $model->teamInfo = teamInfo::fromMap($map['teamInfo']);
        }

        return $model;
    }
}
