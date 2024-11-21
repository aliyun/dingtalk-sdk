<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatAITextSentimentAnalysisResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $sentiment;
    protected $_name = [
        'sentiment' => 'sentiment',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sentiment) {
            $res['sentiment'] = $this->sentiment;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sentiment'])) {
            $model->sentiment = $map['sentiment'];
        }

        return $model;
    }
}
