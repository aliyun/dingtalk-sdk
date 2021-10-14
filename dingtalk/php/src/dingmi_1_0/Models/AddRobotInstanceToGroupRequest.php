<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddRobotInstanceToGroupRequest extends Model
{
    /**
     * @description 企业id
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
     * @description 对话id
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'dingCorpId'         => 'dingCorpId',
        'chatbotId'          => 'chatbotId',
        'openConversationId' => 'openConversationId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddRobotInstanceToGroupRequest
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

        return $model;
    }
}
