<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListOrderRequest extends Model
{
    /**
     * @example 1647503420000
     *
     * @var int
     */
    public $createTimeEnd;

    /**
     * @example 1647503420000
     *
     * @var int
     */
    public $createTimeStart;

    /**
     * @example SM123124124
     *
     * @var string
     */
    public $merchantId;

    /**
     * @example 2022312312333
     *
     * @var string
     */
    public $orderNo;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 200
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 1
     *
     * @var int
     */
    public $scene;

    /**
     * @example 20
     *
     * @var int
     */
    public $status;

    /**
     * @example 202221312333
     *
     * @var string
     */
    public $tradeNo;

    /**
     * @example 123123123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'createTimeEnd'   => 'createTimeEnd',
        'createTimeStart' => 'createTimeStart',
        'merchantId'      => 'merchantId',
        'orderNo'         => 'orderNo',
        'pageNumber'      => 'pageNumber',
        'pageSize'        => 'pageSize',
        'scene'           => 'scene',
        'status'          => 'status',
        'tradeNo'         => 'tradeNo',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTimeEnd) {
            $res['createTimeEnd'] = $this->createTimeEnd;
        }
        if (null !== $this->createTimeStart) {
            $res['createTimeStart'] = $this->createTimeStart;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->tradeNo) {
            $res['tradeNo'] = $this->tradeNo;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTimeEnd'])) {
            $model->createTimeEnd = $map['createTimeEnd'];
        }
        if (isset($map['createTimeStart'])) {
            $model->createTimeStart = $map['createTimeStart'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['tradeNo'])) {
            $model->tradeNo = $map['tradeNo'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
