<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest;

use AlibabaCloud\Tea\Model;

class settleInfo extends Model
{
    /**
     * @description 账号类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 账户名称 账号类型银行卡时为卡户名
     *
     * @var string
     */
    public $accountName;

    /**
     * @description 账户账号
     *
     * @var string
     */
    public $accountId;

    /**
     * @description 银行名称
     *
     * @var string
     */
    public $bankName;

    /**
     * @description 支行名称
     *
     * @var string
     */
    public $bankBranchName;

    /**
     * @description 开户行简称缩写
     *
     * @var string
     */
    public $bankShortNameCode;

    /**
     * @description 联行号
     *
     * @var string
     */
    public $bankCode;

    /**
     * @description 开户行所在地 省
     *
     * @var string
     */
    public $bankProvince;

    /**
     * @description 开户行所在地 市
     *
     * @var string
     */
    public $bankCity;

    /**
     * @description 卡类型
     *
     * @var string
     */
    public $accountType;

    /**
     * @description 账户使用类型
     *
     * @var string
     */
    public $usageType;
    protected $_name = [
        'type'              => 'type',
        'accountName'       => 'accountName',
        'accountId'         => 'accountId',
        'bankName'          => 'bankName',
        'bankBranchName'    => 'bankBranchName',
        'bankShortNameCode' => 'bankShortNameCode',
        'bankCode'          => 'bankCode',
        'bankProvince'      => 'bankProvince',
        'bankCity'          => 'bankCity',
        'accountType'       => 'accountType',
        'usageType'         => 'usageType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->accountName) {
            $res['accountName'] = $this->accountName;
        }
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }
        if (null !== $this->bankBranchName) {
            $res['bankBranchName'] = $this->bankBranchName;
        }
        if (null !== $this->bankShortNameCode) {
            $res['bankShortNameCode'] = $this->bankShortNameCode;
        }
        if (null !== $this->bankCode) {
            $res['bankCode'] = $this->bankCode;
        }
        if (null !== $this->bankProvince) {
            $res['bankProvince'] = $this->bankProvince;
        }
        if (null !== $this->bankCity) {
            $res['bankCity'] = $this->bankCity;
        }
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
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
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['accountName'])) {
            $model->accountName = $map['accountName'];
        }
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }
        if (isset($map['bankBranchName'])) {
            $model->bankBranchName = $map['bankBranchName'];
        }
        if (isset($map['bankShortNameCode'])) {
            $model->bankShortNameCode = $map['bankShortNameCode'];
        }
        if (isset($map['bankCode'])) {
            $model->bankCode = $map['bankCode'];
        }
        if (isset($map['bankProvince'])) {
            $model->bankProvince = $map['bankProvince'];
        }
        if (isset($map['bankCity'])) {
            $model->bankCity = $map['bankCity'];
        }
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['usageType'])) {
            $model->usageType = $map['usageType'];
        }

        return $model;
    }
}
