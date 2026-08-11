<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result;

use AlibabaCloud\Tea\Model;

class companyInfo extends Model
{
    /**
     * @var string
     */
    public $bankAccountName;

    /**
     * @var string
     */
    public $bankAccountNumber;

    /**
     * @var string
     */
    public $bankName;

    /**
     * @var string
     */
    public $companyName;

    /**
     * @var string
     */
    public $creditCode;

    /**
     * @var string
     */
    public $legalPersonName;

    /**
     * @var string
     */
    public $phoneNumber;

    /**
     * @var string
     */
    public $regLocation;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $taxNumber;
    protected $_name = [
        'bankAccountName' => 'bankAccountName',
        'bankAccountNumber' => 'bankAccountNumber',
        'bankName' => 'bankName',
        'companyName' => 'companyName',
        'creditCode' => 'creditCode',
        'legalPersonName' => 'legalPersonName',
        'phoneNumber' => 'phoneNumber',
        'regLocation' => 'regLocation',
        'remark' => 'remark',
        'taxNumber' => 'taxNumber',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bankAccountName) {
            $res['bankAccountName'] = $this->bankAccountName;
        }
        if (null !== $this->bankAccountNumber) {
            $res['bankAccountNumber'] = $this->bankAccountNumber;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }
        if (null !== $this->companyName) {
            $res['companyName'] = $this->companyName;
        }
        if (null !== $this->creditCode) {
            $res['creditCode'] = $this->creditCode;
        }
        if (null !== $this->legalPersonName) {
            $res['legalPersonName'] = $this->legalPersonName;
        }
        if (null !== $this->phoneNumber) {
            $res['phoneNumber'] = $this->phoneNumber;
        }
        if (null !== $this->regLocation) {
            $res['regLocation'] = $this->regLocation;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->taxNumber) {
            $res['taxNumber'] = $this->taxNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return companyInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bankAccountName'])) {
            $model->bankAccountName = $map['bankAccountName'];
        }
        if (isset($map['bankAccountNumber'])) {
            $model->bankAccountNumber = $map['bankAccountNumber'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }
        if (isset($map['companyName'])) {
            $model->companyName = $map['companyName'];
        }
        if (isset($map['creditCode'])) {
            $model->creditCode = $map['creditCode'];
        }
        if (isset($map['legalPersonName'])) {
            $model->legalPersonName = $map['legalPersonName'];
        }
        if (isset($map['phoneNumber'])) {
            $model->phoneNumber = $map['phoneNumber'];
        }
        if (isset($map['regLocation'])) {
            $model->regLocation = $map['regLocation'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['taxNumber'])) {
            $model->taxNumber = $map['taxNumber'];
        }

        return $model;
    }
}
