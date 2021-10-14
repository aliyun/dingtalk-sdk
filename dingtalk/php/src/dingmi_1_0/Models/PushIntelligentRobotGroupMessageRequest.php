<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushIntelligentRobotGroupMessageRequest extends Model
{
    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $dingCorpId;

    /**
     * @description 机器人id
     *
     * @var string
     */
    public $chatbotId;

    /**
     * @description 群对话id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 消息类型
     *
     * @var string
     */
    public $msgKey;

    /**
     * @description 消息模板替换参数
     *
     * @var string
     */
    public $msgParam;
    protected $_name = [
        'dingCorpId'         => 'dingCorpId',
        'chatbotId'          => 'chatbotId',
        'openConversationId' => 'openConversationId',
        'msgKey'             => 'msgKey',
        'msgParam'           => 'msgParam',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->chatbotId) {
            $res['chatbotId'] = $this->chatbotId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->msgKey) {
            $res['msgKey'] = $this->msgKey;
        }
        if (null !== $this->msgParam) {
            $res['msgParam'] = $this->msgParam;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushIntelligentRobotGroupMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['chatbotId'])) {
            $model->chatbotId = $map['chatbotId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['msgKey'])) {
            $model->msgKey = $map['msgKey'];
        }
        if (isset($map['msgParam'])) {
            $model->msgParam = $map['msgParam'];
        }

        return $model;
    }
}
