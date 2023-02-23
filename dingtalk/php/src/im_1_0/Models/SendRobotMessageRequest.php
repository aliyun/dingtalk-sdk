<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendRobotMessageRequest extends Model
{
    /**
     * @description @群所有人为true， 默认false。
     *
     * @var bool
     */
    public $atAll;

    /**
     * @description @钉外账号在业务系统内的唯一标志。
     *
     * @var string
     */
    public $atAppUserId;

    /**
     * @description @钉内账号userId。
     *
     * @var string
     */
    public $atDingUserId;

    /**
     * @description 消息体内容，按照下面参考示例格式上传。
     *
     * @var string
     */
    public $msgContent;

    /**
     * @description 消息类型 文本：text，图片：photo，markdown：markdown，actionCard：actionCard。
     *
     * @var string
     */
    public $msgType;

    /**
     * @description 群会话Id列表。
     *
     * @var string[]
     */
    public $openConversationIds;

    /**
     * @description 机器人robotId（robotCode），指定哪个机器人发送消息
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'atAll'               => 'atAll',
        'atAppUserId'         => 'atAppUserId',
        'atDingUserId'        => 'atDingUserId',
        'msgContent'          => 'msgContent',
        'msgType'             => 'msgType',
        'openConversationIds' => 'openConversationIds',
        'robotCode'           => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atAll) {
            $res['atAll'] = $this->atAll;
        }
        if (null !== $this->atAppUserId) {
            $res['atAppUserId'] = $this->atAppUserId;
        }
        if (null !== $this->atDingUserId) {
            $res['atDingUserId'] = $this->atDingUserId;
        }
        if (null !== $this->msgContent) {
            $res['msgContent'] = $this->msgContent;
        }
        if (null !== $this->msgType) {
            $res['msgType'] = $this->msgType;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendRobotMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atAll'])) {
            $model->atAll = $map['atAll'];
        }
        if (isset($map['atAppUserId'])) {
            $model->atAppUserId = $map['atAppUserId'];
        }
        if (isset($map['atDingUserId'])) {
            $model->atDingUserId = $map['atDingUserId'];
        }
        if (isset($map['msgContent'])) {
            $model->msgContent = $map['msgContent'];
        }
        if (isset($map['msgType'])) {
            $model->msgType = $map['msgType'];
        }
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
