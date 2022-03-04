<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceByAuthRequest;

use AlibabaCloud\Tea\Model;

class invoices extends Model
{
    /**
     * @description 发票代码
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @description 发票号码
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @description 发票类型
     *
     * @var string
     */
    public $invoiceType;

    /**
     * @description 开票时间
     *
     * @var string
     */
    public $invoiceDate;

    /**
     * @description 收款方名称
     *
     * @var string
     */
    public $payeeName;

    /**
     * @description 收款方税号
     *
     * @var string
     */
    public $payeeTaxNo;

    /**
     * @description 付款方名称
     *
     * @var string
     */
    public $payerName;

    /**
     * @description 付款方税号
     *
     * @var string
     */
    public $payerTaxNo;

    /**
     * @description 发票总金额
     *
     * @var string
     */
    public $invoiceAmount;

    /**
     * @description 不含税金额
     *
     * @var string
     */
    public $withoutTaxAmount;

    /**
     * @description 税金额
     *
     * @var string
     */
    public $taxAmount;

    /**
     * @description 发票校验码
     *
     * @var string
     */
    public $verifyCode;

    /**
     * @description 发票pdf原件下载链接
     *
     * @var string
     */
    public $pdfUrl;

    /**
     * @description 发票logo地址
     *
     * @var string
     */
    public $logoUrl;
    protected $_name = [
        'invoiceCode'      => 'invoiceCode',
        'invoiceNo'        => 'invoiceNo',
        'invoiceType'      => 'invoiceType',
        'invoiceDate'      => 'invoiceDate',
        'payeeName'        => 'payeeName',
        'payeeTaxNo'       => 'payeeTaxNo',
        'payerName'        => 'payerName',
        'payerTaxNo'       => 'payerTaxNo',
        'invoiceAmount'    => 'invoiceAmount',
        'withoutTaxAmount' => 'withoutTaxAmount',
        'taxAmount'        => 'taxAmount',
        'verifyCode'       => 'verifyCode',
        'pdfUrl'           => 'pdfUrl',
        'logoUrl'          => 'logoUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->invoiceType) {
            $res['invoiceType'] = $this->invoiceType;
        }
        if (null !== $this->invoiceDate) {
            $res['invoiceDate'] = $this->invoiceDate;
        }
        if (null !== $this->payeeName) {
            $res['payeeName'] = $this->payeeName;
        }
        if (null !== $this->payeeTaxNo) {
            $res['payeeTaxNo'] = $this->payeeTaxNo;
        }
        if (null !== $this->payerName) {
            $res['payerName'] = $this->payerName;
        }
        if (null !== $this->payerTaxNo) {
            $res['payerTaxNo'] = $this->payerTaxNo;
        }
        if (null !== $this->invoiceAmount) {
            $res['invoiceAmount'] = $this->invoiceAmount;
        }
        if (null !== $this->withoutTaxAmount) {
            $res['withoutTaxAmount'] = $this->withoutTaxAmount;
        }
        if (null !== $this->taxAmount) {
            $res['taxAmount'] = $this->taxAmount;
        }
        if (null !== $this->verifyCode) {
            $res['verifyCode'] = $this->verifyCode;
        }
        if (null !== $this->pdfUrl) {
            $res['pdfUrl'] = $this->pdfUrl;
        }
        if (null !== $this->logoUrl) {
            $res['logoUrl'] = $this->logoUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return invoices
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['invoiceType'])) {
            $model->invoiceType = $map['invoiceType'];
        }
        if (isset($map['invoiceDate'])) {
            $model->invoiceDate = $map['invoiceDate'];
        }
        if (isset($map['payeeName'])) {
            $model->payeeName = $map['payeeName'];
        }
        if (isset($map['payeeTaxNo'])) {
            $model->payeeTaxNo = $map['payeeTaxNo'];
        }
        if (isset($map['payerName'])) {
            $model->payerName = $map['payerName'];
        }
        if (isset($map['payerTaxNo'])) {
            $model->payerTaxNo = $map['payerTaxNo'];
        }
        if (isset($map['invoiceAmount'])) {
            $model->invoiceAmount = $map['invoiceAmount'];
        }
        if (isset($map['withoutTaxAmount'])) {
            $model->withoutTaxAmount = $map['withoutTaxAmount'];
        }
        if (isset($map['taxAmount'])) {
            $model->taxAmount = $map['taxAmount'];
        }
        if (isset($map['verifyCode'])) {
            $model->verifyCode = $map['verifyCode'];
        }
        if (isset($map['pdfUrl'])) {
            $model->pdfUrl = $map['pdfUrl'];
        }
        if (isset($map['logoUrl'])) {
            $model->logoUrl = $map['logoUrl'];
        }

        return $model;
    }
}
