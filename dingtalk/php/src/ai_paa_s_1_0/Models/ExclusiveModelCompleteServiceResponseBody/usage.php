<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExclusiveModelCompleteServiceResponseBody;

use AlibabaCloud\Tea\Model;

class usage extends Model
{
    /**
     * @var int
     */
    public $completionTokens;

    /**
     * @var int
     */
    public $promptTokens;

    /**
     * @var int
     */
    public $totalTokens;
    protected $_name = [
        'completionTokens' => 'completion_tokens',
        'promptTokens' => 'prompt_tokens',
        'totalTokens' => 'total_tokens',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->completionTokens) {
            $res['completion_tokens'] = $this->completionTokens;
        }
        if (null !== $this->promptTokens) {
            $res['prompt_tokens'] = $this->promptTokens;
        }
        if (null !== $this->totalTokens) {
            $res['total_tokens'] = $this->totalTokens;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return usage
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['completion_tokens'])) {
            $model->completionTokens = $map['completion_tokens'];
        }
        if (isset($map['prompt_tokens'])) {
            $model->promptTokens = $map['prompt_tokens'];
        }
        if (isset($map['total_tokens'])) {
            $model->totalTokens = $map['total_tokens'];
        }

        return $model;
    }
}
