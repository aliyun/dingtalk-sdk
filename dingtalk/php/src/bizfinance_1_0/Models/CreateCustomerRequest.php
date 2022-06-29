<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCustomerRequest extends Model
{
    /**
     * @description 创建人userId
     *
     * @var string
     */
    public $creator;

    /**
     * @description 客户描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 客户名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 购方账户
     *
     * @var string
     */
    public $purchaserAccount;

    /**
     * @description 购房地址
     *
     * @var string
     */
    public $purchaserAddress;

    /**
     * @description 购方银行
     *
     * @var string
     */
    public $purchaserBankName;

    /**
     * @description 购方名字
     *
     * @var string
     */
    public $purchaserName;

    /**
     * @description 购方税号
     *
     * @var string
     */
    public $purchaserTaxNo;

    /**
     * @description 购方电话
     *
     * @var string
     */
    public $purchaserTel;
    protected $_name = [
        'creator'           => 'creator',
        'description'       => 'description',
        'name'              => 'name',
        'purchaserAccount'  => 'purchaserAccount',
        'purchaserAddress'  => 'purchaserAddress',
        'purchaserBankName' => 'purchaserBankName',
        'purchaserName'     => 'purchaserName',
        'purchaserTaxNo'    => 'purchaserTaxNo',
        'purchaserTel'      => 'purchaserTel',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
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
     * @return CreateCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
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
