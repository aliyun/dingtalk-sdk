<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\Tea\Model;

class SmartQuoteQueryServiceRequest extends Model
{
    /**
     * @var string
     */
    public $request;
    protected $_name = [
        'request' => 'request',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->request) {
            $res['request'] = $this->request;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SmartQuoteQueryServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['request'])) {
            $model->request = $map['request'];
        }

        return $model;
    }
}
