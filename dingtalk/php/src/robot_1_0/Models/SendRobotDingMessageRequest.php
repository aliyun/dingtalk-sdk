<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendRobotDingMessageRequest extends Model
{
    /**
     * @var string[]
     */
    public $contentParams;

    /**
     * @example template_ding_diot_monitor
     *
     * @var string
     */
    public $dingTemplateId;

    /**
     * @example cidfCSpXXXXXXXXXXXchatbotId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string[]
     */
    public $receiverUserIdList;

    /**
     * @example qF9j5G8hmFLiqJ11629XXXXXXXX
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
