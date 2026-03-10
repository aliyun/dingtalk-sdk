<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewBenefitResponseBody\result;

use AlibabaCloud\Tea\Model;

class benefitResponses extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var int
     */
    public $restBenefit;

    /**
     * @var int
     */
    public $usedBenefit;
    protected $_name = [
        'code' => 'code',
        'restBenefit' => 'restBenefit',
        'usedBenefit' => 'usedBenefit',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->restBenefit) {
            $res['restBenefit'] = $this->restBenefit;
        }
        if (null !== $this->usedBenefit) {
            $res['usedBenefit'] = $this->usedBenefit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return benefitResponses
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['restBenefit'])) {
            $model->restBenefit = $map['restBenefit'];
        }
        if (isset($map['usedBenefit'])) {
            $model->usedBenefit = $map['usedBenefit'];
        }

        return $model;
    }
}
