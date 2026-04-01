<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAsyncCreateContractAnalysisResponseBody extends Model
{
    /**
     * @var string
     */
    public $analysisStatus;

    /**
     * @var string[]
     */
    public $companyList;

    /**
     * @var string[]
     */
    public $reviewPositions;

    /**
     * @var string
     */
    public $reviewType;

    /**
     * @var int
     */
    public $wordCount;
    protected $_name = [
        'analysisStatus' => 'analysisStatus',
        'companyList' => 'companyList',
        'reviewPositions' => 'reviewPositions',
        'reviewType' => 'reviewType',
        'wordCount' => 'wordCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->analysisStatus) {
            $res['analysisStatus'] = $this->analysisStatus;
        }
        if (null !== $this->companyList) {
            $res['companyList'] = $this->companyList;
        }
        if (null !== $this->reviewPositions) {
            $res['reviewPositions'] = $this->reviewPositions;
        }
        if (null !== $this->reviewType) {
            $res['reviewType'] = $this->reviewType;
        }
        if (null !== $this->wordCount) {
            $res['wordCount'] = $this->wordCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAsyncCreateContractAnalysisResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['analysisStatus'])) {
            $model->analysisStatus = $map['analysisStatus'];
        }
        if (isset($map['companyList'])) {
            if (!empty($map['companyList'])) {
                $model->companyList = $map['companyList'];
            }
        }
        if (isset($map['reviewPositions'])) {
            if (!empty($map['reviewPositions'])) {
                $model->reviewPositions = $map['reviewPositions'];
            }
        }
        if (isset($map['reviewType'])) {
            $model->reviewType = $map['reviewType'];
        }
        if (isset($map['wordCount'])) {
            $model->wordCount = $map['wordCount'];
        }

        return $model;
    }
}
