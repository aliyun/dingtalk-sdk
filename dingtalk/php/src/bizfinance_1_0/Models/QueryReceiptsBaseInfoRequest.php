<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryReceiptsBaseInfoRequest extends Model
{
    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTime;

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
     * @description 开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 时间筛选条件 gmt_create / record_time
     *
     * @var string
     */
    public $timeFilterField;

    /**
     * @description 单据标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 凭证状态
     *
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
