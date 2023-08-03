<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageRequest;

use AlibabaCloud\Tea\Model;

class request extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $accountantBookId;

    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @example abc
     *
     * @var int
     */
    public $endTime;

    /**
     * @example abc
     *
     * @var string
     */
    public $financeType;

    /**
     * @example 2
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 2022-07-11
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 1111111111
     *
     * @var string
     */
    public $taxNo;

    /**
     * @example ABC
     *
     * @var string
     */
    public $verifyStatus;
    protected $_name = [
        'accountantBookId' => 'accountantBookId',
        'companyCode'      => 'companyCode',
        'endTime'          => 'endTime',
        'financeType'      => 'financeType',
        'pageNumber'       => 'pageNumber',
        'pageSize'         => 'pageSize',
        'startTime'        => 'startTime',
        'taxNo'            => 'taxNo',
        'verifyStatus'     => 'verifyStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountantBookId) {
            $res['accountantBookId'] = $this->accountantBookId;
        }
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->financeType) {
            $res['financeType'] = $this->financeType;
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
     * @return request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountantBookId'])) {
            $model->accountantBookId = $map['accountantBookId'];
        }
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['financeType'])) {
            $model->financeType = $map['financeType'];
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
