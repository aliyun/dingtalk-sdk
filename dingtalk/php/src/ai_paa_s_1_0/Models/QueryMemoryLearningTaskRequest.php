<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMemoryLearningTaskRequest extends Model
{
    /**
     * @var string
     */
    public $agentCode;

    /**
     * @var string
     */
    public $learningCode;
    protected $_name = [
        'agentCode'    => 'agentCode',
        'learningCode' => 'learningCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentCode) {
            $res['agentCode'] = $this->agentCode;
        }
        if (null !== $this->learningCode) {
            $res['learningCode'] = $this->learningCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMemoryLearningTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentCode'])) {
            $model->agentCode = $map['agentCode'];
        }
        if (isset($map['learningCode'])) {
            $model->learningCode = $map['learningCode'];
        }

        return $model;
    }
}
