<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsReviewResultResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsReviewResultResponseBody\result\data\reviewRiskDetail;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsReviewResultResponseBody\result\data\reviewRiskOverview;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsReviewResultResponseBody\result\data\reviewStatus;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var reviewRiskDetail[]
     */
    public $reviewRiskDetail;

    /**
     * @var reviewRiskOverview
     */
    public $reviewRiskOverview;

    /**
     * @var reviewStatus
     */
    public $reviewStatus;
    protected $_name = [
        'reviewRiskDetail' => 'reviewRiskDetail',
        'reviewRiskOverview' => 'reviewRiskOverview',
        'reviewStatus' => 'reviewStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->reviewRiskDetail) {
            $res['reviewRiskDetail'] = [];
            if (null !== $this->reviewRiskDetail && \is_array($this->reviewRiskDetail)) {
                $n = 0;
                foreach ($this->reviewRiskDetail as $item) {
                    $res['reviewRiskDetail'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->reviewRiskOverview) {
            $res['reviewRiskOverview'] = null !== $this->reviewRiskOverview ? $this->reviewRiskOverview->toMap() : null;
        }
        if (null !== $this->reviewStatus) {
            $res['reviewStatus'] = null !== $this->reviewStatus ? $this->reviewStatus->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['reviewRiskDetail'])) {
            if (!empty($map['reviewRiskDetail'])) {
                $model->reviewRiskDetail = [];
                $n = 0;
                foreach ($map['reviewRiskDetail'] as $item) {
                    $model->reviewRiskDetail[$n++] = null !== $item ? reviewRiskDetail::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['reviewRiskOverview'])) {
            $model->reviewRiskOverview = reviewRiskOverview::fromMap($map['reviewRiskOverview']);
        }
        if (isset($map['reviewStatus'])) {
            $model->reviewStatus = reviewStatus::fromMap($map['reviewStatus']);
        }

        return $model;
    }
}
