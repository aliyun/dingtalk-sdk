<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePaymentOrderRequest\payeeAccountDTO;

use AlibabaCloud\Tea\Model;

class bankOpenDTO extends Model
{
    /**
     * @example 钉钉中国
     *
     * @var string
     */
    public $accountName;

    /**
     * @example 1025884624512
     *
     * @var string
     */
    public $bankBranchCode;

    /**
     * @example 招商银行杭州余杭分行
     *
     * @var string
     */
    public $bankBranchName;

    /**
     * @example 122215111012
     *
     * @var string
     */
    public $bankCardNo;

    /**
     * @example ICBC
     *
     * @var string
     */
    public $bankCode;

    /**
     * @example 招商银行
     *
     * @var string
     */
    public $bankName;

    /**
     * @example PERSONAL_BANK_CARD
     *
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
