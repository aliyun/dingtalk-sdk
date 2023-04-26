<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryYydActiveWeekStatisticalDataRequest extends Model
{
    /**
     * @var string
     */
    public $statDate;
    protected $_name = [
        'statDate' => 'statDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->statDate) {
            $res['statDate'] = $this->statDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryYydActiveWeekStatisticalDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['statDate'])) {
            $model->statDate = $map['statDate'];
        }

        return $model;
    }
}
