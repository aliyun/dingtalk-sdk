<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushRobotMessageRequest extends Model
{
    /**
     * @example 1234
     *
     * @var string
     */
    public $chatbotId;

    /**
     * @example sampleText
     *
     * @var string
     */
    public $msgKey;

    /**
     * @example eyJjb250ZW50IjogIua1i+ivleWGheWuuSJ9(即{"content": "测试内容"}的base64编码值)
     *
     * @var string
     */
    public $msgParam;

    /**
     * @example 123456abc
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'chatbotId' => 'chatbotId',
        'msgKey'    => 'msgKey',
        'msgParam'  => 'msgParam',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatbotId) {
            $res['chatbotId'] = $this->chatbotId;
        }
        if (null !== $this->msgKey) {
            $res['msgKey'] = $this->msgKey;
        }
        if (null !== $this->msgParam) {
            $res['msgParam'] = $this->msgParam;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushRobotMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatbotId'])) {
            $model->chatbotId = $map['chatbotId'];
        }
        if (isset($map['msgKey'])) {
            $model->msgKey = $map['msgKey'];
        }
        if (isset($map['msgParam'])) {
            $model->msgParam = $map['msgParam'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
