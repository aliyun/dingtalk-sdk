<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\Tea\Model;

class VoiceCloneRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 你好，我叫小智，是来自阿里云的超大规模语言模型。我是一个能够回答问题、创作文字，还能表达观点、撰写代码的全能型AI助手。如果您有任何问题或需要帮助，请随时告诉我，我会尽我所能为您提供帮助！
     *
     * @var string
     */
    public $text;

    /**
     * @example manager4224
     *
     * @var string
     */
    public $userId;

    /**
     * @description This parameter is required.
     *
     * @example qhtestvoice-01
     *
     * @var string
     */
    public $voiceId;
    protected $_name = [
        'text'    => 'text',
        'userId'  => 'userId',
        'voiceId' => 'voiceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->voiceId) {
            $res['voiceId'] = $this->voiceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return VoiceCloneRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['voiceId'])) {
            $model->voiceId = $map['voiceId'];
        }

        return $model;
    }
}
