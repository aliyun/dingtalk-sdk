<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\aiAnalysis;

use AlibabaCloud\Tea\Model;

class keyRisks extends Model
{
    /**
     * @var string
     */
    public $evidence;

    /**
     * @var string
     */
    public $impact;

    /**
     * @var string
     */
    public $riskName;

    /**
     * @var string
     */
    public $suggestion;
    protected $_name = [
        'evidence' => 'evidence',
        'impact' => 'impact',
        'riskName' => 'riskName',
        'suggestion' => 'suggestion',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->evidence) {
            $res['evidence'] = $this->evidence;
        }
        if (null !== $this->impact) {
            $res['impact'] = $this->impact;
        }
        if (null !== $this->riskName) {
            $res['riskName'] = $this->riskName;
        }
        if (null !== $this->suggestion) {
            $res['suggestion'] = $this->suggestion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return keyRisks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['evidence'])) {
            $model->evidence = $map['evidence'];
        }
        if (isset($map['impact'])) {
            $model->impact = $map['impact'];
        }
        if (isset($map['riskName'])) {
            $model->riskName = $map['riskName'];
        }
        if (isset($map['suggestion'])) {
            $model->suggestion = $map['suggestion'];
        }

        return $model;
    }
}
