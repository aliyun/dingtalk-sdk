<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class EnableCompanyRequest extends Model
{
    /**
     * @var string
     */
    public $companyCode;
    protected $_name = [
        'companyCode' => 'companyCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EnableCompanyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }

        return $model;
    }
}
