<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupCapacityInquiryResponseBody extends Model
{
    /**
     * @example 85000
     *
     * @var int
     */
    public $actualPrice;

    /**
     * @example 1652183395772
     *
     * @var int
     */
    public $createdAt;

    /**
     * @example 500
     *
     * @var int
     */
    public $currentCapacity;

    /**
     * @example 1652183395772
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
     * @var mixed[]
     */
    public $extInfo;

    /**
     * @example 678912390478123
     *
     * @var string
     */
    public $groupOwner;

    /**
     * @example 今天吃肘子群
     *
     * @var string
     */
    public $groupTitle;

    /**
     * @example 10000
     *
     * @var int
     */
    public $markedPrice;

    /**
     * @example 500
     *
     * @var int
     */
    public $memberCount;

    /**
     * @example cidoondswfakscdviouhao==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 32453245234523425
     *
     * @var string
     */
    public $operator;

    /**
     * @example 10000
     *
     * @var int
     */
    public $targetCapacity;

    /**
     * @example 1652183395772
     *
     * @var int
     */
    public $targetEffectUntil;

    /**
     * @example jklasdhjfasdjkfkh421jk5bb243b523
     *
     * @var string
     */
    public $token;
    protected $_name = [
        'actualPrice'        => 'actualPrice',
        'createdAt'          => 'createdAt',
        'currentCapacity'    => 'currentCapacity',
        'currentEffectUntil' => 'currentEffectUntil',
        'discount'           => 'discount',
        'extInfo'            => 'extInfo',
        'groupOwner'         => 'groupOwner',
        'groupTitle'         => 'groupTitle',
        'markedPrice'        => 'markedPrice',
        'memberCount'        => 'memberCount',
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
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
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
        if (null !== $this->groupOwner) {
            $res['groupOwner'] = $this->groupOwner;
        }
        if (null !== $this->groupTitle) {
            $res['groupTitle'] = $this->groupTitle;
        }
        if (null !== $this->markedPrice) {
            $res['markedPrice'] = $this->markedPrice;
        }
        if (null !== $this->memberCount) {
            $res['memberCount'] = $this->memberCount;
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
     * @return GroupCapacityInquiryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualPrice'])) {
            $model->actualPrice = $map['actualPrice'];
        }
        if (isset($map['createdAt'])) {
            $model->createdAt = $map['createdAt'];
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
        if (isset($map['groupOwner'])) {
            $model->groupOwner = $map['groupOwner'];
        }
        if (isset($map['groupTitle'])) {
            $model->groupTitle = $map['groupTitle'];
        }
        if (isset($map['markedPrice'])) {
            $model->markedPrice = $map['markedPrice'];
        }
        if (isset($map['memberCount'])) {
            $model->memberCount = $map['memberCount'];
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
