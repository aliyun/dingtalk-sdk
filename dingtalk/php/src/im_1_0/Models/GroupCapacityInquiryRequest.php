<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupCapacityInquiryRequest extends Model
{
    /**
     * @description 有效生命周期
     *
     * @var string
     */
    public $effectiveDuration;

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
     * @description 扩展参数
     *
     * @var mixed[]
     */
    public $options;

    /**
     * @description 目标容量
     *
     * @var int
     */
    public $targetCapacity;
    protected $_name = [
        'effectiveDuration'  => 'effectiveDuration',
        'openConversationId' => 'openConversationId',
        'operator'           => 'operator',
        'options'            => 'options',
        'targetCapacity'     => 'targetCapacity',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->effectiveDuration) {
            $res['effectiveDuration'] = $this->effectiveDuration;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->options) {
            $res['options'] = $this->options;
        }
        if (null !== $this->targetCapacity) {
            $res['targetCapacity'] = $this->targetCapacity;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupCapacityInquiryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['effectiveDuration'])) {
            $model->effectiveDuration = $map['effectiveDuration'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['options'])) {
            $model->options = $map['options'];
        }
        if (isset($map['targetCapacity'])) {
            $model->targetCapacity = $map['targetCapacity'];
        }

        return $model;
    }
}
