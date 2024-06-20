<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ListAvailableBenefitResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
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
     * @example 1718696461851
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 200
     *
     * @var int
     */
    public $quota;

    /**
     * @example 1718696461851
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 10
     *
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'benefitCode' => 'benefitCode',
        'endTime'     => 'endTime',
        'quota'       => 'quota',
        'startTime'   => 'startTime',
        'usedQuota'   => 'usedQuota',
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
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->quota) {
            $res['quota'] = $this->quota;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitCode'])) {
            $model->benefitCode = $map['benefitCode'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['quota'])) {
            $model->quota = $map['quota'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
