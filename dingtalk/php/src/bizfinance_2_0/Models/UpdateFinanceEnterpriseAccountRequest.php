<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateFinanceEnterpriseAccountRequest extends Model
{
    /**
     * @example ACC_XXXXXX
     *
     * @var string
     */
    public $accountCode;

    /**
     * @example 钉钉科技
     *
     * @var string
     */
    public $accountName;

    /**
     * @example BANKCARD
     *
     * @var string
     */
    public $accountType;

    /**
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
     * @example 中国工商银行
     *
     * @var string
     */
    public $bankName;

    /**
     * @example 杭州市
     *
     * @var string
     */
    public $city;

    /**
     * @example 账户描述
     *
     * @var string
     */
    public $description;

    /**
     * @example 中国工商银行余杭分行
     *
     * @var string
     */
    public $officialName;

    /**
     * @example 1128878445
     *
     * @var string
     */
    public $officialNumber;

    /**
     * @example 浙江省
     *
     * @var string
     */
    public $province;

    /**
     * @example smallScaleTaxpayer
     *
     * @var string
     */
    public $taxNature;

    /**
     * @example 125481254812548
     *
     * @var string
     */
    public $taxNo;

    /**
     * @example 5046195764756652
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'accountCode' => 'accountCode',
        'accountName' => 'accountName',
        'accountType' => 'accountType',
        'bankCardNo' => 'bankCardNo',
        'bankCode' => 'bankCode',
        'bankName' => 'bankName',
        'city' => 'city',
        'description' => 'description',
        'officialName' => 'officialName',
        'officialNumber' => 'officialNumber',
        'province' => 'province',
        'taxNature' => 'taxNature',
        'taxNo' => 'taxNo',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountCode) {
            $res['accountCode'] = $this->accountCode;
        }
        if (null !== $this->accountName) {
            $res['accountName'] = $this->accountName;
        }
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
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
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->officialName) {
            $res['officialName'] = $this->officialName;
        }
        if (null !== $this->officialNumber) {
            $res['officialNumber'] = $this->officialNumber;
        }
        if (null !== $this->province) {
            $res['province'] = $this->province;
        }
        if (null !== $this->taxNature) {
            $res['taxNature'] = $this->taxNature;
        }
        if (null !== $this->taxNo) {
            $res['taxNo'] = $this->taxNo;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFinanceEnterpriseAccountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountCode'])) {
            $model->accountCode = $map['accountCode'];
        }
        if (isset($map['accountName'])) {
            $model->accountName = $map['accountName'];
        }
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
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
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['officialName'])) {
            $model->officialName = $map['officialName'];
        }
        if (isset($map['officialNumber'])) {
            $model->officialNumber = $map['officialNumber'];
        }
        if (isset($map['province'])) {
            $model->province = $map['province'];
        }
        if (isset($map['taxNature'])) {
            $model->taxNature = $map['taxNature'];
        }
        if (isset($map['taxNo'])) {
            $model->taxNo = $map['taxNo'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
