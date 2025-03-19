<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupManageReduceRequest extends Model
{
    /**
     * @example 200
     *
     * @var int
     */
    public $capacityLimit;

    /**
     * @example cidnvcxzklxv
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var mixed[]
     */
    public $options;
    protected $_name = [
        'capacityLimit' => 'capacityLimit',
        'openConversationId' => 'openConversationId',
        'options' => 'options',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->capacityLimit) {
            $res['capacityLimit'] = $this->capacityLimit;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->options) {
            $res['options'] = $this->options;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupManageReduceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['capacityLimit'])) {
            $model->capacityLimit = $map['capacityLimit'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['options'])) {
            $model->options = $map['options'];
        }

        return $model;
    }
}
