<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetIndustryTypeResponseBody extends Model
{
    /**
     * @description 行业类型
     *
     * @var string
     */
    public $industryType;
    protected $_name = [
        'industryType' => 'industryType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->industryType) {
            $res['industryType'] = $this->industryType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetIndustryTypeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['industryType'])) {
            $model->industryType = $map['industryType'];
        }

        return $model;
    }
}
