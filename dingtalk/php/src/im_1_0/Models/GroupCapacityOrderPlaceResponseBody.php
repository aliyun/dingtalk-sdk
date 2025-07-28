<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupCapacityOrderPlaceResponseBody extends Model
{
    /**
     * @example 85000
     *
     * @var int
     */
    public $actualPrice;

    /**
     * @example 500
     *
     * @var int
     */
    public $currentCapacity;

    /**
     * @example 1652669110553
     *
     * @var int
     */
    public $currentEffectUntil;

    /**
     * @example 85
     *
     * @var int
     */
    public $discount;

    /**
     * @var string[]
     */
    public $extInfo;

    /**
     * @example 10000
     *
     * @var int
     */
    public $markedPrice;

    /**
     * @example ciddfasvc
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 033333
     *
     * @var string
     */
    public $operator;

    /**
     * @example 12389023745345500
     *
     * @var string
     */
    public $orderId;

    /**
     * @example 10000
     *
     * @var int
     */
    public $targetCapacity;

    /**
     * @example 1652669110553
     *
     * @var int
     */
    public $targetEffectUntil;

    /**
     * @example 90ji34ontgrefv98u0ijo3q4awefg90rej
     *
     * @var string
     */
    public $token;
    protected $_name = [
        'actualPrice' => 'actualPrice',
        'currentCapacity' => 'currentCapacity',
        'currentEffectUntil' => 'currentEffectUntil',
        'discount' => 'discount',
        'extInfo' => 'extInfo',
        'markedPrice' => 'markedPrice',
        'openConversationId' => 'openConversationId',
        'operator' => 'operator',
        'orderId' => 'orderId',
        'targetCapacity' => 'targetCapacity',
        'targetEffectUntil' => 'targetEffectUntil',
        'token' => 'token',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualPrice) {
            $res['actualPrice'] = $this->actualPrice;
        }
        if (null !== $this->currentCapacity) {
            $res['currentCapacity'] = $this->currentCapacity;
        }
        if (null !== $this->currentEffectUntil) {
            $res['currentEffectUntil'] = $this->currentEffectUntil;
        }
        if (null !== $this->discount) {
            $res['discount'] = $this->discount;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->markedPrice) {
            $res['markedPrice'] = $this->markedPrice;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->targetCapacity) {
            $res['targetCapacity'] = $this->targetCapacity;
        }
        if (null !== $this->targetEffectUntil) {
            $res['targetEffectUntil'] = $this->targetEffectUntil;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupCapacityOrderPlaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualPrice'])) {
            $model->actualPrice = $map['actualPrice'];
        }
        if (isset($map['currentCapacity'])) {
            $model->currentCapacity = $map['currentCapacity'];
        }
        if (isset($map['currentEffectUntil'])) {
            $model->currentEffectUntil = $map['currentEffectUntil'];
        }
        if (isset($map['discount'])) {
            $model->discount = $map['discount'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['markedPrice'])) {
            $model->markedPrice = $map['markedPrice'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['targetCapacity'])) {
            $model->targetCapacity = $map['targetCapacity'];
        }
        if (isset($map['targetEffectUntil'])) {
            $model->targetEffectUntil = $map['targetEffectUntil'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }

        return $model;
    }
}
