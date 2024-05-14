<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateFinanceMultiCompanyInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @description This parameter is required.
     *
     * @example 钉钉
     *
     * @var string
     */
    public $companyName;

    /**
     * @example generalTaxpayer
     *
     * @var string
     */
    public $taxNature;

    /**
     * @example 123456789012345
     *
     * @var string
     */
    public $taxNo;

    /**
     * @var bool
     */
    public $taxOrInvoiceHasInit;

    /**
     * @example 123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'companyCode'         => 'companyCode',
        'companyName'         => 'companyName',
        'taxNature'           => 'taxNature',
        'taxNo'               => 'taxNo',
        'taxOrInvoiceHasInit' => 'taxOrInvoiceHasInit',
        'userId'              => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->companyName) {
            $res['companyName'] = $this->companyName;
        }
        if (null !== $this->taxNature) {
            $res['taxNature'] = $this->taxNature;
        }
        if (null !== $this->taxNo) {
            $res['taxNo'] = $this->taxNo;
        }
        if (null !== $this->taxOrInvoiceHasInit) {
            $res['taxOrInvoiceHasInit'] = $this->taxOrInvoiceHasInit;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFinanceMultiCompanyInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['companyName'])) {
            $model->companyName = $map['companyName'];
        }
        if (isset($map['taxNature'])) {
            $model->taxNature = $map['taxNature'];
        }
        if (isset($map['taxNo'])) {
            $model->taxNo = $map['taxNo'];
        }
        if (isset($map['taxOrInvoiceHasInit'])) {
            $model->taxOrInvoiceHasInit = $map['taxOrInvoiceHasInit'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
