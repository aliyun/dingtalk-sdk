<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOfficialAccountUserBasicInfoRequest extends Model
{
    /**
     * @var string
     */
    public $bindingToken;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bindingToken' => 'bindingToken',
        'unionId'      => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindingToken) {
            $res['bindingToken'] = $this->bindingToken;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOfficialAccountUserBasicInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindingToken'])) {
            $model->bindingToken = $map['bindingToken'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
