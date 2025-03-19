<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetQeneralTaxpayerInfoResponseBody extends Model
{
    /**
     * @example [     {       "DEPARTMENT":"xx"       "END_DATE":"2017-01-04"       "ENT_NAME":"xx"       "QUALIFICATION"       "START_DATE":"2017-01-04"       "TAXPAYER_NUM":"11"       "JUDGE_DATE":"2017-05-04"      }   ]
     *
     * @var string
     */
    public $data;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'data' => 'data',
        'total' => 'total',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetQeneralTaxpayerInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
