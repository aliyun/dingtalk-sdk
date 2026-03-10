<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractSubjectRiskResultResponseBody\subjectRiskResponses;

use AlibabaCloud\Tea\Model;

class subjectRiskListResponse extends Model
{
    /**
     * @var bool
     */
    public $isSubjectExist;

    /**
     * @var string[]
     */
    public $riskTypes;

    /**
     * @var mixed[]
     */
    public $risks;

    /**
     * @var int
     */
    public $totalRiskNumber;
    protected $_name = [
        'isSubjectExist' => 'isSubjectExist',
        'riskTypes' => 'riskTypes',
        'risks' => 'risks',
        'totalRiskNumber' => 'totalRiskNumber',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isSubjectExist) {
            $res['isSubjectExist'] = $this->isSubjectExist;
        }
        if (null !== $this->riskTypes) {
            $res['riskTypes'] = $this->riskTypes;
        }
        if (null !== $this->risks) {
            $res['risks'] = $this->risks;
        }
        if (null !== $this->totalRiskNumber) {
            $res['totalRiskNumber'] = $this->totalRiskNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subjectRiskListResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isSubjectExist'])) {
            $model->isSubjectExist = $map['isSubjectExist'];
        }
        if (isset($map['riskTypes'])) {
            if (!empty($map['riskTypes'])) {
                $model->riskTypes = $map['riskTypes'];
            }
        }
        if (isset($map['risks'])) {
            $model->risks = $map['risks'];
        }
        if (isset($map['totalRiskNumber'])) {
            $model->totalRiskNumber = $map['totalRiskNumber'];
        }

        return $model;
    }
}
