<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\RobotReplyEmotionRequest\textEmotion;
use AlibabaCloud\Tea\Model;

class RobotReplyEmotionRequest extends Model
{
    /**
     * @example OK
     *
     * @var string
     */
    public $emotionName;

    /**
     * @var int
     */
    public $emotionType;

    /**
     * @description This parameter is required.
     *
     * @example cidxxx
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example msgxxxx
     *
     * @var string
     */
    public $openMsgId;

    /**
     * @description This parameter is required.
     *
     * @example 213123
     *
     * @var string
     */
    public $robotCode;

    /**
     * @var textEmotion
     */
    public $textEmotion;
    protected $_name = [
        'emotionName' => 'emotionName',
        'emotionType' => 'emotionType',
        'openConversationId' => 'openConversationId',
        'openMsgId' => 'openMsgId',
        'robotCode' => 'robotCode',
        'textEmotion' => 'textEmotion',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->emotionName) {
            $res['emotionName'] = $this->emotionName;
        }
        if (null !== $this->emotionType) {
            $res['emotionType'] = $this->emotionType;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openMsgId) {
            $res['openMsgId'] = $this->openMsgId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->textEmotion) {
            $res['textEmotion'] = null !== $this->textEmotion ? $this->textEmotion->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RobotReplyEmotionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['emotionName'])) {
            $model->emotionName = $map['emotionName'];
        }
        if (isset($map['emotionType'])) {
            $model->emotionType = $map['emotionType'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openMsgId'])) {
            $model->openMsgId = $map['openMsgId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['textEmotion'])) {
            $model->textEmotion = textEmotion::fromMap($map['textEmotion']);
        }

        return $model;
    }
}
