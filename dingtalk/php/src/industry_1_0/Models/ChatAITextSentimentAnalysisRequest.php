<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChatAITextSentimentAnalysisRequest extends Model
{
    /**
     * @var string[]
     */
    public $history;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $text;
    protected $_name = [
        'history' => 'history',
        'text'    => 'text',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->history) {
            $res['history'] = $this->history;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatAITextSentimentAnalysisRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['history'])) {
            if (!empty($map['history'])) {
                $model->history = $map['history'];
            }
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }

        return $model;
    }
}
