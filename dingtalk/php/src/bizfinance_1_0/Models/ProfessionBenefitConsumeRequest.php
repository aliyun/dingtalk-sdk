<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ProfessionBenefitConsumeRequest extends Model
{
    /**
     * @description 权益编码
     *
     *
     * @var string
     */
    public $benefitCode;

    /**
     * @description 幂等ID
     *
     *
     * @var string
     */
    public $bizRequestId;

    /**
     * @description 核销数量
     *
     * @var int
     */
    public $quota;
    protected $_name = [
        'benefitCode'  => 'benefitCode',
        'bizRequestId' => 'bizRequestId',
        'quota'        => 'quota',
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
        if (null !== $this->quota) {
            $res['quota'] = $this->quota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ProfessionBenefitConsumeRequest
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
        if (isset($map['quota'])) {
            $model->quota = $map['quota'];
        }

        return $model;
    }
}
