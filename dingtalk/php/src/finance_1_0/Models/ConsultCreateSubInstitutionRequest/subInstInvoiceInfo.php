<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\subInstInvoiceInfo\mailAddress;
use AlibabaCloud\Tea\Model;

class subInstInvoiceInfo extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $acceptElectronic;

    /**
     * @example 浙江省杭州市西湖区西溪路蚂蚁金服
     *
     * @var string
     */
    public $address;

    /**
     * @example false
     *
     * @var bool
     */
    public $autoInvoice;

    /**
     * @example 1234567812345678123
     *
     * @var string
     */
    public $bankAccount;

    /**
     * @example 中国银行
     *
     * @var string
     */
    public $bankName;

    /**
     * @var mailAddress
     */
    public $mailAddress;

    /**
     * @example 张三
     *
     * @var string
     */
    public $mailName;

    /**
     * @example 057162288888
     *
     * @var string
     */
    public $mailPhone;

    /**
     * @example 51010482542598631219
     *
     * @var string
     */
    public $taxNo;

    /**
     * @example 01
     *
     * @var string
     */
    public $taxPayerQualification;

    /**
     * @example 19981011
     *
     * @var string
     */
    public $taxPayerValidDate;

    /**
     * @example 057162288888
     *
     * @var string
     */
    public $telephone;

    /**
     * @example **有限公司
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'acceptElectronic'      => 'acceptElectronic',
        'address'               => 'address',
        'autoInvoice'           => 'autoInvoice',
        'bankAccount'           => 'bankAccount',
        'bankName'              => 'bankName',
        'mailAddress'           => 'mailAddress',
        'mailName'              => 'mailName',
        'mailPhone'             => 'mailPhone',
        'taxNo'                 => 'taxNo',
        'taxPayerQualification' => 'taxPayerQualification',
        'taxPayerValidDate'     => 'taxPayerValidDate',
        'telephone'             => 'telephone',
        'title'                 => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->acceptElectronic) {
            $res['acceptElectronic'] = $this->acceptElectronic;
        }
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->autoInvoice) {
            $res['autoInvoice'] = $this->autoInvoice;
        }
        if (null !== $this->bankAccount) {
            $res['bankAccount'] = $this->bankAccount;
        }
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }
        if (null !== $this->mailAddress) {
            $res['mailAddress'] = null !== $this->mailAddress ? $this->mailAddress->toMap() : null;
        }
        if (null !== $this->mailName) {
            $res['mailName'] = $this->mailName;
        }
        if (null !== $this->mailPhone) {
            $res['mailPhone'] = $this->mailPhone;
        }
        if (null !== $this->taxNo) {
            $res['taxNo'] = $this->taxNo;
        }
        if (null !== $this->taxPayerQualification) {
            $res['taxPayerQualification'] = $this->taxPayerQualification;
        }
        if (null !== $this->taxPayerValidDate) {
            $res['taxPayerValidDate'] = $this->taxPayerValidDate;
        }
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subInstInvoiceInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['acceptElectronic'])) {
            $model->acceptElectronic = $map['acceptElectronic'];
        }
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['autoInvoice'])) {
            $model->autoInvoice = $map['autoInvoice'];
        }
        if (isset($map['bankAccount'])) {
            $model->bankAccount = $map['bankAccount'];
        }
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }
        if (isset($map['mailAddress'])) {
            $model->mailAddress = mailAddress::fromMap($map['mailAddress']);
        }
        if (isset($map['mailName'])) {
            $model->mailName = $map['mailName'];
        }
        if (isset($map['mailPhone'])) {
            $model->mailPhone = $map['mailPhone'];
        }
        if (isset($map['taxNo'])) {
            $model->taxNo = $map['taxNo'];
        }
        if (isset($map['taxPayerQualification'])) {
            $model->taxPayerQualification = $map['taxPayerQualification'];
        }
        if (isset($map['taxPayerValidDate'])) {
            $model->taxPayerValidDate = $map['taxPayerValidDate'];
        }
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
