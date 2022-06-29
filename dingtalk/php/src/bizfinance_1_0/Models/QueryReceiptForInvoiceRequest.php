<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceRequest\invoiceFilter;
use AlibabaCloud\Tea\Model;

class QueryReceiptForInvoiceRequest extends Model
{
    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 发票筛选条件
     *
     * @var invoiceFilter
     */
    public $invoiceFilter;

    /**
     * @description 分页参数，从1 开始
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页参数，每页查询个数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 单据状态，审批中 RUNNING，已完成 COMPLETED
     *
     * @var string
     */
    public $receiptStatus;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 单据标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'endTime'       => 'endTime',
        'invoiceFilter' => 'invoiceFilter',
        'pageNumber'    => 'pageNumber',
        'pageSize'      => 'pageSize',
        'receiptStatus' => 'receiptStatus',
        'startTime'     => 'startTime',
        'title'         => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->invoiceFilter) {
            $res['invoiceFilter'] = null !== $this->invoiceFilter ? $this->invoiceFilter->toMap() : null;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->receiptStatus) {
            $res['receiptStatus'] = $this->receiptStatus;
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
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['invoiceFilter'])) {
            $model->invoiceFilter = invoiceFilter::fromMap($map['invoiceFilter']);
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['receiptStatus'])) {
            $model->receiptStatus = $map['receiptStatus'];
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
