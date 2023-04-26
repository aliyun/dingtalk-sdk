<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryReceiptsBaseInfoRequest extends Model
{
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
        'endTime'         => 'endTime',
        'pageNumber'      => 'pageNumber',
        'pageSize'        => 'pageSize',
        'startTime'       => 'startTime',
        'timeFilterField' => 'timeFilterField',
        'title'           => 'title',
        'voucherStatus'   => 'voucherStatus',
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
