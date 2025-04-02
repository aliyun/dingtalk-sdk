<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryEnterpriseAccountByPageResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 12345
     *
     * @var string
     */
    public $accountCode;

    /**
     * @example test@alipay.com
     *
     * @var string
     */
    public $accountId;

    /**
     * @description This parameter is required.
     *
     * @example 网商银行
     *
     * @var string
     */
    public $accountName;

    /**
     * @example test
     *
     * @var string
     */
    public $accountRemark;

    /**
     * @description This parameter is required.
     *
     * @example ALIPAY
     *
     * @var string
     */
    public $accountType;

    /**
     * @example 10000.33
     *
     * @var string
     */
    public $amount;

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
    public $companyCode;

    /**
     * @description This parameter is required.
     *
     * @example 1631526550994
     *
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @example aaa
     *
     * @var string
     */
    public $creator;

    /**
     * @var string
     */
    public $officialName;

    /**
     * @var string
     */
    public $officialNumber;

    /**
     * @var string
     */
    public $signStatus;

    /**
     * @var bool
     */
    public $supportReceipt;

    /**
     * @var bool
     */
    public $supportTradeDetail;
    protected $_name = [
        'accountCode' => 'accountCode',
        'accountId' => 'accountId',
        'accountName' => 'accountName',
        'accountRemark' => 'accountRemark',
        'accountType' => 'accountType',
        'amount' => 'amount',
        'bankCode' => 'bankCode',
        'bankName' => 'bankName',
        'companyCode' => 'companyCode',
        'createTime' => 'createTime',
        'creator' => 'creator',
        'officialName' => 'officialName',
        'officialNumber' => 'officialNumber',
        'signStatus' => 'signStatus',
        'supportReceipt' => 'supportReceipt',
        'supportTradeDetail' => 'supportTradeDetail',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountCode) {
            $res['accountCode'] = $this->accountCode;
        }
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->accountName) {
            $res['accountName'] = $this->accountName;
        }
        if (null !== $this->accountRemark) {
            $res['accountRemark'] = $this->accountRemark;
        }
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
        }
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->bankCode) {
            $res['bankCode'] = $this->bankCode;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->officialName) {
            $res['officialName'] = $this->officialName;
        }
        if (null !== $this->officialNumber) {
            $res['officialNumber'] = $this->officialNumber;
        }
        if (null !== $this->signStatus) {
            $res['signStatus'] = $this->signStatus;
        }
        if (null !== $this->supportReceipt) {
            $res['supportReceipt'] = $this->supportReceipt;
        }
        if (null !== $this->supportTradeDetail) {
            $res['supportTradeDetail'] = $this->supportTradeDetail;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountCode'])) {
            $model->accountCode = $map['accountCode'];
        }
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['accountName'])) {
            $model->accountName = $map['accountName'];
        }
        if (isset($map['accountRemark'])) {
            $model->accountRemark = $map['accountRemark'];
        }
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['bankCode'])) {
            $model->bankCode = $map['bankCode'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['officialName'])) {
            $model->officialName = $map['officialName'];
        }
        if (isset($map['officialNumber'])) {
            $model->officialNumber = $map['officialNumber'];
        }
        if (isset($map['signStatus'])) {
            $model->signStatus = $map['signStatus'];
        }
        if (isset($map['supportReceipt'])) {
            $model->supportReceipt = $map['supportReceipt'];
        }
        if (isset($map['supportTradeDetail'])) {
            $model->supportTradeDetail = $map['supportTradeDetail'];
        }

        return $model;
    }
}
