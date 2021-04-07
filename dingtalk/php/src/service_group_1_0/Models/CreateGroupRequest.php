<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupRequest extends Model
{
    /**
     * @description 业务关联id
     *
     * @var string
     */
    public $groupBizId;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 开放群组ID
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description 群名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 群主员工ID
     *
     * @var string
     */
    public $ownerStaffId;

    /**
     * @description 群成员员工ID列表
     *
     * @var string[]
     */
    public $memberStaffIds;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;
    protected $_name = [
        'groupBizId'         => 'groupBizId',
        'openTeamId'         => 'openTeamId',
        'openGroupSetId'     => 'openGroupSetId',
        'groupName'          => 'groupName',
        'ownerStaffId'       => 'ownerStaffId',
        'memberStaffIds'     => 'memberStaffIds',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
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
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->ownerStaffId) {
            $res['ownerStaffId'] = $this->ownerStaffId;
        }
        if (null !== $this->memberStaffIds) {
            $res['memberStaffIds'] = $this->memberStaffIds;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
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
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['ownerStaffId'])) {
            $model->ownerStaffId = $map['ownerStaffId'];
        }
        if (isset($map['memberStaffIds'])) {
            if (!empty($map['memberStaffIds'])) {
                $model->memberStaffIds = $map['memberStaffIds'];
            }
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }

        return $model;
    }
}
