<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryPaymentStatusResponseBody\payeeAccountInfo;

use AlibabaCloud\Tea\Model;

class bankOpenDTO extends Model
{
    /**
     * @var string
     */
    public $bankBranchName;

    /**
     * @var string
     */
    public $bankCardNo;

    /**
     * @var string
     */
    public $bankName;
    protected $_name = [
        'bankBranchName' => 'bankBranchName',
        'bankCardNo' => 'bankCardNo',
        'bankName' => 'bankName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bankBranchName) {
            $res['bankBranchName'] = $this->bankBranchName;
        }
        if (null !== $this->bankCardNo) {
            $res['bankCardNo'] = $this->bankCardNo;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return bankOpenDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bankBranchName'])) {
            $model->bankBranchName = $map['bankBranchName'];
        }
        if (isset($map['bankCardNo'])) {
            $model->bankCardNo = $map['bankCardNo'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }

        return $model;
    }
}
