<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetGroupLiveListRequest\requestBody;
use AlibabaCloud\Tea\Model;

class GetGroupLiveListRequest extends Model
{
    /**
     * @var requestBody
     */
    public $requestBody;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'requestBody' => 'requestBody',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestBody) {
            $res['requestBody'] = null !== $this->requestBody ? $this->requestBody->toMap() : null;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetGroupLiveListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestBody'])) {
            $model->requestBody = requestBody::fromMap($map['requestBody']);
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
