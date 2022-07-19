<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageRequest;

use AlibabaCloud\Tea\Model;

class request extends Model
{
    /**
     * @description 结束时间
     *
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 进项票/销项票
     *
     * @var string
     */
    public $financeType;

    /**
     * @description 分页参数
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页参数
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
     * @description 税号
     *
     * @var string
     */
    public $taxNo;

    /**
     * @description 认证状态
     *
     * @var string
     */
    public $verifyStatus;
    protected $_name = [
        'endTime'      => 'endTime',
        'financeType'  => 'financeType',
        'pageNumber'   => 'pageNumber',
        'pageSize'     => 'pageSize',
        'startTime'    => 'startTime',
        'taxNo'        => 'taxNo',
        'verifyStatus' => 'verifyStatus',
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
