<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmProcessTransferRequest extends Model
{
    /**
     * @var int[]
     */
    public $deptIdsAfterTransfer;

    /**
     * @example aefadfadaewedad
     *
     * @var string
     */
    public $jobIdAfterTransfer;

    /**
     * @example 123L
     *
     * @var int
     */
    public $mainDeptIdAfterTransfer;

    /**
     * @example 232312312
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @example fasdfaddsadfa
     *
     * @var string
     */
    public $positionIdAfterTransfer;

    /**
     * @example L1
     *
     * @var string
     */
    public $positionLevelAfterTransfer;

    /**
     * @example 经理
     *
     * @var string
     */
    public $positionNameAfterTransfer;

    /**
     * @example fasdfaddsadfa
     *
     * @var string
     */
    public $rankIdAfterTransfer;

    /**
     * @description This parameter is required.
     *
     * @example 2332
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
