<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmMokaOapiRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example /user/role/get
     *
     * @var string
     */
    public $apiCode;

    /**
     * @var mixed
     */
    public $params;
    protected $_name = [
        'apiCode' => 'apiCode',
        'params' => 'params',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->apiCode) {
            $res['apiCode'] = $this->apiCode;
        }
        if (null !== $this->params) {
            $res['params'] = $this->params;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmMokaOapiRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apiCode'])) {
            $model->apiCode = $map['apiCode'];
        }
        if (isset($map['params'])) {
            $model->params = $map['params'];
        }

        return $model;
    }
}
