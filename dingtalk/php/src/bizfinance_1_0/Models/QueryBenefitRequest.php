<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBenefitRequest extends Model
{
    /**
     * @example B_SF2_INVOICE_CHECK_V2
     *
     * @var string
     */
    public $benefitCode;
    protected $_name = [
        'benefitCode' => 'benefitCode',
    ];

    public function validate() {}

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
     * @return QueryBenefitRequest
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
