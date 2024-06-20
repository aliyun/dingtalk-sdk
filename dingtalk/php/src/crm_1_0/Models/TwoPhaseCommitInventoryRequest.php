<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class TwoPhaseCommitInventoryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example B_ACCOUNT_NUMBER
     *
     * @var string
     */
    public $benefitCode;

    /**
     * @description This parameter is required.
     *
     * @example bizId
     *
     * @var string
     */
    public $bizRequestId;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $executeResult;

    /**
     * @example 10
     *
     * @var int
     */
    public $quota;
    protected $_name = [
        'benefitCode'   => 'benefitCode',
        'bizRequestId'  => 'bizRequestId',
        'executeResult' => 'executeResult',
        'quota'         => 'quota',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitCode) {
            $res['benefitCode'] = $this->benefitCode;
        }
        if (null !== $this->bizRequestId) {
            $res['bizRequestId'] = $this->bizRequestId;
        }
        if (null !== $this->executeResult) {
            $res['executeResult'] = $this->executeResult;
        }
        if (null !== $this->quota) {
            $res['quota'] = $this->quota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TwoPhaseCommitInventoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitCode'])) {
            $model->benefitCode = $map['benefitCode'];
        }
        if (isset($map['bizRequestId'])) {
            $model->bizRequestId = $map['bizRequestId'];
        }
        if (isset($map['executeResult'])) {
            $model->executeResult = $map['executeResult'];
        }
        if (isset($map['quota'])) {
            $model->quota = $map['quota'];
        }

        return $model;
    }
}
