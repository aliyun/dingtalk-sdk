<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmanufacturing_1_0\Models\IndustrializeManufactureQueryJobsResponseBody\content;
use AlibabaCloud\Tea\Model;

class IndustrializeManufactureQueryJobsResponseBody extends Model
{
    /**
     * @description 查询的数据结果
     *
     * @var content
     */
    public $content;

    /**
     * @description httpCode
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
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }
        if (null !== $this->httpCode) {
            $res['httpCode'] = $this->httpCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustrializeManufactureQueryJobsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }
        if (isset($map['httpCode'])) {
            $model->httpCode = $map['httpCode'];
        }

        return $model;
    }
}
