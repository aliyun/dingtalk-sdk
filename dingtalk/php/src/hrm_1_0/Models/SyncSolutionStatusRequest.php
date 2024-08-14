<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncSolutionStatusRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example start
     *
     * @var string
     */
    public $solutionStatus;

    /**
     * @description This parameter is required.
     *
     * @example onboarding_v2
     *
     * @var string
     */
    public $solutionType;

    /**
     * @description This parameter is required.
     *
     * @example 12
     *
     * @var int
     */
    public $tenantId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'bizId'          => 'bizId',
        'solutionStatus' => 'solutionStatus',
        'solutionType'   => 'solutionType',
        'tenantId'       => 'tenantId',
        'userIds'        => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->solutionStatus) {
            $res['solutionStatus'] = $this->solutionStatus;
        }
        if (null !== $this->solutionType) {
            $res['solutionType'] = $this->solutionType;
        }
        if (null !== $this->tenantId) {
            $res['tenantId'] = $this->tenantId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncSolutionStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['solutionStatus'])) {
            $model->solutionStatus = $map['solutionStatus'];
        }
        if (isset($map['solutionType'])) {
            $model->solutionType = $map['solutionType'];
        }
        if (isset($map['tenantId'])) {
            $model->tenantId = $map['tenantId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
