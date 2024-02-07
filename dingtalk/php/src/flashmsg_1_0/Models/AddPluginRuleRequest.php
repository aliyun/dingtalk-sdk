<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models\AddPluginRuleRequest\rules;
use AlibabaCloud\Tea\Model;

class AddPluginRuleRequest extends Model
{
    /**
     * @example group_chat
     *
     * @var string
     */
    public $chatType;

    /**
     * @example -10050
     *
     * @var string
     */
    public $code;

    /**
     * @example group
     *
     * @var string
     */
    public $itemType;

    /**
     * @var rules[]
     */
    public $rules;

    /**
     * @example 0847493113802787
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'chatType' => 'chatType',
        'code'     => 'code',
        'itemType' => 'itemType',
        'rules'    => 'rules',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatType) {
            $res['chatType'] = $this->chatType;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->itemType) {
            $res['itemType'] = $this->itemType;
        }
        if (null !== $this->rules) {
            $res['rules'] = [];
            if (null !== $this->rules && \is_array($this->rules)) {
                $n = 0;
                foreach ($this->rules as $item) {
                    $res['rules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddPluginRuleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatType'])) {
            $model->chatType = $map['chatType'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['itemType'])) {
            $model->itemType = $map['itemType'];
        }
        if (isset($map['rules'])) {
            if (!empty($map['rules'])) {
                $model->rules = [];
                $n            = 0;
                foreach ($map['rules'] as $item) {
                    $model->rules[$n++] = null !== $item ? rules::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
