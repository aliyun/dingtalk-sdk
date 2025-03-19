<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryReceiptsBaseInfoRequest extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $accountantBookId;

    /**
     * @var float
     */
    public $amountEnd;

    /**
     * @var float
     */
    public $amountStart;

    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @example 16000000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 20
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 16000000
     *
     * @var int
     */
    public $startTime;

    /**
     * @var string
     */
    public $timeFilterField;

    /**
     * @example 收款单
     *
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $voucherStatus;
    protected $_name = [
        'accountantBookId' => 'accountantBookId',
        'amountEnd' => 'amountEnd',
        'amountStart' => 'amountStart',
        'companyCode' => 'companyCode',
        'endTime' => 'endTime',
        'pageNumber' => 'pageNumber',
        'pageSize' => 'pageSize',
        'startTime' => 'startTime',
        'timeFilterField' => 'timeFilterField',
        'title' => 'title',
        'voucherStatus' => 'voucherStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountantBookId) {
            $res['accountantBookId'] = $this->accountantBookId;
        }
        if (null !== $this->amountEnd) {
            $res['amountEnd'] = $this->amountEnd;
        }
        if (null !== $this->amountStart) {
            $res['amountStart'] = $this->amountStart;
        }
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
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
        if (null !== $this->timeFilterField) {
            $res['timeFilterField'] = $this->timeFilterField;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->voucherStatus) {
            $res['voucherStatus'] = $this->voucherStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryReceiptsBaseInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountantBookId'])) {
            $model->accountantBookId = $map['accountantBookId'];
        }
        if (isset($map['amountEnd'])) {
            $model->amountEnd = $map['amountEnd'];
        }
        if (isset($map['amountStart'])) {
            $model->amountStart = $map['amountStart'];
        }
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
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
        if (isset($map['timeFilterField'])) {
            $model->timeFilterField = $map['timeFilterField'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['voucherStatus'])) {
            $model->voucherStatus = $map['voucherStatus'];
        }

        return $model;
    }
}
