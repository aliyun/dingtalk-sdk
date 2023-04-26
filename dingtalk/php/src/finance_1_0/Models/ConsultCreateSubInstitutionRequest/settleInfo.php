<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class settleInfo extends Model
{
    /**
     * @example 622202120200000000
     *
     * @var string
     */
    public $accountId;

    /**
     * @example 李某某
     *
     * @var string
     */
    public $accountName;

    /**
     * @example DEBIT_CARD
     *
     * @var string
     */
    public $accountType;

    /**
     * @example 城东支行
     *
     * @var string
     */
    public $bankBranchName;

    /**
     * @example 杭州市
     *
     * @var string
     */
    public $bankCity;

    /**
     * @example 313791000023
     *
     * @var string
     */
    public $bankCode;

    /**
     * @example 工商银行
     *
     * @var string
     */
    public $bankName;

    /**
     * @example 浙江省
     *
     * @var string
     */
    public $bankProvince;

    /**
     * @example ICBC
     *
     * @var string
     */
    public $bankShortNameCode;

    /**
     * @example ALIPAY
     *
     * @var string
     */
    public $type;

    /**
     * @example TO_PRI
     *
     * @var string
     */
    public $usageType;
    protected $_name = [
        'accountId'         => 'accountId',
        'accountName'       => 'accountName',
        'accountType'       => 'accountType',
        'bankBranchName'    => 'bankBranchName',
        'bankCity'          => 'bankCity',
        'bankCode'          => 'bankCode',
        'bankName'          => 'bankName',
        'bankProvince'      => 'bankProvince',
        'bankShortNameCode' => 'bankShortNameCode',
        'type'              => 'type',
        'usageType'         => 'usageType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->accountName) {
            $res['accountName'] = $this->accountName;
        }
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
        }
        if (null !== $this->bankBranchName) {
            $res['bankBranchName'] = $this->bankBranchName;
        }
        if (null !== $this->bankCity) {
            $res['bankCity'] = $this->bankCity;
        }
        if (null !== $this->bankCode) {
            $res['bankCode'] = $this->bankCode;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }
        if (null !== $this->bankProvince) {
            $res['bankProvince'] = $this->bankProvince;
        }
        if (null !== $this->bankShortNameCode) {
            $res['bankShortNameCode'] = $this->bankShortNameCode;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->usageType) {
            $res['usageType'] = $this->usageType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return settleInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['accountName'])) {
            $model->accountName = $map['accountName'];
        }
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['bankBranchName'])) {
            $model->bankBranchName = $map['bankBranchName'];
        }
        if (isset($map['bankCity'])) {
            $model->bankCity = $map['bankCity'];
        }
        if (isset($map['bankCode'])) {
            $model->bankCode = $map['bankCode'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }
        if (isset($map['bankProvince'])) {
            $model->bankProvince = $map['bankProvince'];
        }
        if (isset($map['bankShortNameCode'])) {
            $model->bankShortNameCode = $map['bankShortNameCode'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['usageType'])) {
            $model->usageType = $map['usageType'];
        }

        return $model;
    }
}
