<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class BindCompanyAccountantBookRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example abc
     *
     * @var string
     */
    public $accountantBookId;

    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;
    protected $_name = [
        'accountantBookId' => 'accountantBookId',
        'companyCode' => 'companyCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountantBookId) {
            $res['accountantBookId'] = $this->accountantBookId;
        }
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BindCompanyAccountantBookRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountantBookId'])) {
            $model->accountantBookId = $map['accountantBookId'];
        }
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }

        return $model;
    }
}
