<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetOrgLiveListRequest\requestBody;
use AlibabaCloud\Tea\Model;

class GetOrgLiveListRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @var requestBody
     */
    public $requestBody;
    protected $_name = [
        'corpId'      => 'corpId',
        'requestBody' => 'requestBody',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->requestBody) {
            $res['requestBody'] = null !== $this->requestBody ? $this->requestBody->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOrgLiveListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['requestBody'])) {
            $model->requestBody = requestBody::fromMap($map['requestBody']);
        }

        return $model;
    }
}
