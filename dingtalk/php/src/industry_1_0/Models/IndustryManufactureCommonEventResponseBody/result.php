<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureCommonEventResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 返回内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 状态码
     *
     * @var string
     */
    public $httpCode;
    protected $_name = [
        'content'  => 'content',
        'httpCode' => 'httpCode',
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
        if (null !== $this->httpCode) {
            $res['httpCode'] = $this->httpCode;
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
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['httpCode'])) {
            $model->httpCode = $map['httpCode'];
        }

        return $model;
    }
}
