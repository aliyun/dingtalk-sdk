<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\OrderBillingRequest\additionInfos;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\OrderBillingRequest\products;
use AlibabaCloud\Tea\Model;

class OrderBillingRequest extends Model
{
    /**
     * @var additionInfos[]
     */
    public $additionInfos;

    /**
     * @example abc
     *
     * @var string
     */
    public $appKey;

    /**
     * @var string
     */
    public $applyPerson;

    /**
     * @var string
     */
    public $invoiceRemark;

    /**
     * @example VAT_NORMAL_E
     *
     * @var string
     */
    public $invoiceType;

    /**
     * @var bool
     */
    public $isNaturalPerson;

    /**
     * @var string
     */
    public $operator;

    /**
     * @example abc
     *
     * @var string
     */
    public $orderId;

    /**
     * @var string
     */
    public $payee;

    /**
     * @var string
     */
    public $phone;

    /**
     * @var products[]
     */
    public $products;

    /**
     * @example 浙江省杭州市XXX街道
     *
     * @var string
     */
    public $purchaserAddress;

    /**
     * @var string
     */
    public $purchaserBankAccount;

    /**
     * @var string
     */
    public $purchaserBankName;

    /**
     * @example XXX公司
     *
     * @var string
     */
    public $purchaserName;

    /**
     * @var string
     */
    public $purchaserTaxNo;

    /**
     * @var string
     */
    public $purchaserTel;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $reviewer;

    /**
     * @var string
     */
    public $signature;

    /**
     * @var int
     */
    public $taxSign;
    protected $_name = [
        'additionInfos'        => 'additionInfos',
        'appKey'               => 'appKey',
        'applyPerson'          => 'applyPerson',
        'invoiceRemark'        => 'invoiceRemark',
        'invoiceType'          => 'invoiceType',
        'isNaturalPerson'      => 'isNaturalPerson',
        'operator'             => 'operator',
        'orderId'              => 'orderId',
        'payee'                => 'payee',
        'phone'                => 'phone',
        'products'             => 'products',
        'purchaserAddress'     => 'purchaserAddress',
        'purchaserBankAccount' => 'purchaserBankAccount',
        'purchaserBankName'    => 'purchaserBankName',
        'purchaserName'        => 'purchaserName',
        'purchaserTaxNo'       => 'purchaserTaxNo',
        'purchaserTel'         => 'purchaserTel',
        'remark'               => 'remark',
        'reviewer'             => 'reviewer',
        'signature'            => 'signature',
        'taxSign'              => 'taxSign',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->additionInfos) {
            $res['additionInfos'] = [];
            if (null !== $this->additionInfos && \is_array($this->additionInfos)) {
                $n = 0;
                foreach ($this->additionInfos as $item) {
                    $res['additionInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->applyPerson) {
            $res['applyPerson'] = $this->applyPerson;
        }
        if (null !== $this->invoiceRemark) {
            $res['invoiceRemark'] = $this->invoiceRemark;
        }
        if (null !== $this->invoiceType) {
            $res['invoiceType'] = $this->invoiceType;
        }
        if (null !== $this->isNaturalPerson) {
            $res['isNaturalPerson'] = $this->isNaturalPerson;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->payee) {
            $res['payee'] = $this->payee;
        }
        if (null !== $this->phone) {
            $res['phone'] = $this->phone;
        }
        if (null !== $this->products) {
            $res['products'] = [];
            if (null !== $this->products && \is_array($this->products)) {
                $n = 0;
                foreach ($this->products as $item) {
                    $res['products'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->purchaserAddress) {
            $res['purchaserAddress'] = $this->purchaserAddress;
        }
        if (null !== $this->purchaserBankAccount) {
            $res['purchaserBankAccount'] = $this->purchaserBankAccount;
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
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->reviewer) {
            $res['reviewer'] = $this->reviewer;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
        }
        if (null !== $this->taxSign) {
            $res['taxSign'] = $this->taxSign;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrderBillingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['additionInfos'])) {
            if (!empty($map['additionInfos'])) {
                $model->additionInfos = [];
                $n                    = 0;
                foreach ($map['additionInfos'] as $item) {
                    $model->additionInfos[$n++] = null !== $item ? additionInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['applyPerson'])) {
            $model->applyPerson = $map['applyPerson'];
        }
        if (isset($map['invoiceRemark'])) {
            $model->invoiceRemark = $map['invoiceRemark'];
        }
        if (isset($map['invoiceType'])) {
            $model->invoiceType = $map['invoiceType'];
        }
        if (isset($map['isNaturalPerson'])) {
            $model->isNaturalPerson = $map['isNaturalPerson'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['payee'])) {
            $model->payee = $map['payee'];
        }
        if (isset($map['phone'])) {
            $model->phone = $map['phone'];
        }
        if (isset($map['products'])) {
            if (!empty($map['products'])) {
                $model->products = [];
                $n               = 0;
                foreach ($map['products'] as $item) {
                    $model->products[$n++] = null !== $item ? products::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['purchaserAddress'])) {
            $model->purchaserAddress = $map['purchaserAddress'];
        }
        if (isset($map['purchaserBankAccount'])) {
            $model->purchaserBankAccount = $map['purchaserBankAccount'];
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
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['reviewer'])) {
            $model->reviewer = $map['reviewer'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }
        if (isset($map['taxSign'])) {
            $model->taxSign = $map['taxSign'];
        }

        return $model;
    }
}
