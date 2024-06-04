<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConsumeBenefitInventoryRequest extends Model
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
     * @example 10
     *
     * @var int
     */
    public $consumeQuota;

    /**
     * @description This parameter is required.
     *
     * @example optStaffId
     *
     * @var string
     */
    public $optUserId;
    protected $_name = [
        'benefitCode'  => 'benefitCode',
        'bizRequestId' => 'bizRequestId',
        'consumeQuota' => 'consumeQuota',
        'optUserId'    => 'optUserId',
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
        if (null !== $this->consumeQuota) {
            $res['consumeQuota'] = $this->consumeQuota;
        }
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConsumeBenefitInventoryRequest
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
        if (isset($map['consumeQuota'])) {
            $model->consumeQuota = $map['consumeQuota'];
        }
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }

        return $model;
    }
}
