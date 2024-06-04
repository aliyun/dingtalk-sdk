<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBenefitInventoryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example B_CUSTOMER_CAPACITY
     *
     * @var string
     */
    public $benefitCode;
    protected $_name = [
        'benefitCode' => 'benefitCode',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBenefitInventoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitCode'])) {
            $model->benefitCode = $map['benefitCode'];
        }

        return $model;
    }
}
