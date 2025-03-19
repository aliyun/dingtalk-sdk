<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class CheckVoucherStatusRequest extends Model
{
    /**
     * @example COM_DEFUALT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @example 1631526550994
     *
     * @var int
     */
    public $endTime;

    /**
     * @example VAT_IN
     *
     * @var string
     */
    public $financeType;

    /**
     * @example 3121234560
     *
     * @var string
     */
    public $invoiceCode;

    /**
     * @example 1234567890
     *
     * @var string
     */
    public $invoiceNo;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 100
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 1631526550994
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 12345678901
     *
     * @var string
     */
    public $taxNo;

    /**
     * @example VERIFIED
     *
     * @var string
     */
    public $verifyStatus;
    protected $_name = [
        'companyCode' => 'companyCode',
        'endTime' => 'endTime',
        'financeType' => 'financeType',
        'invoiceCode' => 'invoiceCode',
        'invoiceNo' => 'invoiceNo',
        'pageNumber' => 'pageNumber',
        'pageSize' => 'pageSize',
        'startTime' => 'startTime',
        'taxNo' => 'taxNo',
        'verifyStatus' => 'verifyStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->financeType) {
            $res['financeType'] = $this->financeType;
        }
        if (null !== $this->invoiceCode) {
            $res['invoiceCode'] = $this->invoiceCode;
        }
        if (null !== $this->invoiceNo) {
            $res['invoiceNo'] = $this->invoiceNo;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->taxNo) {
            $res['taxNo'] = $this->taxNo;
        }
        if (null !== $this->verifyStatus) {
            $res['verifyStatus'] = $this->verifyStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckVoucherStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['financeType'])) {
            $model->financeType = $map['financeType'];
        }
        if (isset($map['invoiceCode'])) {
            $model->invoiceCode = $map['invoiceCode'];
        }
        if (isset($map['invoiceNo'])) {
            $model->invoiceNo = $map['invoiceNo'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['taxNo'])) {
            $model->taxNo = $map['taxNo'];
        }
        if (isset($map['verifyStatus'])) {
            $model->verifyStatus = $map['verifyStatus'];
        }

        return $model;
    }
}
