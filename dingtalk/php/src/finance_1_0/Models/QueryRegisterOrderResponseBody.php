<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryRegisterOrderResponseBody extends Model
{
    /**
     * @description 主机构编号
     *
     * @var string
     */
    public $instId;

    /**
     * @description 子机构编号
     *
     * @var string
     */
    public $subInstId;

    /**
     * @description 外部流水号
     *
     * @var string
     */
    public $outTradeNo;

    /**
     * @description 申请单号
     *
     * @var string
     */
    public $orderId;

    /**
     * @description 子机构名称
     *
     * @var string
     */
    public $subInstName;

    /**
     * @description 申请单状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 审核时间
     *
     * @var string
     */
    public $gmtAudit;

    /**
     * @description 失败原因
     *
     * @var string
     */
    public $failReason;
    protected $_name = [
        'instId'      => 'instId',
        'subInstId'   => 'subInstId',
        'outTradeNo'  => 'outTradeNo',
        'orderId'     => 'orderId',
        'subInstName' => 'subInstName',
        'status'      => 'status',
        'gmtAudit'    => 'gmtAudit',
        'failReason'  => 'failReason',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->outTradeNo) {
            $res['outTradeNo'] = $this->outTradeNo;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->subInstName) {
            $res['subInstName'] = $this->subInstName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->gmtAudit) {
            $res['gmtAudit'] = $this->gmtAudit;
        }
        if (null !== $this->failReason) {
            $res['failReason'] = $this->failReason;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRegisterOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['outTradeNo'])) {
            $model->outTradeNo = $map['outTradeNo'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['subInstName'])) {
            $model->subInstName = $map['subInstName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['gmtAudit'])) {
            $model->gmtAudit = $map['gmtAudit'];
        }
        if (isset($map['failReason'])) {
            $model->failReason = $map['failReason'];
        }

        return $model;
    }
}