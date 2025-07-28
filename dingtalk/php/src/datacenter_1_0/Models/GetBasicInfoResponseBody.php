<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetBasicInfoResponseBody extends Model
{
    /**
     * @example [     {       "ENT_NAME": "xx",       "LEGAL_NAME": "xx",       "ES_DATE": "2006-12-07",       "ENT_STATUS": "在营",       "REG_CAP": "1000万人民币",       "REC_CAP": "1000万人民币",       "SOCIAL_CREDIT_CODE": "91330108793696828A",       "LICENSE_NUMBER": "330108000000965",       "ORG_NO": "793696828",       "TAX_NUM": "91330108793696828A",       "ENT_TYPE": "有限责任公司(非自然人投资或控股的法人独资)",       "INDUSTRY_NAME_LV1": "租赁和商务服务业",       "INDUSTRY_NAME_LV2": "商务服务业",       "OP_FROM": "2006-12-07",       "OP_TO": "2036-12-06",       "COLLEGUES_NUM": "6",       "ENT_NAME_ENG": "Hangzhou Ali Baba Advertising Co.,Ltd.",       "FORMER_NAMES": "xx",       "REG_ORG": "xx",       "REG_ORG_PROVINCE": "浙江省",       "REG_ORG_CITY": "杭州市",       "REG_ORG_DISTRICT": "滨江区",       "STD_REG_CAP": 10000000     }   ]
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
     * @return GetBasicInfoResponseBody
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
