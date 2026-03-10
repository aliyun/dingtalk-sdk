<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractSubjectRiskResultResponseBody\subjectRiskResponses;
use AlibabaCloud\Tea\Model;

class GetContractSubjectRiskResultResponseBody extends Model
{
    /**
     * @var subjectRiskResponses[]
     */
    public $subjectRiskResponses;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'subjectRiskResponses' => 'subjectRiskResponses',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->subjectRiskResponses) {
            $res['subjectRiskResponses'] = [];
            if (null !== $this->subjectRiskResponses && \is_array($this->subjectRiskResponses)) {
                $n = 0;
                foreach ($this->subjectRiskResponses as $item) {
                    $res['subjectRiskResponses'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetContractSubjectRiskResultResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subjectRiskResponses'])) {
            if (!empty($map['subjectRiskResponses'])) {
                $model->subjectRiskResponses = [];
                $n = 0;
                foreach ($map['subjectRiskResponses'] as $item) {
                    $model->subjectRiskResponses[$n++] = null !== $item ? subjectRiskResponses::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
