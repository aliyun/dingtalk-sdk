<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\IssueInvoiceWithOrderRequest;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\IssueInvoiceWithOrderRequest\content\additionInfo;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\IssueInvoiceWithOrderRequest\content\products;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var additionInfo[]
     */
    public $additionInfo;

    /**
     * @var string
     */
    public $applyPerson;

    /**
     * @var string
     */
    public $bankAccount;

    /**
     * @var string
     */
    public $bankName;

    /**
     * @var string
     */
    public $invoiceRemark;

    /**
     * @var int
     */
    public $invoiceType;

    /**
     * @var string
     */
    public $naturalPerson;

    /**
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
     * @var string
     */
    public $purchaser;

    /**
     * @var string
     */
    public $purchaserAddress;

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
    public $taxnum;
    protected $_name = [
        'additionInfo' => 'additionInfo',
        'applyPerson' => 'applyPerson',
        'bankAccount' => 'bankAccount',
        'bankName' => 'bankName',
        'invoiceRemark' => 'invoiceRemark',
        'invoiceType' => 'invoiceType',
        'naturalPerson' => 'naturalPerson',
        'orderId' => 'orderId',
        'payee' => 'payee',
        'phone' => 'phone',
        'products' => 'products',
        'purchaser' => 'purchaser',
        'purchaserAddress' => 'purchaserAddress',
        'purchaserTel' => 'purchaserTel',
        'remark' => 'remark',
        'reviewer' => 'reviewer',
        'taxnum' => 'taxnum',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->additionInfo) {
            $res['additionInfo'] = [];
            if (null !== $this->additionInfo && \is_array($this->additionInfo)) {
                $n = 0;
                foreach ($this->additionInfo as $item) {
                    $res['additionInfo'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->applyPerson) {
            $res['applyPerson'] = $this->applyPerson;
        }
        if (null !== $this->bankAccount) {
            $res['bankAccount'] = $this->bankAccount;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }
        if (null !== $this->invoiceRemark) {
            $res['invoiceRemark'] = $this->invoiceRemark;
        }
        if (null !== $this->invoiceType) {
            $res['invoiceType'] = $this->invoiceType;
        }
        if (null !== $this->naturalPerson) {
            $res['naturalPerson'] = $this->naturalPerson;
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
        if (null !== $this->purchaser) {
            $res['purchaser'] = $this->purchaser;
        }
        if (null !== $this->purchaserAddress) {
            $res['purchaserAddress'] = $this->purchaserAddress;
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
        if (null !== $this->taxnum) {
            $res['taxnum'] = $this->taxnum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['additionInfo'])) {
            if (!empty($map['additionInfo'])) {
                $model->additionInfo = [];
                $n = 0;
                foreach ($map['additionInfo'] as $item) {
                    $model->additionInfo[$n++] = null !== $item ? additionInfo::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['applyPerson'])) {
            $model->applyPerson = $map['applyPerson'];
        }
        if (isset($map['bankAccount'])) {
            $model->bankAccount = $map['bankAccount'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }
        if (isset($map['invoiceRemark'])) {
            $model->invoiceRemark = $map['invoiceRemark'];
        }
        if (isset($map['invoiceType'])) {
            $model->invoiceType = $map['invoiceType'];
        }
        if (isset($map['naturalPerson'])) {
            $model->naturalPerson = $map['naturalPerson'];
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
                $n = 0;
                foreach ($map['products'] as $item) {
                    $model->products[$n++] = null !== $item ? products::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['purchaser'])) {
            $model->purchaser = $map['purchaser'];
        }
        if (isset($map['purchaserAddress'])) {
            $model->purchaserAddress = $map['purchaserAddress'];
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
        if (isset($map['taxnum'])) {
            $model->taxnum = $map['taxnum'];
        }

        return $model;
    }
}
