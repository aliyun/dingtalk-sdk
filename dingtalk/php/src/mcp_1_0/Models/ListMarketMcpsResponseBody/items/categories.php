<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ListMarketMcpsResponseBody\items;

use AlibabaCloud\Tea\Model;

class categories extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $displayName;
    protected $_name = [
        'code' => 'code',
        'displayName' => 'displayName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return categories
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }

        return $model;
    }
}
