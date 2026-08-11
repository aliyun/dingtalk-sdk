<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\businessRisk\subRisks;
use AlibabaCloud\Tea\Model;

class businessRisk extends Model
{
    /**
     * @var string
     */
    public $riskName;

    /**
     * @var int
     */
    public $riskNumber;

    /**
     * @var string
     */
    public $riskType;

    /**
     * @var string[]
     */
    public $subRiskTypes;

    /**
     * @var subRisks
     */
    public $subRisks;
    protected $_name = [
        'riskName' => 'riskName',
        'riskNumber' => 'riskNumber',
        'riskType' => 'riskType',
        'subRiskTypes' => 'subRiskTypes',
        'subRisks' => 'subRisks',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->riskName) {
            $res['riskName'] = $this->riskName;
        }
        if (null !== $this->riskNumber) {
            $res['riskNumber'] = $this->riskNumber;
        }
        if (null !== $this->riskType) {
            $res['riskType'] = $this->riskType;
        }
        if (null !== $this->subRiskTypes) {
            $res['subRiskTypes'] = $this->subRiskTypes;
        }
        if (null !== $this->subRisks) {
            $res['subRisks'] = null !== $this->subRisks ? $this->subRisks->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return businessRisk
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['riskName'])) {
            $model->riskName = $map['riskName'];
        }
        if (isset($map['riskNumber'])) {
            $model->riskNumber = $map['riskNumber'];
        }
        if (isset($map['riskType'])) {
            $model->riskType = $map['riskType'];
        }
        if (isset($map['subRiskTypes'])) {
            if (!empty($map['subRiskTypes'])) {
                $model->subRiskTypes = $map['subRiskTypes'];
            }
        }
        if (isset($map['subRisks'])) {
            $model->subRisks = subRisks::fromMap($map['subRisks']);
        }

        return $model;
    }
}
