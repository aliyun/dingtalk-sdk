<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendRobotDingMessageRequest extends Model
{
    /**
     * @description 模版对应的参数
     *
     * @var string[]
     */
    public $contentParams;

    /**
     * @description 颁发的模版id，可通过宜搭申请：https://yida.alibaba-inc.com/alibaba/web/APP_NSUGAGIQUMI4ESRA7O7D/inst/homepage/#/FORM-WO866371VGXSECXX4M0NC9KSGAT92VSA3TZSK9B
     *
     * @var string
     */
    public $dingTemplateId;

    /**
     * @description 群聊的对外开放Id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 接受人的userId列表
     *
     * @var string[]
     */
    public $receiverUserIdList;

    /**
     * @description 机器人的Id
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'contentParams'      => 'contentParams',
        'dingTemplateId'     => 'dingTemplateId',
        'openConversationId' => 'openConversationId',
        'receiverUserIdList' => 'receiverUserIdList',
        'robotCode'          => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentParams) {
            $res['contentParams'] = $this->contentParams;
        }
        if (null !== $this->dingTemplateId) {
            $res['dingTemplateId'] = $this->dingTemplateId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->receiverUserIdList) {
            $res['receiverUserIdList'] = $this->receiverUserIdList;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendRobotDingMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentParams'])) {
            $model->contentParams = $map['contentParams'];
        }
        if (isset($map['dingTemplateId'])) {
            $model->dingTemplateId = $map['dingTemplateId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['receiverUserIdList'])) {
            if (!empty($map['receiverUserIdList'])) {
                $model->receiverUserIdList = $map['receiverUserIdList'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
