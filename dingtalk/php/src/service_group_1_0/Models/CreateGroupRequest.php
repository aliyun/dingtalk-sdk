<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupRequest extends Model
{
    /**
     * @example PID123cjj2
     *
     * @var string
     */
    public $groupBizId;

    /**
     * @description This parameter is required.
     *
     * @example 测试服务群
     *
     * @var string
     */
    public $groupName;

    /**
     * @var string[]
     */
    public $groupTagNames;

    /**
     * @var string[]
     */
    public $memberStaffIds;

    /**
     * @description This parameter is required.
     *
     * @example Jciwnfw
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description This parameter is required.
     *
     * @example Jciwnfw
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description This parameter is required.
     *
     * @example manager123
     *
     * @var string
     */
    public $ownerStaffId;
    protected $_name = [
        'groupBizId'     => 'groupBizId',
        'groupName'      => 'groupName',
        'groupTagNames'  => 'groupTagNames',
        'memberStaffIds' => 'memberStaffIds',
        'openGroupSetId' => 'openGroupSetId',
        'openTeamId'     => 'openTeamId',
        'ownerStaffId'   => 'ownerStaffId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupBizId) {
            $res['groupBizId'] = $this->groupBizId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupTagNames) {
            $res['groupTagNames'] = $this->groupTagNames;
        }
        if (null !== $this->memberStaffIds) {
            $res['memberStaffIds'] = $this->memberStaffIds;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->ownerStaffId) {
            $res['ownerStaffId'] = $this->ownerStaffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupBizId'])) {
            $model->groupBizId = $map['groupBizId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupTagNames'])) {
            if (!empty($map['groupTagNames'])) {
                $model->groupTagNames = $map['groupTagNames'];
            }
        }
        if (isset($map['memberStaffIds'])) {
            if (!empty($map['memberStaffIds'])) {
                $model->memberStaffIds = $map['memberStaffIds'];
            }
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['ownerStaffId'])) {
            $model->ownerStaffId = $map['ownerStaffId'];
        }

        return $model;
    }
}
