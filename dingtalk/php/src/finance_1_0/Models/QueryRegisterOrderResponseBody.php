<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryRegisterOrderResponseBody extends Model
{
    /**
     * @var string
     */
    public $failReason;

    /**
     * @var string
     */
    public $gmtAudit;

    /**
     * @var string
     */
    public $instId;

    /**
     * @var string
     */
    public $orderId;

    /**
     * @var string
     */
    public $outTradeNo;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $subInstId;

    /**
     * @var string
     */
    public $subInstName;
    protected $_name = [
        'failReason' => 'failReason',
        'gmtAudit' => 'gmtAudit',
        'instId' => 'instId',
        'orderId' => 'orderId',
        'outTradeNo' => 'outTradeNo',
        'status' => 'status',
        'subInstId' => 'subInstId',
        'subInstName' => 'subInstName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failReason) {
            $res['failReason'] = $this->failReason;
        }
        if (null !== $this->gmtAudit) {
            $res['gmtAudit'] = $this->gmtAudit;
        }
        if (null !== $this->instId) {
            $res['instId'] = $this->instId;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->outTradeNo) {
            $res['outTradeNo'] = $this->outTradeNo;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->subInstId) {
            $res['subInstId'] = $this->subInstId;
        }
        if (null !== $this->subInstName) {
            $res['subInstName'] = $this->subInstName;
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
        if (isset($map['failReason'])) {
            $model->failReason = $map['failReason'];
        }
        if (isset($map['gmtAudit'])) {
            $model->gmtAudit = $map['gmtAudit'];
        }
        if (isset($map['instId'])) {
            $model->instId = $map['instId'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['outTradeNo'])) {
            $model->outTradeNo = $map['outTradeNo'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['subInstId'])) {
            $model->subInstId = $map['subInstId'];
        }
        if (isset($map['subInstName'])) {
            $model->subInstName = $map['subInstName'];
        }

        return $model;
    }
}
