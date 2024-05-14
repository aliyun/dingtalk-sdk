<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryBatchTradeDetailListResponseBody;

use AlibabaCloud\Tea\Model;

class batchTradeDetailList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1.00
     *
     * @var string
     */
    public $amount;

    /**
     * @description This parameter is required.
     *
     * @example 20210909153300000002734746770740
     *
     * @var string
     */
    public $detailNo;

    /**
     * @description This parameter is required.
     *
     * @example 2021-09-29 14:46:48
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description This parameter is required.
     *
     * @example 2021-09-29 16:05:00
     *
     * @var string
     */
    public $gmtFinish;

    /**
     * @description This parameter is required.
     *
     * @example 测试
     *
     * @var string
     */
    public $memo;

    /**
     * @description This parameter is required.
     *
     * @example 收款人
     *
     * @var string
     */
    public $payeeAccountName;

    /**
     * @description This parameter is required.
     *
     * @example 13900000000
     *
     * @var string
     */
    public $payeeAccountNo;

    /**
     * @description This parameter is required.
     *
     * @example ALIPAY
     *
     * @var string
     */
    public $payeeAccountType;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $serialNo;

    /**
     * @description This parameter is required.
     *
     * @example SUCCESS
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'amount'           => 'amount',
        'detailNo'         => 'detailNo',
        'gmtCreate'        => 'gmtCreate',
        'gmtFinish'        => 'gmtFinish',
        'memo'             => 'memo',
        'payeeAccountName' => 'payeeAccountName',
        'payeeAccountNo'   => 'payeeAccountNo',
        'payeeAccountType' => 'payeeAccountType',
        'serialNo'         => 'serialNo',
        'status'           => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->detailNo) {
            $res['detailNo'] = $this->detailNo;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtFinish) {
            $res['gmtFinish'] = $this->gmtFinish;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->payeeAccountName) {
            $res['payeeAccountName'] = $this->payeeAccountName;
        }
        if (null !== $this->payeeAccountNo) {
            $res['payeeAccountNo'] = $this->payeeAccountNo;
        }
        if (null !== $this->payeeAccountType) {
            $res['payeeAccountType'] = $this->payeeAccountType;
        }
        if (null !== $this->serialNo) {
            $res['serialNo'] = $this->serialNo;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return batchTradeDetailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['detailNo'])) {
            $model->detailNo = $map['detailNo'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtFinish'])) {
            $model->gmtFinish = $map['gmtFinish'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['payeeAccountName'])) {
            $model->payeeAccountName = $map['payeeAccountName'];
        }
        if (isset($map['payeeAccountNo'])) {
            $model->payeeAccountNo = $map['payeeAccountNo'];
        }
        if (isset($map['payeeAccountType'])) {
            $model->payeeAccountType = $map['payeeAccountType'];
        }
        if (isset($map['serialNo'])) {
            $model->serialNo = $map['serialNo'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
