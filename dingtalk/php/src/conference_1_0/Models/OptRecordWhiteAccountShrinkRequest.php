<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class OptRecordWhiteAccountShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $requestBodyShrink;
    protected $_name = [
        'requestBodyShrink' => 'requestBody',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestBodyShrink) {
            $res['requestBody'] = $this->requestBodyShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OptRecordWhiteAccountShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestBody'])) {
            $model->requestBodyShrink = $map['requestBody'];
        }

        return $model;
    }
}
