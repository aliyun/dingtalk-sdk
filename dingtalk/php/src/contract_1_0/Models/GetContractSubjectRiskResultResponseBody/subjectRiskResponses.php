<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractSubjectRiskResultResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractSubjectRiskResultResponseBody\subjectRiskResponses\subjectBaseInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractSubjectRiskResultResponseBody\subjectRiskResponses\subjectRiskListResponse;
use AlibabaCloud\Tea\Model;

class subjectRiskResponses extends Model
{
    /**
     * @var subjectBaseInfoResponse
     */
    public $subjectBaseInfoResponse;

    /**
     * @var string
     */
    public $subjectName;

    /**
     * @var subjectRiskListResponse
     */
    public $subjectRiskListResponse;
    protected $_name = [
        'subjectBaseInfoResponse' => 'subjectBaseInfoResponse',
        'subjectName' => 'subjectName',
        'subjectRiskListResponse' => 'subjectRiskListResponse',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->subjectBaseInfoResponse) {
            $res['subjectBaseInfoResponse'] = null !== $this->subjectBaseInfoResponse ? $this->subjectBaseInfoResponse->toMap() : null;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }
        if (null !== $this->subjectRiskListResponse) {
            $res['subjectRiskListResponse'] = null !== $this->subjectRiskListResponse ? $this->subjectRiskListResponse->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subjectRiskResponses
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subjectBaseInfoResponse'])) {
            $model->subjectBaseInfoResponse = subjectBaseInfoResponse::fromMap($map['subjectBaseInfoResponse']);
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }
        if (isset($map['subjectRiskListResponse'])) {
            $model->subjectRiskListResponse = subjectRiskListResponse::fromMap($map['subjectRiskListResponse']);
        }

        return $model;
    }
}
