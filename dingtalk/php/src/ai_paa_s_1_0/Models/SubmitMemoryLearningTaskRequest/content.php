<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\SubmitMemoryLearningTaskRequest;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var string
     */
    public $knowledgeBaseUrl;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'knowledgeBaseUrl' => 'knowledgeBaseUrl',
        'type'             => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->knowledgeBaseUrl) {
            $res['knowledgeBaseUrl'] = $this->knowledgeBaseUrl;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['knowledgeBaseUrl'])) {
            $model->knowledgeBaseUrl = $map['knowledgeBaseUrl'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
