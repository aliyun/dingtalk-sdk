<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems\spaceInfo;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems\teamInfo;
use AlibabaCloud\Tea\Model;

class resultItems extends Model
{
    /**
     * @example 2022-01-01T10:00:00Z
     *
     * @var string
     */
    public $createTime;

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
     * @var teamInfo
     */
    public $teamInfo;
    protected $_name = [
        'createTime' => 'createTime',
        'modifiedTime' => 'modifiedTime',
        'spaceInfo' => 'spaceInfo',
        'spacePermissionRole' => 'spacePermissionRole',
        'teamInfo' => 'teamInfo',
    ];

    public function validate() {}

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
