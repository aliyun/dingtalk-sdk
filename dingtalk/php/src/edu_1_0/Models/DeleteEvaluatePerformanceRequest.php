<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteEvaluatePerformanceRequest extends Model
{
    /**
     * @var string[]
     */
    public $evaluationIdList;
    protected $_name = [
        'evaluationIdList' => 'evaluationIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->evaluationIdList) {
            $res['evaluationIdList'] = $this->evaluationIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteEvaluatePerformanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['evaluationIdList'])) {
            if (!empty($map['evaluationIdList'])) {
                $model->evaluationIdList = $map['evaluationIdList'];
            }
        }

        return $model;
    }
}
