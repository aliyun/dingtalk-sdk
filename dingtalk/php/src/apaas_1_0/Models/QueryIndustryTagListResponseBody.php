<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryIndustryTagListResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $industryList;
    protected $_name = [
        'industryList' => 'industryList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->industryList) {
            $res['industryList'] = $this->industryList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryIndustryTagListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['industryList'])) {
            if (!empty($map['industryList'])) {
                $model->industryList = $map['industryList'];
            }
        }

        return $model;
    }
}
