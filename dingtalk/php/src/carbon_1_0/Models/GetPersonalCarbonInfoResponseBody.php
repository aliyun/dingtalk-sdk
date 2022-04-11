<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPersonalCarbonInfoResponseBody extends Model
{
    /**
     * @description 文案
     *
     * @var string
     */
    public $content;

    /**
     * @description 减碳数据
     *
     * @var float
     */
    public $personalCarbonAmount;
    protected $_name = [
        'content'              => 'content',
        'personalCarbonAmount' => 'personalCarbonAmount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->personalCarbonAmount) {
            $res['personalCarbonAmount'] = $this->personalCarbonAmount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPersonalCarbonInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['personalCarbonAmount'])) {
            $model->personalCarbonAmount = $map['personalCarbonAmount'];
        }

        return $model;
    }
}
