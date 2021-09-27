<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsearch_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSearchTabResponseBody extends Model
{
    /**
     * @description 数据源的id,范围为3000-4000
     *
     * @var int
     */
    public $tabId;
    protected $_name = [
        'tabId' => 'tabId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tabId) {
            $res['tabId'] = $this->tabId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSearchTabResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tabId'])) {
            $model->tabId = $map['tabId'];
        }

        return $model;
    }
}
