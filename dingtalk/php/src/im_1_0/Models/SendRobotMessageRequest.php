<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendRobotMessageRequest extends Model
{
    /**
     * @var bool
     */
    public $atAll;

    /**
     * @example 1107****2120
     *
     * @var string
     */
    public $atAppUserId;

    /**
     * @example 1107****2120
     *
     * @var string
     */
    public $atDingUserId;

    /**
     * @description This parameter is required.
     *
     * @example { "content": "我就是我, 是不一样的烟火"}
     *
     * @var string
     */
    public $msgContent;

    /**
     * @description This parameter is required.
     *
     * @example text
     *
     * @var string
     */
    public $msgType;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $openConversationIds;

    /**
     * @example kelian-custom-service-robot-101
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'atAll' => 'atAll',
        'atAppUserId' => 'atAppUserId',
        'atDingUserId' => 'atDingUserId',
        'msgContent' => 'msgContent',
        'msgType' => 'msgType',
        'openConversationIds' => 'openConversationIds',
        'robotCode' => 'robotCode',
    ];

    public function validate() {}

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
