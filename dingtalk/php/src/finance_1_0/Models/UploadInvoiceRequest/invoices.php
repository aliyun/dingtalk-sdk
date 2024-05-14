<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceRequest;

use AlibabaCloud\Tea\Model;

class invoices extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 100.00
     *
     * @var string
     */
    public $invoiceAmount;

    /**
     * @description This parameter is required.
     *
     * @example 033002000712
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @description This parameter is required.
     *
     * @example 2022-02-21
     *
     * @var string
     */
    public $invoiceDate;

    /**
     * @description This parameter is required.
     *
     * @example 20532643
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $invoiceType;

    /**
     * @var string
     */
    public $logoUrl;

    /**
     * @description This parameter is required.
     *
     * @example 小钉科技有限公司
     *
     * @var string
     */
    public $payeeName;

    /**
     * @description This parameter is required.
     *
     * @example 91330100MA28XNB274
     *
     * @var string
     */
    public $payeeTaxNo;

    /**
     * @description This parameter is required.
     *
     * @example 小钉科技有限公司
     *
     * @var string
     */
    public $payerName;

    /**
     * @example 91330100MA28XNB274
     *
     * @var string
     */
    public $payerTaxNo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $pdfUrl;

    /**
     * @example 0.50
     *
     * @var string
     */
    public $taxAmount;

    /**
     * @example 增值税普通发票必填，示例：52501101414266612380
     *
     * @var string
     */
    public $verifyCode;

    /**
     * @example 99.50
     *
     * @var string
     */
    public $withoutTaxAmount;
    protected $_name = [
        'invoiceAmount'    => 'invoiceAmount',
        'invoiceCode'      => 'invoiceCode',
        'invoiceDate'      => 'invoiceDate',
        'invoiceNo'        => 'invoiceNo',
        'invoiceType'      => 'invoiceType',
        'logoUrl'          => 'logoUrl',
        'payeeName'        => 'payeeName',
        'payeeTaxNo'       => 'payeeTaxNo',
        'payerName'        => 'payerName',
        'payerTaxNo'       => 'payerTaxNo',
        'pdfUrl'           => 'pdfUrl',
        'taxAmount'        => 'taxAmount',
        'verifyCode'       => 'verifyCode',
        'withoutTaxAmount' => 'withoutTaxAmount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->invoiceAmount) {
            $res['invoiceAmount'] = $this->invoiceAmount;
        }
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceDate) {
            $res['invoiceDate'] = $this->invoiceDate;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->invoiceType) {
            $res['invoiceType'] = $this->invoiceType;
        }
        if (null !== $this->logoUrl) {
            $res['logoUrl'] = $this->logoUrl;
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
        if (null !== $this->pdfUrl) {
            $res['pdfUrl'] = $this->pdfUrl;
        }
        if (null !== $this->taxAmount) {
            $res['taxAmount'] = $this->taxAmount;
        }
        if (null !== $this->verifyCode) {
            $res['verifyCode'] = $this->verifyCode;
        }
        if (null !== $this->withoutTaxAmount) {
            $res['withoutTaxAmount'] = $this->withoutTaxAmount;
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
        if (isset($map['invoiceAmount'])) {
            $model->invoiceAmount = $map['invoiceAmount'];
        }
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceDate'])) {
            $model->invoiceDate = $map['invoiceDate'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['invoiceType'])) {
            $model->invoiceType = $map['invoiceType'];
        }
        if (isset($map['logoUrl'])) {
            $model->logoUrl = $map['logoUrl'];
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
        if (isset($map['pdfUrl'])) {
            $model->pdfUrl = $map['pdfUrl'];
        }
        if (isset($map['taxAmount'])) {
            $model->taxAmount = $map['taxAmount'];
        }
        if (isset($map['verifyCode'])) {
            $model->verifyCode = $map['verifyCode'];
        }
        if (isset($map['withoutTaxAmount'])) {
            $model->withoutTaxAmount = $map['withoutTaxAmount'];
        }

        return $model;
    }
}
