<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchCreateTeamRequest\param;

use AlibabaCloud\Tea\Model;

class createTeamParamList extends Model
{
    /**
     * @var string[]
     */
    public $adminUnionIdList;

    /**
     * @description This parameter is required.
     *
     * @example creator_union_id
     *
     * @var string
     */
    public $creatorUnionId;

    /**
     * @description This parameter is required.
     *
     * @example dept_id
     *
     * @var string
     */
    public $deptId;

    /**
     * @description This parameter is required.
     *
     * @example team_name
     *
     * @var string
     */
    public $teamName;
    protected $_name = [
        'adminUnionIdList' => 'adminUnionIdList',
        'creatorUnionId'   => 'creatorUnionId',
        'deptId'           => 'deptId',
        'teamName'         => 'teamName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->adminUnionIdList) {
            $res['adminUnionIdList'] = $this->adminUnionIdList;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->teamName) {
            $res['teamName'] = $this->teamName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return createTeamParamList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adminUnionIdList'])) {
            if (!empty($map['adminUnionIdList'])) {
                $model->adminUnionIdList = $map['adminUnionIdList'];
            }
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['teamName'])) {
            $model->teamName = $map['teamName'];
        }

        return $model;
    }
}
