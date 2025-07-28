<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryCustomerInfoResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example CUS_xxxxxxxx
     *
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $contactAddress;

    /**
     * @var string
     */
    public $contactCompanyTelephone;

    /**
     * @var string
     */
    public $contactEmail;

    /**
     * @var string
     */
    public $contactName;

    /**
     * @var string
     */
    public $contactTelephone;

    /**
     * @example abc
     *
     * @var string
     */
    public $description;

    /**
     * @example www.abc.com
     *
     * @var string
     */
    public $drawerEmail;

    /**
     * @example 12345678901
     *
     * @var string
     */
    public $drawerTelephone;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example abc
     *
     * @var string
     */
    public $purchaserAccount;

    /**
     * @example 杭州市
     *
     * @var string
     */
    public $purchaserAddress;

    /**
     * @example abc
     *
     * @var string
     */
    public $purchaserName;

    /**
     * @example 123
     *
     * @var string
     */
    public $purchaserTaxNo;

    /**
     * @example 13333333333
     *
     * @var string
     */
    public $purchaserTel;

    /**
     * @example 建行
     *
     * @var string
     */
    public $purchaserrBankName;

    /**
     * @example valid
     *
     * @var string
     */
    public $status;

    /**
     * @example 199200
     *
     * @var string
     */
    public $userDefineCode;
    protected $_name = [
        'code' => 'code',
        'contactAddress' => 'contactAddress',
        'contactCompanyTelephone' => 'contactCompanyTelephone',
        'contactEmail' => 'contactEmail',
        'contactName' => 'contactName',
        'contactTelephone' => 'contactTelephone',
        'description' => 'description',
        'drawerEmail' => 'drawerEmail',
        'drawerTelephone' => 'drawerTelephone',
        'name' => 'name',
        'purchaserAccount' => 'purchaserAccount',
        'purchaserAddress' => 'purchaserAddress',
        'purchaserName' => 'purchaserName',
        'purchaserTaxNo' => 'purchaserTaxNo',
        'purchaserTel' => 'purchaserTel',
        'purchaserrBankName' => 'purchaserrBankName',
        'status' => 'status',
        'userDefineCode' => 'userDefineCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->contactAddress) {
            $res['contactAddress'] = $this->contactAddress;
        }
        if (null !== $this->contactCompanyTelephone) {
            $res['contactCompanyTelephone'] = $this->contactCompanyTelephone;
        }
        if (null !== $this->contactEmail) {
            $res['contactEmail'] = $this->contactEmail;
        }
        if (null !== $this->contactName) {
            $res['contactName'] = $this->contactName;
        }
        if (null !== $this->contactTelephone) {
            $res['contactTelephone'] = $this->contactTelephone;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->drawerEmail) {
            $res['drawerEmail'] = $this->drawerEmail;
        }
        if (null !== $this->drawerTelephone) {
            $res['drawerTelephone'] = $this->drawerTelephone;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->purchaserAccount) {
            $res['purchaserAccount'] = $this->purchaserAccount;
        }
        if (null !== $this->purchaserAddress) {
            $res['purchaserAddress'] = $this->purchaserAddress;
        }
        if (null !== $this->purchaserName) {
            $res['purchaserName'] = $this->purchaserName;
        }
        if (null !== $this->purchaserTaxNo) {
            $res['purchaserTaxNo'] = $this->purchaserTaxNo;
        }
        if (null !== $this->purchaserTel) {
            $res['purchaserTel'] = $this->purchaserTel;
        }
        if (null !== $this->purchaserrBankName) {
            $res['purchaserrBankName'] = $this->purchaserrBankName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userDefineCode) {
            $res['userDefineCode'] = $this->userDefineCode;
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
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['contactAddress'])) {
            $model->contactAddress = $map['contactAddress'];
        }
        if (isset($map['contactCompanyTelephone'])) {
            $model->contactCompanyTelephone = $map['contactCompanyTelephone'];
        }
        if (isset($map['contactEmail'])) {
            $model->contactEmail = $map['contactEmail'];
        }
        if (isset($map['contactName'])) {
            $model->contactName = $map['contactName'];
        }
        if (isset($map['contactTelephone'])) {
            $model->contactTelephone = $map['contactTelephone'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['drawerEmail'])) {
            $model->drawerEmail = $map['drawerEmail'];
        }
        if (isset($map['drawerTelephone'])) {
            $model->drawerTelephone = $map['drawerTelephone'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['purchaserAccount'])) {
            $model->purchaserAccount = $map['purchaserAccount'];
        }
        if (isset($map['purchaserAddress'])) {
            $model->purchaserAddress = $map['purchaserAddress'];
        }
        if (isset($map['purchaserName'])) {
            $model->purchaserName = $map['purchaserName'];
        }
        if (isset($map['purchaserTaxNo'])) {
            $model->purchaserTaxNo = $map['purchaserTaxNo'];
        }
        if (isset($map['purchaserTel'])) {
            $model->purchaserTel = $map['purchaserTel'];
        }
        if (isset($map['purchaserrBankName'])) {
            $model->purchaserrBankName = $map['purchaserrBankName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userDefineCode'])) {
            $model->userDefineCode = $map['userDefineCode'];
        }

        return $model;
    }
}
