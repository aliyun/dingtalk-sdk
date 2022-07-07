<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryFinanceCompanyInfoResponseBody extends Model
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
    protected $_name = [
        'companyName' => 'companyName',
        'taxNature'   => 'taxNature',
        'taxNo'       => 'taxNo',
    ];

    public function validate()
    {
    }

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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryFinanceCompanyInfoResponseBody
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

        return $model;
    }
}
