<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailResponseBody\payeeAccountDTO\bankOpenDTO;
use AlibabaCloud\Tea\Model;

class payeeAccountDTO extends Model
{
    /**
     * @var bankOpenDTO
     */
    public $bankOpenDTO;
    protected $_name = [
        'bankOpenDTO' => 'bankOpenDTO',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bankOpenDTO) {
            $res['bankOpenDTO'] = null !== $this->bankOpenDTO ? $this->bankOpenDTO->toMap() : null;
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
        if (isset($map['bankOpenDTO'])) {
            $model->bankOpenDTO = bankOpenDTO::fromMap($map['bankOpenDTO']);
        }

        return $model;
    }
}
