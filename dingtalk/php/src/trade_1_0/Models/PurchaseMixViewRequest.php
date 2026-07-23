<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewRequest\list_;
use AlibabaCloud\Tea\Model;

class PurchaseMixViewRequest extends Model
{
    /**
     * @var string
     */
    public $channelCode;

    /**
     * @var int
     */
    public $combineActivityId;

    /**
     * @var bool
     */
    public $createOrder;

    /**
     * @var list_[]
     */
    public $list;

    /**
     * @var string
     */
    public $memo;

    /**
     * @var string
     */
    public $mergeOrderName;

    /**
     * @var string[]
     */
    public $needModelTypeList;

    /**
     * @var int
     */
    public $objId;

    /**
     * @var int
     */
    public $objType;

    /**
     * @var mixed[]
     */
    public $orderParamMap;

    /**
     * @var string
     */
    public $outerTradeCode;

    /**
     * @var string
     */
    public $outerTradeType;

    /**
     * @var int
     */
    public $planId;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var int
     */
    public $uid;

    /**
     * @var bool
     */
    public $unPay;
    protected $_name = [
        'channelCode' => 'channelCode',
        'combineActivityId' => 'combineActivityId',
        'createOrder' => 'createOrder',
        'list' => 'list',
        'memo' => 'memo',
        'mergeOrderName' => 'mergeOrderName',
        'needModelTypeList' => 'needModelTypeList',
        'objId' => 'objId',
        'objType' => 'objType',
        'orderParamMap' => 'orderParamMap',
        'outerTradeCode' => 'outerTradeCode',
        'outerTradeType' => 'outerTradeType',
        'planId' => 'planId',
        'requestId' => 'requestId',
        'uid' => 'uid',
        'unPay' => 'unPay',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
        }
        if (null !== $this->combineActivityId) {
            $res['combineActivityId'] = $this->combineActivityId;
        }
        if (null !== $this->createOrder) {
            $res['createOrder'] = $this->createOrder;
        }
        if (null !== $this->list) {
            $res['list'] = [];
            if (null !== $this->list && \is_array($this->list)) {
                $n = 0;
                foreach ($this->list as $item) {
                    $res['list'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->mergeOrderName) {
            $res['mergeOrderName'] = $this->mergeOrderName;
        }
        if (null !== $this->needModelTypeList) {
            $res['needModelTypeList'] = $this->needModelTypeList;
        }
        if (null !== $this->objId) {
            $res['objId'] = $this->objId;
        }
        if (null !== $this->objType) {
            $res['objType'] = $this->objType;
        }
        if (null !== $this->orderParamMap) {
            $res['orderParamMap'] = $this->orderParamMap;
        }
        if (null !== $this->outerTradeCode) {
            $res['outerTradeCode'] = $this->outerTradeCode;
        }
        if (null !== $this->outerTradeType) {
            $res['outerTradeType'] = $this->outerTradeType;
        }
        if (null !== $this->planId) {
            $res['planId'] = $this->planId;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->unPay) {
            $res['unPay'] = $this->unPay;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PurchaseMixViewRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
        }
        if (isset($map['combineActivityId'])) {
            $model->combineActivityId = $map['combineActivityId'];
        }
        if (isset($map['createOrder'])) {
            $model->createOrder = $map['createOrder'];
        }
        if (isset($map['list'])) {
            if (!empty($map['list'])) {
                $model->list = [];
                $n = 0;
                foreach ($map['list'] as $item) {
                    $model->list[$n++] = null !== $item ? list_::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['mergeOrderName'])) {
            $model->mergeOrderName = $map['mergeOrderName'];
        }
        if (isset($map['needModelTypeList'])) {
            if (!empty($map['needModelTypeList'])) {
                $model->needModelTypeList = $map['needModelTypeList'];
            }
        }
        if (isset($map['objId'])) {
            $model->objId = $map['objId'];
        }
        if (isset($map['objType'])) {
            $model->objType = $map['objType'];
        }
        if (isset($map['orderParamMap'])) {
            $model->orderParamMap = $map['orderParamMap'];
        }
        if (isset($map['outerTradeCode'])) {
            $model->outerTradeCode = $map['outerTradeCode'];
        }
        if (isset($map['outerTradeType'])) {
            $model->outerTradeType = $map['outerTradeType'];
        }
        if (isset($map['planId'])) {
            $model->planId = $map['planId'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['unPay'])) {
            $model->unPay = $map['unPay'];
        }

        return $model;
    }
}
