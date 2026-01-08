<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSmartDeviceAiSummaryResponseBody extends Model
{
    /**
     * @var bool
     */
    public $async;
    protected $_name = [
        'async' => 'async',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->async) {
            $res['async'] = $this->async;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSmartDeviceAiSummaryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['async'])) {
            $model->async = $map['async'];
        }

        return $model;
    }
}
