<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\Tea\Model;

class SubmitMemoryLearningTaskShrinkRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $agentCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $contentShrink;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $learningMode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $memoryKey;
    protected $_name = [
        'agentCode' => 'agentCode',
        'contentShrink' => 'content',
        'learningMode' => 'learningMode',
        'memoryKey' => 'memoryKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentCode) {
            $res['agentCode'] = $this->agentCode;
        }
        if (null !== $this->contentShrink) {
            $res['content'] = $this->contentShrink;
        }
        if (null !== $this->learningMode) {
            $res['learningMode'] = $this->learningMode;
        }
        if (null !== $this->memoryKey) {
            $res['memoryKey'] = $this->memoryKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitMemoryLearningTaskShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentCode'])) {
            $model->agentCode = $map['agentCode'];
        }
        if (isset($map['content'])) {
            $model->contentShrink = $map['content'];
        }
        if (isset($map['learningMode'])) {
            $model->learningMode = $map['learningMode'];
        }
        if (isset($map['memoryKey'])) {
            $model->memoryKey = $map['memoryKey'];
        }

        return $model;
    }
}
