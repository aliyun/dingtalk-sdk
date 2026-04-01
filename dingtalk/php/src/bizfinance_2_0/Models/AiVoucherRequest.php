<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class AiVoucherRequest extends Model
{
    /**
     * @var string
     */
    public $chatMessages;

    /**
     * @var bool
     */
    public $enableThinking;

    /**
     * @var string
     */
    public $extendInfo;

    /**
     * @var string
     */
    public $prompt;
    protected $_name = [
        'chatMessages' => 'chatMessages',
        'enableThinking' => 'enableThinking',
        'extendInfo' => 'extendInfo',
        'prompt' => 'prompt',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatMessages) {
            $res['chatMessages'] = $this->chatMessages;
        }
        if (null !== $this->enableThinking) {
            $res['enableThinking'] = $this->enableThinking;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->prompt) {
            $res['prompt'] = $this->prompt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AiVoucherRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatMessages'])) {
            $model->chatMessages = $map['chatMessages'];
        }
        if (isset($map['enableThinking'])) {
            $model->enableThinking = $map['enableThinking'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['prompt'])) {
            $model->prompt = $map['prompt'];
        }

        return $model;
    }
}
