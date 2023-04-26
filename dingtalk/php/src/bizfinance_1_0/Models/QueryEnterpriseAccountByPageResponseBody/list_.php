<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryEnterpriseAccountByPageResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
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
     * @example 1631526550994
     *
     * @var int
     */
    public $createTime;

    /**
     * @example aaa
     *
     * @var string
     */
    public $creator;
    protected $_name = [
        'accountCode'   => 'accountCode',
        'accountId'     => 'accountId',
        'accountName'   => 'accountName',
        'accountRemark' => 'accountRemark',
        'accountType'   => 'accountType',
        'amount'        => 'amount',
        'bankCode'      => 'bankCode',
        'bankName'      => 'bankName',
        'createTime'    => 'createTime',
        'creator'       => 'creator',
    ];

    public function validate()
    {
    }

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
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
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
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }

        return $model;
    }
}
