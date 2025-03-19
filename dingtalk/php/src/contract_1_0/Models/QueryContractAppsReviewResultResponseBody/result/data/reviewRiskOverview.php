<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsReviewResultResponseBody\result\data;

use AlibabaCloud\Tea\Model;

class reviewRiskOverview extends Model
{
    /**
     * @var bool
     */
    public $hasRisk;

    /**
     * @var int
     */
    public $highRisk;

    /**
     * @var int
     */
    public $lowRisk;

    /**
     * @var int
     */
    public $mediumRisk;
    protected $_name = [
        'hasRisk' => 'hasRisk',
        'highRisk' => 'highRisk',
        'lowRisk' => 'lowRisk',
        'mediumRisk' => 'mediumRisk',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasRisk) {
            $res['hasRisk'] = $this->hasRisk;
        }
        if (null !== $this->highRisk) {
            $res['highRisk'] = $this->highRisk;
        }
        if (null !== $this->lowRisk) {
            $res['lowRisk'] = $this->lowRisk;
        }
        if (null !== $this->mediumRisk) {
            $res['mediumRisk'] = $this->mediumRisk;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reviewRiskOverview
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasRisk'])) {
            $model->hasRisk = $map['hasRisk'];
        }
        if (isset($map['highRisk'])) {
            $model->highRisk = $map['highRisk'];
        }
        if (isset($map['lowRisk'])) {
            $model->lowRisk = $map['lowRisk'];
        }
        if (isset($map['mediumRisk'])) {
            $model->mediumRisk = $map['mediumRisk'];
        }

        return $model;
    }
}
