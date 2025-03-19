<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerRequest;

use AlibabaCloud\Tea\Model;

class createCustomerRequestList extends Model
{
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
     * @example 1234567890
     *
     * @var string
     */
    public $drawerTelephone;

    /**
     * @description This parameter is required.
     *
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
     * @example 建行
     *
     * @var string
     */
    public $purchaserBankName;

    /**
     * @example 李四
     *
     * @var string
     */
    public $purchaserName;

    /**
     * @example 1333
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
    protected $_name = [
        'description' => 'description',
        'drawerEmail' => 'drawerEmail',
        'drawerTelephone' => 'drawerTelephone',
        'name' => 'name',
        'purchaserAccount' => 'purchaserAccount',
        'purchaserAddress' => 'purchaserAddress',
        'purchaserBankName' => 'purchaserBankName',
        'purchaserName' => 'purchaserName',
        'purchaserTaxNo' => 'purchaserTaxNo',
        'purchaserTel' => 'purchaserTel',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->purchaserBankName) {
            $res['purchaserBankName'] = $this->purchaserBankName;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return createCustomerRequestList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['purchaserBankName'])) {
            $model->purchaserBankName = $map['purchaserBankName'];
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

        return $model;
    }
}
