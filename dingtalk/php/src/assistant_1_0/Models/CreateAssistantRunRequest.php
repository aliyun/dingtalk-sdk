<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAssistantRunRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $assistantId;

    /**
     * @var string
     */
    public $instructions;

    /**
     * @var mixed[]
     */
    public $metadata;

    /**
     * @var bool
     */
    public $stream;
    protected $_name = [
        'assistantId'  => 'assistantId',
        'instructions' => 'instructions',
        'metadata'     => 'metadata',
        'stream'       => 'stream',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->instructions) {
            $res['instructions'] = $this->instructions;
        }
        if (null !== $this->metadata) {
            $res['metadata'] = $this->metadata;
        }
        if (null !== $this->stream) {
            $res['stream'] = $this->stream;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAssistantRunRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['instructions'])) {
            $model->instructions = $map['instructions'];
        }
        if (isset($map['metadata'])) {
            $model->metadata = $map['metadata'];
        }
        if (isset($map['stream'])) {
            $model->stream = $map['stream'];
        }

        return $model;
    }
}
