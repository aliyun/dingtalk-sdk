<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInvestmentAbroadResponseBody extends Model
{
    /**
     * @example [     {       "InvestLicenseNo": "440301104818958",       "InvestStatus": "在营",       "InvestEsDate": "1998-11-25",       "InvestCreditCode": "914403007084643962",       "ShouldCap": "2000.0万人民币",       "EntName": "华为技术有限公司",       "InvestLegalName": "汤启兵",       "StockPercentage": "100.0%",       "InvestName": "深圳市华为技术服务有限公司",       "InvestRegCap": "2000.0万人民币"     }   ]
     *
     * @var string
     */
    public $data;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'data' => 'data',
        'total' => 'total',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInvestmentAbroadResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
