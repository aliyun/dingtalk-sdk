<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteKnowledgeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $assistantId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $studyId;
    protected $_name = [
        'assistantId' => 'assistantId',
        'studyId' => 'studyId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->studyId) {
            $res['studyId'] = $this->studyId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteKnowledgeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['studyId'])) {
            $model->studyId = $map['studyId'];
        }

        return $model;
    }
}
