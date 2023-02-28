<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems\spaceInfo;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems\teamInfo;
use AlibabaCloud\Tea\Model;

class resultItems extends Model
{
    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

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
     * @description 小组信息
     *
     * @var teamInfo
     */
    public $teamInfo;
    protected $_name = [
        'createTime'          => 'createTime',
        'modifiedTime'        => 'modifiedTime',
        'spaceInfo'           => 'spaceInfo',
        'spacePermissionRole' => 'spacePermissionRole',
        'teamInfo'            => 'teamInfo',
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
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->spaceInfo) {
            $res['spaceInfo'] = null !== $this->spaceInfo ? $this->spaceInfo->toMap() : null;
        }
        if (null !== $this->spacePermissionRole) {
            $res['spacePermissionRole'] = $this->spacePermissionRole;
        }
        if (null !== $this->teamInfo) {
            $res['teamInfo'] = null !== $this->teamInfo ? $this->teamInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resultItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
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
        if (isset($map['teamInfo'])) {
            $model->teamInfo = teamInfo::fromMap($map['teamInfo']);
        }

        return $model;
    }
}
