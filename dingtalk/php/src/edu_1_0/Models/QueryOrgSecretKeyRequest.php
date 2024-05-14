<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOrgSecretKeyRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example DDISV
     *
     * @var string
     */
    public $isvCode;

    /**
     * @example manger1234
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'isvCode'  => 'isvCode',
        'opUserId' => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgSecretKeyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
