<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class PrivateChatSendRequest extends Model
{
    /**
     * @example COOLAPP-1-10182EEDD1AC0BA600D9000J
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @example sampleText
     *
     * @var string
     */
    public $msgKey;

    /**
     * @example {"content":"今天吃肘子"}
     *
     * @var string
     */
    public $msgParam;

    /**
     * @example cid6KeBBLoveMJOGXoYKF5x7EeiodoA==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example dingue4kfzdxbyn0pjqd
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'coolAppCode'        => 'coolAppCode',
        'msgKey'             => 'msgKey',
        'msgParam'           => 'msgParam',
        'openConversationId' => 'openConversationId',
        'robotCode'          => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->msgKey) {
            $res['msgKey'] = $this->msgKey;
        }
        if (null !== $this->msgParam) {
            $res['msgParam'] = $this->msgParam;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PrivateChatSendRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['msgKey'])) {
            $model->msgKey = $map['msgKey'];
        }
        if (isset($map['msgParam'])) {
            $model->msgParam = $map['msgParam'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
