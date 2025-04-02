<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentOrderDetailResponseBody\orderList\subOrderList;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentOrderDetailResponseBody\orderList\subOrderList\payeeAccountDTO\bankDTO;
use AlibabaCloud\Tea\Model;

class payeeAccountDTO extends Model
{
    /**
     * @var bankDTO
     */
    public $bankDTO;
    protected $_name = [
        'bankDTO' => 'bankDTO',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bankDTO) {
            $res['bankDTO'] = null !== $this->bankDTO ? $this->bankDTO->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return payeeAccountDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bankDTO'])) {
            $model->bankDTO = bankDTO::fromMap($map['bankDTO']);
        }

        return $model;
    }
}
