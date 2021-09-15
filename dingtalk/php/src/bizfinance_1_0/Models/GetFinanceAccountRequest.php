<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFinanceAccountRequest extends Model
{
    /**
     * @description 账户code
     *
     * @var string
     */
    public $accountCode;
    protected $_name = [
        'accountCode' => 'accountCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountCode) {
            $res['accountCode'] = $this->accountCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFinanceAccountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountCode'])) {
            $model->accountCode = $map['accountCode'];
        }

        return $model;
    }
}
