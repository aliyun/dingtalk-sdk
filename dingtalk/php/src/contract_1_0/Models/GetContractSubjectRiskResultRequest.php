<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetContractSubjectRiskResultRequest extends Model
{
    /**
     * @var string
     */
    public $reviewType;

    /**
     * @var string
     */
    public $taskId;
    protected $_name = [
        'reviewType' => 'reviewType',
        'taskId' => 'taskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->reviewType) {
            $res['reviewType'] = $this->reviewType;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetContractSubjectRiskResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['reviewType'])) {
            $model->reviewType = $map['reviewType'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
