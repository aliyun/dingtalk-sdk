<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetNodesResponseBody\nodes;

use AlibabaCloud\Tea\Model;

class statisticalInfo extends Model
{
    /**
     * @example 123
     *
     * @var int
     */
    public $wordCount;
    protected $_name = [
        'wordCount' => 'wordCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->wordCount) {
            $res['wordCount'] = $this->wordCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return statisticalInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['wordCount'])) {
            $model->wordCount = $map['wordCount'];
        }

        return $model;
    }
}
