<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QuerySalesInsightsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QuerySalesInsightsResponseBody\result\capabilityRadar;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QuerySalesInsightsResponseBody\result\insightList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $analysisDate;

    /**
     * @var capabilityRadar
     */
    public $capabilityRadar;

    /**
     * @var insightList[]
     */
    public $insightList;

    /**
     * @var string
     */
    public $teamCode;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'analysisDate' => 'analysisDate',
        'capabilityRadar' => 'capabilityRadar',
        'insightList' => 'insightList',
        'teamCode' => 'teamCode',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->analysisDate) {
            $res['analysisDate'] = $this->analysisDate;
        }
        if (null !== $this->capabilityRadar) {
            $res['capabilityRadar'] = null !== $this->capabilityRadar ? $this->capabilityRadar->toMap() : null;
        }
        if (null !== $this->insightList) {
            $res['insightList'] = [];
            if (null !== $this->insightList && \is_array($this->insightList)) {
                $n = 0;
                foreach ($this->insightList as $item) {
                    $res['insightList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->teamCode) {
            $res['teamCode'] = $this->teamCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['analysisDate'])) {
            $model->analysisDate = $map['analysisDate'];
        }
        if (isset($map['capabilityRadar'])) {
            $model->capabilityRadar = capabilityRadar::fromMap($map['capabilityRadar']);
        }
        if (isset($map['insightList'])) {
            if (!empty($map['insightList'])) {
                $model->insightList = [];
                $n = 0;
                foreach ($map['insightList'] as $item) {
                    $model->insightList[$n++] = null !== $item ? insightList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['teamCode'])) {
            $model->teamCode = $map['teamCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
