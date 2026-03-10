<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\OptRecordWhiteAccountRequest\requestBody;
use AlibabaCloud\Tea\Model;

class OptRecordWhiteAccountRequest extends Model
{
    /**
     * @var requestBody
     */
    public $requestBody;
    protected $_name = [
        'requestBody' => 'requestBody',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestBody) {
            $res['requestBody'] = null !== $this->requestBody ? $this->requestBody->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OptRecordWhiteAccountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestBody'])) {
            $model->requestBody = requestBody::fromMap($map['requestBody']);
        }

        return $model;
    }
}
