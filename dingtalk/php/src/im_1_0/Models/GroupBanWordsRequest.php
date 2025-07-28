<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupBanWordsRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $banWordsMode;

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
        'banWordsMode' => 'banWordsMode',
        'openConversationId' => 'openConversationId',
        'options' => 'options',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->banWordsMode) {
            $res['banWordsMode'] = $this->banWordsMode;
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
     * @return GroupBanWordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['banWordsMode'])) {
            $model->banWordsMode = $map['banWordsMode'];
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
