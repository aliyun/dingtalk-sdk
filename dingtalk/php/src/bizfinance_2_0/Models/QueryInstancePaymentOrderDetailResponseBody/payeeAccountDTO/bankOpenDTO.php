<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryInstancePaymentOrderDetailResponseBody\payeeAccountDTO;

use AlibabaCloud\Tea\Model;

class bankOpenDTO extends Model
{
    /**
     * @var string
     */
    public $accountName;

    /**
     * @var string
     */
    public $bankBranchCode;

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
    public $bankCode;

    /**
     * @var string
     */
    public $bankName;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'accountName' => 'accountName',
        'bankBranchCode' => 'bankBranchCode',
        'bankBranchName' => 'bankBranchName',
        'bankCardNo' => 'bankCardNo',
        'bankCode' => 'bankCode',
        'bankName' => 'bankName',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountName) {
            $res['accountName'] = $this->accountName;
        }
        if (null !== $this->bankBranchCode) {
            $res['bankBranchCode'] = $this->bankBranchCode;
        }
        if (null !== $this->bankBranchName) {
            $res['bankBranchName'] = $this->bankBranchName;
        }
        if (null !== $this->bankCardNo) {
            $res['bankCardNo'] = $this->bankCardNo;
        }
        if (null !== $this->bankCode) {
            $res['bankCode'] = $this->bankCode;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['accountName'])) {
            $model->accountName = $map['accountName'];
        }
        if (isset($map['bankBranchCode'])) {
            $model->bankBranchCode = $map['bankBranchCode'];
        }
        if (isset($map['bankBranchName'])) {
            $model->bankBranchName = $map['bankBranchName'];
        }
        if (isset($map['bankCardNo'])) {
            $model->bankCardNo = $map['bankCardNo'];
        }
        if (isset($map['bankCode'])) {
            $model->bankCode = $map['bankCode'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
