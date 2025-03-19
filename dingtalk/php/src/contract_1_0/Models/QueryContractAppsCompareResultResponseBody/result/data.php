<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsCompareResultResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsCompareResultResponseBody\result\data\compareDetail;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var compareDetail
     */
    public $compareDetail;

    /**
     * @var string
     */
    public $compareDetailUrl;

    /**
     * @var string
     */
    public $compareStatus;
    protected $_name = [
        'compareDetail' => 'compareDetail',
        'compareDetailUrl' => 'compareDetailUrl',
        'compareStatus' => 'compareStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->compareDetail) {
            $res['compareDetail'] = null !== $this->compareDetail ? $this->compareDetail->toMap() : null;
        }
        if (null !== $this->compareDetailUrl) {
            $res['compareDetailUrl'] = $this->compareDetailUrl;
        }
        if (null !== $this->compareStatus) {
            $res['compareStatus'] = $this->compareStatus;
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
        if (isset($map['compareDetail'])) {
            $model->compareDetail = compareDetail::fromMap($map['compareDetail']);
        }
        if (isset($map['compareDetailUrl'])) {
            $model->compareDetailUrl = $map['compareDetailUrl'];
        }
        if (isset($map['compareStatus'])) {
            $model->compareStatus = $map['compareStatus'];
        }

        return $model;
    }
}
