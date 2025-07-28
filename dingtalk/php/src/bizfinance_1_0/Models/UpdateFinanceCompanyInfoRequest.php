<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateFinanceCompanyInfoRequest extends Model
{
    /**
     * @var string
     */
    public $companyName;

    /**
     * @var string
     */
    public $taxNature;

    /**
     * @var string
     */
    public $taxNo;

    /**
     * @var bool
     */
    public $taxOrInvoiceHasInit;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'companyName' => 'companyName',
        'taxNature' => 'taxNature',
        'taxNo' => 'taxNo',
        'taxOrInvoiceHasInit' => 'taxOrInvoiceHasInit',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
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
     * @return UpdateFinanceCompanyInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
