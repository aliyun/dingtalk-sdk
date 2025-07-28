<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryReceiptForInvoiceRequest extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $accountantBookId;

    /**
     * @var string[]
     */
    public $applyStatusList;

    /**
     * @var string[]
     */
    public $bizStatusList;

    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var int
     */
    public $pageNumber;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var string[]
     */
    public $receiptStatusList;

    /**
     * @var string[]
     */
    public $searchParams;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'accountantBookId' => 'accountantBookId',
        'applyStatusList' => 'applyStatusList',
        'bizStatusList' => 'bizStatusList',
        'companyCode' => 'companyCode',
        'endTime' => 'endTime',
        'pageNumber' => 'pageNumber',
        'pageSize' => 'pageSize',
        'receiptStatusList' => 'receiptStatusList',
        'searchParams' => 'searchParams',
        'startTime' => 'startTime',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountantBookId) {
            $res['accountantBookId'] = $this->accountantBookId;
        }
        if (null !== $this->applyStatusList) {
            $res['applyStatusList'] = $this->applyStatusList;
        }
        if (null !== $this->bizStatusList) {
            $res['bizStatusList'] = $this->bizStatusList;
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
        if (null !== $this->receiptStatusList) {
            $res['receiptStatusList'] = $this->receiptStatusList;
        }
        if (null !== $this->searchParams) {
            $res['searchParams'] = $this->searchParams;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryReceiptForInvoiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountantBookId'])) {
            $model->accountantBookId = $map['accountantBookId'];
        }
        if (isset($map['applyStatusList'])) {
            if (!empty($map['applyStatusList'])) {
                $model->applyStatusList = $map['applyStatusList'];
            }
        }
        if (isset($map['bizStatusList'])) {
            if (!empty($map['bizStatusList'])) {
                $model->bizStatusList = $map['bizStatusList'];
            }
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
        if (isset($map['receiptStatusList'])) {
            if (!empty($map['receiptStatusList'])) {
                $model->receiptStatusList = $map['receiptStatusList'];
            }
        }
        if (isset($map['searchParams'])) {
            $model->searchParams = $map['searchParams'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
