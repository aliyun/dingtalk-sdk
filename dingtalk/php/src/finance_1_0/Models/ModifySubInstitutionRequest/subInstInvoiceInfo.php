<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest;

use AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\subInstInvoiceInfo\mailAddress;
use AlibabaCloud\Tea\Model;

class subInstInvoiceInfo extends Model
{
    /**
     * @description 是否接受电票
     *
     * @var bool
     */
    public $acceptElectronic;

    /**
     * @description 开票地址
     *
     * @var string
     */
    public $address;

    /**
     * @description 是否自动开票
     *
     * @var bool
     */
    public $autoInvoice;

    /**
     * @description 银行账户
     *
     * @var string
     */
    public $bankAccount;

    /**
     * @description 银行名称
     *
     * @var string
     */
    public $bankName;

    /**
     * @description 收件地址
     *
     * @var mailAddress
     */
    public $mailAddress;

    /**
     * @description 收件人名称
     *
     * @var string
     */
    public $mailName;

    /**
     * @description 收件人号码
     *
     * @var string
     */
    public $mailPhone;

    /**
     * @description 纳税人识别号
     *
     * @var string
     */
    public $taxNo;

    /**
     * @description 纳税人资质
     *
     * @var string
     */
    public $taxPayerQualification;

    /**
     * @description 纳税人资格开始时间
     *
     * @var string
     */
    public $taxPayerValidDate;

    /**
     * @description 开票电话
     *
     * @var string
     */
    public $telephone;

    /**
     * @description 纳税人抬头
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
