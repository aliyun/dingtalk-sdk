<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmBenefitQueryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $benefitCodes;
    protected $_name = [
        'benefitCodes' => 'benefitCodes',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitCodes) {
            $res['benefitCodes'] = $this->benefitCodes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmBenefitQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitCodes'])) {
            if (!empty($map['benefitCodes'])) {
                $model->benefitCodes = $map['benefitCodes'];
            }
        }

        return $model;
    }
}
