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
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @var dentryInfo
     */
    public $dentryInfo;

    /**
     * @example NO_PERMISSION
     *
     * @var string
     */
    public $dentryPermissionRole;

    /**
     * @example star_id
     *
     * @var string
     */
    public $id;

    /**
     * @example true
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @var spaceInfo
     */
    public $spaceInfo;

    /**
     * @example NO_PERMISSION
     *
     * @var string
     */
    public $spacePermissionRole;

    /**
     * @var string
     */
    public $starType;

    /**
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
