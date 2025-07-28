<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesRequest\fields\dataValue;

use AlibabaCloud\Tea\Model;

class openInfo extends Model
{
    /**
     * @var string[]
     */
    public $attribute;

    /**
     * @example abc
     *
     * @var string
     */
    public $openId;
    protected $_name = [
        'attribute' => 'attribute',
        'openId' => 'openId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attribute) {
            $res['attribute'] = $this->attribute;
        }
        if (null !== $this->openId) {
            $res['openId'] = $this->openId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attribute'])) {
            $model->attribute = $map['attribute'];
        }
        if (isset($map['openId'])) {
            $model->openId = $map['openId'];
        }

        return $model;
    }
}
