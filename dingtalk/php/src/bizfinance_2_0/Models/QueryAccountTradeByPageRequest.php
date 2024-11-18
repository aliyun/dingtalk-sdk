<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryAccountTradeByPageRequest\filter;
use AlibabaCloud\Tea\Model;

class QueryAccountTradeByPageRequest extends Model
{
    /**
     * @example ACC_XXXXX
     *
     * @var string
     */
    public $accountId;

    /**
     * @example 1730778990150
     *
     * @var int
     */
    public $endDate;

    /**
     * @var filter
     */
    public $filter;

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
     * @example 1730778990150
     *
     * @var int
     */
    public $startDate;

    /**
     * @example 50423414443123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'accountId'  => 'accountId',
        'endDate'    => 'endDate',
        'filter'     => 'filter',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'startDate'  => 'startDate',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->filter) {
            $res['filter'] = null !== $this->filter ? $this->filter->toMap() : null;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAccountTradeByPageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['filter'])) {
            $model->filter = filter::fromMap($map['filter']);
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
