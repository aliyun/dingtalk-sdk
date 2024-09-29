<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentStatusResponseBody\payerAccountInfo\bankOpenDTO;
use AlibabaCloud\Tea\Model;

class payerAccountInfo extends Model
{
    /**
     * @var string
     */
    public $accountType;

    /**
     * @var bankOpenDTO
     */
    public $bankOpenDTO;

    /**
     * @var string
     */
    public $enterpriseAccountCode;
    protected $_name = [
        'accountType'           => 'accountType',
        'bankOpenDTO'           => 'bankOpenDTO',
        'enterpriseAccountCode' => 'enterpriseAccountCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
        }
        if (null !== $this->bankOpenDTO) {
            $res['bankOpenDTO'] = null !== $this->bankOpenDTO ? $this->bankOpenDTO->toMap() : null;
        }
        if (null !== $this->enterpriseAccountCode) {
            $res['enterpriseAccountCode'] = $this->enterpriseAccountCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return payerAccountInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['bankOpenDTO'])) {
            $model->bankOpenDTO = bankOpenDTO::fromMap($map['bankOpenDTO']);
        }
        if (isset($map['enterpriseAccountCode'])) {
            $model->enterpriseAccountCode = $map['enterpriseAccountCode'];
        }

        return $model;
    }
}
