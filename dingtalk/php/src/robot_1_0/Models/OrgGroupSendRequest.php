<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class OrgGroupSendRequest extends Model
{
    /**
     * @example COOLAPP-1-10182EEDD1AC0BA600D9000J
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description This parameter is required.
     *
     * @example sampleText
     *
     * @var string
     */
    public $msgKey;

    /**
     * @description This parameter is required.
     *
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

    /**
     * @example 02feb1cd4ncmed92998723813a6bfa89eea1df91a750721979992870dd90bdfa
     *
     * @var string
     */
    public $token;
    protected $_name = [
        'coolAppCode' => 'coolAppCode',
        'msgKey' => 'msgKey',
        'msgParam' => 'msgParam',
        'openConversationId' => 'openConversationId',
        'robotCode' => 'robotCode',
        'token' => 'token',
    ];

    public function validate() {}

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
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrgGroupSendRequest
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
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }

        return $model;
    }
}
