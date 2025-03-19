<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddEvaluatePerformanceRequest\evaluationData;
use AlibabaCloud\Tea\Model;

class AddEvaluatePerformanceRequest extends Model
{
    /**
     * @var evaluationData[]
     */
    public $evaluationData;
    protected $_name = [
        'evaluationData' => 'evaluationData',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->evaluationData) {
            $res['evaluationData'] = [];
            if (null !== $this->evaluationData && \is_array($this->evaluationData)) {
                $n = 0;
                foreach ($this->evaluationData as $item) {
                    $res['evaluationData'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddEvaluatePerformanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['evaluationData'])) {
            if (!empty($map['evaluationData'])) {
                $model->evaluationData = [];
                $n = 0;
                foreach ($map['evaluationData'] as $item) {
                    $model->evaluationData[$n++] = null !== $item ? evaluationData::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
