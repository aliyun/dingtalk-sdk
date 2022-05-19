<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupCapacityOrderPlaceRequest extends Model
{
    /**
     * @description 实际价格
     *
     * @var int
     */
    public $actualPrice;

    /**
     * @description 当前容量
     *
     * @var int
     */
    public $currentCapacity;

    /**
     * @description 当前操当前容量生效至何时
     *
     * @var int
     */
    public $currentEffectUntil;

    /**
     * @description 折扣
     *
     * @var int
     */
    public $discount;

    /**
     * @description 扩展信息
     *
     * @var mixed[]
     */
    public $extInfo;

    /**
     * @description 标价
     *
     * @var int
     */
    public $markedPrice;

    /**
     * @description 开放的群id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 当前操作人工号
     *
     * @var string
     */
    public $operator;

    /**
     * @description 目标容量
     *
     * @var int
     */
    public $targetCapacity;

    /**
     * @description 目标容量生效至何时
     *
     * @var int
     */
    public $targetEffectUntil;

    /**
     * @description 校验令牌
     *
     * @var string
     */
    public $token;
    protected $_name = [
        'actualPrice'        => 'actualPrice',
        'currentCapacity'    => 'currentCapacity',
        'currentEffectUntil' => 'currentEffectUntil',
        'discount'           => 'discount',
        'extInfo'            => 'extInfo',
        'markedPrice'        => 'markedPrice',
        'openConversationId' => 'openConversationId',
        'operator'           => 'operator',
        'targetCapacity'     => 'targetCapacity',
        'targetEffectUntil'  => 'targetEffectUntil',
        'token'              => 'token',
    ];

    public function validate()
    {
    }

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
     * @return GroupCapacityOrderPlaceRequest
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
