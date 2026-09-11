<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySalesInsightsRequest extends Model
{
    /**
     * @var string
     */
    public $analysisDate;

    /**
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'analysisDate' => 'analysisDate',
        'userIdList' => 'userIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->analysisDate) {
            $res['analysisDate'] = $this->analysisDate;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySalesInsightsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['analysisDate'])) {
            $model->analysisDate = $map['analysisDate'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
