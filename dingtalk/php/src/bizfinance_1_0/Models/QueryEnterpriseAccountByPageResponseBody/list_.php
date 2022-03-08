<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryEnterpriseAccountByPageResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 账户code
     *
     * @var string
     */
    public $accountCode;

    /**
     * @description 关联资金账号id
     *
     * @var string
     */
    public $accountId;

    /**
     * @description 账户名称
     *
     * @var string
     */
    public $accountName;

    /**
     * @description 备注
     *
     * @var string
     */
    public $accountRemark;

    /**
     * @description 账户类型:ALIPAY, BANKCARD, CASH, WECHAT
     *
     * @var string
     */
    public $accountType;

    /**
     * @description 账户总额，保留2位小数
     *
     * @var string
     */
    public $amount;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 创建人工号
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
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }

        return $model;
    }
}
