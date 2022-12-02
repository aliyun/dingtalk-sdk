<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content;

use AlibabaCloud\Tea\Model;

class groupList extends Model
{
    /**
     * @description 科室id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 科室名称
     *
     * @var string
     */
    public $deptName;

    /**
     * @description 医疗组id
     *
     * @var int
     */
    public $groupId;

    /**
     * @description 医疗组名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 用户在该医疗组是否为考核医疗组
     *
     * @var string
     */
    public $isAssessGroup;

    /**
     * @description 用户在该医疗组是否为组长
     *
     * @var bool
     */
    public $isLeader;

    /**
     * @description 人组关系关联id
     *
     * @var int
     */
    public $relationId;
    protected $_name = [
        'deptId'        => 'deptId',
        'deptName'      => 'deptName',
        'groupId'       => 'groupId',
        'groupName'     => 'groupName',
        'isAssessGroup' => 'isAssessGroup',
        'isLeader'      => 'isLeader',
        'relationId'    => 'relationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->isAssessGroup) {
            $res['isAssessGroup'] = $this->isAssessGroup;
        }
        if (null !== $this->isLeader) {
            $res['isLeader'] = $this->isLeader;
        }
        if (null !== $this->relationId) {
            $res['relationId'] = $this->relationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['isAssessGroup'])) {
            $model->isAssessGroup = $map['isAssessGroup'];
        }
        if (isset($map['isLeader'])) {
            $model->isLeader = $map['isLeader'];
        }
        if (isset($map['relationId'])) {
            $model->relationId = $map['relationId'];
        }

        return $model;
    }
}
