<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExclusiveModelCompleteServiceRequest\messages;
use AlibabaCloud\Tea\Model;

class ExclusiveModelCompleteServiceRequest extends Model
{
    /**
     * @var bool
     */
    public $enableSearch;

    /**
     * @var int
     */
    public $maxTokens;

    /**
     * @description This parameter is required.
     *
     * @var messages[]
     */
    public $messages;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $model;

    /**
     * @var bool
     */
    public $stream;

    /**
     * @var float
     */
    public $temperature;

    /**
     * @var float
     */
    public $topP;
    protected $_name = [
        'enableSearch' => 'enable_search',
        'maxTokens' => 'max_tokens',
        'messages' => 'messages',
        'model' => 'model',
        'stream' => 'stream',
        'temperature' => 'temperature',
        'topP' => 'top_p',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enableSearch) {
            $res['enable_search'] = $this->enableSearch;
        }
        if (null !== $this->maxTokens) {
            $res['max_tokens'] = $this->maxTokens;
        }
        if (null !== $this->messages) {
            $res['messages'] = [];
            if (null !== $this->messages && \is_array($this->messages)) {
                $n = 0;
                foreach ($this->messages as $item) {
                    $res['messages'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->stream) {
            $res['stream'] = $this->stream;
        }
        if (null !== $this->temperature) {
            $res['temperature'] = $this->temperature;
        }
        if (null !== $this->topP) {
            $res['top_p'] = $this->topP;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExclusiveModelCompleteServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enable_search'])) {
            $model->enableSearch = $map['enable_search'];
        }
        if (isset($map['max_tokens'])) {
            $model->maxTokens = $map['max_tokens'];
        }
        if (isset($map['messages'])) {
            if (!empty($map['messages'])) {
                $model->messages = [];
                $n = 0;
                foreach ($map['messages'] as $item) {
                    $model->messages[$n++] = null !== $item ? messages::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['stream'])) {
            $model->stream = $map['stream'];
        }
        if (isset($map['temperature'])) {
            $model->temperature = $map['temperature'];
        }
        if (isset($map['top_p'])) {
            $model->topP = $map['top_p'];
        }

        return $model;
    }
}
