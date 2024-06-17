<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class LearnKnowledgeRequest extends Model
{
    /**
     * @var string
     */
    public $assistantId;

    /**
     * @var string
     */
    public $docUrl;
    protected $_name = [
        'assistantId' => 'assistantId',
        'docUrl'      => 'docUrl',
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
        if (null !== $this->docUrl) {
            $res['docUrl'] = $this->docUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LearnKnowledgeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['docUrl'])) {
            $model->docUrl = $map['docUrl'];
        }

        return $model;
    }
}
