<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmProcessTransferRequest extends Model
{
    /**
     * @description 员工调岗后的部门id列表
     *
     * @var int[]
     */
    public $deptIdsAfterTransfer;

    /**
     * @description 员工调岗后的职务id
     *
     * @var string
     */
    public $jobIdAfterTransfer;

    /**
     * @description 员工调岗后的人事主部门id
     *
     * @var int
     */
    public $mainDeptIdAfterTransfer;

    /**
     * @description 操作人
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @description 员工调岗后的职位id，参数同时有职位名称以及id，以id为准
     *
     * @var string
     */
    public $positionIdAfterTransfer;

    /**
     * @description 员工调岗后的职级名称，长度不超过64，参数同时有职级名称以及id，以id为准
     *
     * @var string
     */
    public $positionLevelAfterTransfer;

    /**
     * @description 员工调岗后的职位名称，长度不超过124，参数同时有职位名称以及id，以id为准
     *
     * @var string
     */
    public $positionNameAfterTransfer;

    /**
     * @description 员工调岗后的职级id，参数同时有职级名称以及id，以id为准
     *
     * @var string
     */
    public $rankIdAfterTransfer;

    /**
     * @description 被调岗员工userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'deptIdsAfterTransfer'       => 'deptIdsAfterTransfer',
        'jobIdAfterTransfer'         => 'jobIdAfterTransfer',
        'mainDeptIdAfterTransfer'    => 'mainDeptIdAfterTransfer',
        'operateUserId'              => 'operateUserId',
        'positionIdAfterTransfer'    => 'positionIdAfterTransfer',
        'positionLevelAfterTransfer' => 'positionLevelAfterTransfer',
        'positionNameAfterTransfer'  => 'positionNameAfterTransfer',
        'rankIdAfterTransfer'        => 'rankIdAfterTransfer',
        'userId'                     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIdsAfterTransfer) {
            $res['deptIdsAfterTransfer'] = $this->deptIdsAfterTransfer;
        }
        if (null !== $this->jobIdAfterTransfer) {
            $res['jobIdAfterTransfer'] = $this->jobIdAfterTransfer;
        }
        if (null !== $this->mainDeptIdAfterTransfer) {
            $res['mainDeptIdAfterTransfer'] = $this->mainDeptIdAfterTransfer;
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }
        if (null !== $this->positionIdAfterTransfer) {
            $res['positionIdAfterTransfer'] = $this->positionIdAfterTransfer;
        }
        if (null !== $this->positionLevelAfterTransfer) {
            $res['positionLevelAfterTransfer'] = $this->positionLevelAfterTransfer;
        }
        if (null !== $this->positionNameAfterTransfer) {
            $res['positionNameAfterTransfer'] = $this->positionNameAfterTransfer;
        }
        if (null !== $this->rankIdAfterTransfer) {
            $res['rankIdAfterTransfer'] = $this->rankIdAfterTransfer;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmProcessTransferRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIdsAfterTransfer'])) {
            if (!empty($map['deptIdsAfterTransfer'])) {
                $model->deptIdsAfterTransfer = $map['deptIdsAfterTransfer'];
            }
        }
        if (isset($map['jobIdAfterTransfer'])) {
            $model->jobIdAfterTransfer = $map['jobIdAfterTransfer'];
        }
        if (isset($map['mainDeptIdAfterTransfer'])) {
            $model->mainDeptIdAfterTransfer = $map['mainDeptIdAfterTransfer'];
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }
        if (isset($map['positionIdAfterTransfer'])) {
            $model->positionIdAfterTransfer = $map['positionIdAfterTransfer'];
        }
        if (isset($map['positionLevelAfterTransfer'])) {
            $model->positionLevelAfterTransfer = $map['positionLevelAfterTransfer'];
        }
        if (isset($map['positionNameAfterTransfer'])) {
            $model->positionNameAfterTransfer = $map['positionNameAfterTransfer'];
        }
        if (isset($map['rankIdAfterTransfer'])) {
            $model->rankIdAfterTransfer = $map['rankIdAfterTransfer'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
